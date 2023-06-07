using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class GameView : UserControl
    {
        private GameOverView gameOverView;

        public GameView()
        {
            InitializeComponent();
            gameOverView = new GameOverView();
            leftBox.Controls.Add(gameOverView);
            InitGame();
        }

        private void InitGame()
        {
            var game = Game.Instance;
            game.Init(map.Size, nextBrickBox.Size);
            game.OnStart += OnStartGame;
            game.OnStop += OnStopGame;
            game.OnMapPaint += OnMapPaint;
            game.OnNextBrickPaint += OnNextBrickPaint;
            game.OnMsgUpdate += OnMsgUpdate;
        }

        public void StartGame()
        {
            Game.Instance.Start();
            OnMsgUpdate();
        }

        private void UpdateGame(object sender, EventArgs e)
        {
            Game.Instance.Update();
        }

        private void ShowHome(object sender, EventArgs e)
        {
            MainForm.Instance.ShowHome();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (timer.Enabled && keyData is Keys.Up or Keys.Down or Keys.Left or Keys.Right or Keys.Space)
            {
                switch (keyData)
                {
                    case Keys.Up:
                        Game.Instance.RotateBrick();
                        break;
                    case Keys.Down:
                        Game.Instance.MoveBrick(Direction.Down);
                        break;
                    case Keys.Left:
                        Game.Instance.MoveBrick(Direction.Left);
                        break;
                    case Keys.Right:
                        Game.Instance.MoveBrick(Direction.Right);
                        break;
                    case Keys.Space:
                        Game.Instance.DownBrick();
                        break;
                }

                return true;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void OnStartGame()
        {
            timer.Enabled = true;
            map.Show();
            gameOverView.Hide();
            retryBtn.Visible = false;
        }

        private void OnStopGame()
        {
            timer.Enabled = false;
            SaveUserScore();
            gameOverView.Show();
            retryBtn.Visible = true;
            gameOverView.ShowRank();
            gameOverView.Sparkle();
            map.Hide();
        }

        private void OnMapPaint(Bitmap img)
        {
            map.Image = img;
        }

        private void OnNextBrickPaint(Bitmap img)
        {
            nextBrickBox.Image = img;
        }
        /// <summary>
        /// 更新游戏界面的信息：等级、分数、进度条 以及 下落速度
        /// </summary>
        private void OnMsgUpdate()
        {
            var game = Game.Instance;
            level.Text = game.level.ToString();
            score.Text = game.score.ToString();
            timer.Interval = game.interval;

            pbarGoal.Value = (int)(pbarGoal.TabIndex * game.goalRatio);
        }

        private void Retry(object sender, EventArgs e)
        {
            Game.Instance.Start();
        }

        private void SaveUserScore()
        {
            Game.Instance.user.score = Game.Instance.score;
            if (!SQLiteHelper.Instance.SaveOrUpdateUserScore(Game.Instance.user))
            {
                Console.WriteLine("更新分数失败");
            }
        }
    }
}
