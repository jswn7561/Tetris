using System;
using System.Collections.Generic;
using System.Media;
using System.Resources;
using System.Text;
using System.Text.Unicode;
using Newtonsoft.Json;
using Tetris.Properties;
using Timer = System.Windows.Forms.Timer;

namespace Tetris
{
    internal class Game
    {
        private static Game instance;
        public static Game Instance => instance ??= new Game();
        public Size mapSize { get; private set; }
        public Brick brick { get; private set; }
        public Brick nextBrick { get; private set; }
        public int difficuleLevel { get; private set; }
        public UserInfo user { get; private set; }
        public int level { get => levelControl.level; }
        public int score { get => levelControl.score; }
        public int line { get => levelControl.line; }
        public int interval { get => levelControl.interval; }
        public float goalRatio { get => levelControl.goalRatio; }
        public bool[,] data { get; private set; }
        public event Action<Bitmap> OnMapPaint;
        public event Action<Bitmap> OnNextBrickPaint;
        public event Action OnStart;
        public event Action OnStop;
        public event Action OnMsgUpdate;

        private BrickData[] brickConfigs;
        private Random random;
        private Bitmap mapImg;
        private Bitmap nextBrickImg;
        private LevelControl levelControl = new LevelControl();

        // 创建SoundPlayer对象
        SoundPlayer player = new SoundPlayer();

        public void Init(Size mapSize, Size nextBrickBoxSize)
        {
            this.mapSize = mapSize;
            mapImg = new Bitmap(mapSize.Width, mapSize.Height);
            nextBrickImg = new Bitmap(nextBrickBoxSize.Width, nextBrickBoxSize.Height);
            //var json = Encoding.UTF8.GetString(Resources.BrickConfigs);
            //可匹配颜色
            string json = Encoding.UTF8.GetString(Resources.BrickConfigs); 
            brickConfigs = JsonConvert.DeserializeObject<BrickData[]>(json);
            random = new Random();
            difficuleLevel = 1;
        }

        private void InitData()
        {
            data = new bool[(mapSize.Width + Brick.Space) / Brick.SizeWithSpace,
                (mapSize.Height + Brick.Space) / Brick.SizeWithSpace];
        }

        public void Start()
        {
            levelControl.Init(difficuleLevel);
            InitData();
            CreateBrick();
            PaintMap();
            OnMsgUpdate?.Invoke();
            OnStart?.Invoke();
            // 背景音效
            player.SoundLocation = @"..\..\..\Assets\AudioClip\main_music.wav";
            player.Play();
        }

        public void Stop()
        {
            OnStop?.Invoke();
            // 结束音效
            player.SoundLocation = @"..\..\..\Assets\AudioClip\end_game.wav";
            player.Play();
        }

        public void Update()
        {
            MoveBrick(Direction.Down);
        }

        public void CreateBrick()
        {
            if (nextBrick == null)
            {
                brick = new Brick(brickConfigs[random.Next(0, brickConfigs.Length)]);
                nextBrick = new Brick(brickConfigs[random.Next(0, brickConfigs.Length)]);
            }
            else
            {
                brick = nextBrick;
                nextBrick = new Brick(brickConfigs[random.Next(0, brickConfigs.Length)]);
            }

            if (brick.DetectCollision())
            {
                Stop();
            }

            PaintNextBrick();
        }

        public void MoveBrick(Direction direction)
        {
            brick.Move(direction);
            PaintMap();
        }

        public void RotateBrick()
        {
            brick.Rotate();
            PaintMap();
        }

        public void CombineBrick()
        {
            brick.Combine();

            //落到底部音效
            player.SoundLocation = @"..\..\..\Assets\AudioClip\hold.wav";
            player.PlaySync(); //UI同步
            player.SoundLocation = @"..\..\..\Assets\AudioClip\main_music.wav";
            player.Play();     //异步

            RemoveFilledRows();
            CreateBrick();
        }

        private void RemoveFilledRows()
        {
            var unfilledRowIndices = new List<int>();
            for (int j = data.GetLength(1) - 1; j >= 0; j--)
            {
                var isFilled = true;
                for (int i = data.GetLength(0) - 1; i >= 0; i--)
                {
                    if (!data[i, j])
                    {
                        isFilled = false;
                        break;
                    }
                }

                if (!isFilled)
                {
                    unfilledRowIndices.Add(j);
                }
            }

            if (unfilledRowIndices.Count == data.GetLength(1))
            {
                return;
            }

            var newJ = data.GetLength(1) - 1;
            foreach (var j in unfilledRowIndices)
            {
                if (newJ != j)
                {
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        data[i, newJ] = data[i, j];
                    }
                }

                --newJ;
            }

            for (int j = 0, len = data.GetLength(1) - unfilledRowIndices.Count; j < len; j++)
            {
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    data[i, j] = false;
                }
            }
            //消行音效
            player.SoundLocation = @"..\..\..\Assets\AudioClip\clear_row.wav";
            player.PlaySync(); //UI同步
            player.SoundLocation = @"..\..\..\Assets\AudioClip\main_music.wav";
            player.Play();     //异步

            // 更新分数等级
            levelControl.Update(data.GetLength(1) - unfilledRowIndices.Count);
            OnMsgUpdate?.Invoke();
        }

        private void PaintMap()
        {
            var g = Graphics.FromImage(mapImg);
            g.Clear(Color.Transparent);

            for (int i = 0, lenX = data.GetLength(0); i < lenX; i++)
            {
                for (int j = 0, lenY = data.GetLength(1); j < lenY; j++)
                {
                    if (data[i, j])
                    {
                        //g.FillRectangle(new SolidBrush(Color.CadetBlue), i * Brick.SizeWithSpace, j * Brick.SizeWithSpace, Brick.Size, Brick.Size);
                        //颜色改成灰色
                        g.FillRectangle(new SolidBrush(Color.Gray), i * Brick.SizeWithSpace, j * Brick.SizeWithSpace, Brick.Size, Brick.Size);
                    }
                }
            }

            brick.Paint(g);
            OnMapPaint?.Invoke(mapImg);
        }

        private void PaintNextBrick()
        {
            var scale = 0.5f;
            var scaleSizeWithSpace = Brick.SizeWithSpace * scale;
            var bound = nextBrick.GetBound();
            var padding = new PointF((nextBrickImg.Size.Width - bound.Width * scaleSizeWithSpace) / 2,
                (nextBrickImg.Size.Height - bound.Height * scaleSizeWithSpace) / 2);
            var origin = new PointF(padding.X - bound.X * scaleSizeWithSpace,
                padding.Y - bound.Y * scaleSizeWithSpace);

            var g = Graphics.FromImage(nextBrickImg);
            g.Clear(Color.Transparent);
            nextBrick.Paint(g, origin.X, origin.Y, scale);
            OnNextBrickPaint?.Invoke(nextBrickImg);
        }

        public void AddLevel()
        {
            if (difficuleLevel >= 3)
            {
                return;
            }
            difficuleLevel++;
        }
        public void SubLevel()
        {
            if (difficuleLevel <= 1)
            {
                return;
            }
            difficuleLevel--;
        }

        public void SetName(string n)
        {
            user = new UserInfo { name = n };
        }
    }
}
