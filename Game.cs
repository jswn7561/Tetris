using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Unicode;
using Newtonsoft.Json;
using Tetris.Properties;
using Timer = System.Windows.Forms.Timer;

namespace Tetris
{
    internal class Game
    {
        private static Game? instance;
        public static Game Instance => instance ??= new Game();
        public Size mapSize { get; private set; }
        public Brick brick { get; private set; }
        public PictureBox map { get; private set; }
        public Timer timer { get; private set; }
        public bool[,] data { get; private set; }
        private BrickData[]? brickConfigs;
        private Random random;

        public void Init(PictureBox map, Timer timer)
        {
            this.map = map;
            this.timer = timer;
            mapSize = map.Size;
            var json = Encoding.UTF8.GetString(Resources.BrickConfigs);
            brickConfigs = JsonConvert.DeserializeObject<BrickData[]>(json);
            random = new Random();
        }

        private void InitData()
        {
            data = new bool[(mapSize.Width + Brick.Space) / Brick.SizeWithSpace,
                (mapSize.Height + Brick.Space) / Brick.SizeWithSpace];
        }

        public void Start()
        {
            InitData();
            CreateBrick();
            Paint();
        }

        public void Stop()
        {
            timer.Enabled = false;
            var result = MessageBox.Show("Game Over");
            if (result == DialogResult.OK)
            {
                Restart();
            }
        }

        public void Restart()
        {
            Start();
            timer.Enabled = true;
        }

        public void Update()
        {
            MoveBrick(Direction.Down);
        }

        public void CreateBrick()
        {
            brick = new Brick(brickConfigs[random.Next(0, brickConfigs.Length)]);
        }

        public void MoveBrick(Direction direction)
        {
            brick.Move(direction);
            Paint();
        }

        public void RotateBrick()
        {
            brick.Rotate();
            Paint();
        }

        public void CombineBrick()
        {
            brick.Combine();
            RemoveFilledRows();
            CreateBrick();
            if (brick.DetectCollision())
            {
                Stop();
            }
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
        }

        private void Paint()
        {
            var g = map.CreateGraphics();
            g.Clear(Color.Black);
            brick.Paint(g);

            for (int i = 0, lenX = data.GetLength(0); i < lenX; i++)
            {
                for (int j = 0, lenY = data.GetLength(1); j < lenY; j++)
                {
                    if (data[i, j])
                    {
                        g.FillRectangle(new SolidBrush(Color.CadetBlue), i * Brick.SizeWithSpace, j * Brick.SizeWithSpace, Brick.Size, Brick.Size);
                    }
                }
            }
        }
    }
}
