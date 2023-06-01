using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (timer.Enabled && keyData is Keys.Up or Keys.Down or Keys.Left or Keys.Right)
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
        }

        private void OnStopGame()
        {
            timer.Enabled = false;
            gameOverView.Show();
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

        private void OnMsgUpdate()
        {
            var game = Game.Instance;
            level.Text = game.level.ToString();
            score.Text = game.score.ToString();
            timer.Interval = game.interval;

            pbarGoal.Value = (int)(pbarGoal.TabIndex * game.goalRatio);
        }
    }
}
