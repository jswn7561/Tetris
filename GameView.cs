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
        public GameView()
        {
            InitializeComponent();
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
        }

        public void StartGame()
        {
            Game.Instance.Start();
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
            if (keyData is Keys.Up or Keys.Down or Keys.Left or Keys.Right)
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
        }

        private void OnStopGame()
        {
            timer.Enabled = false;
            var result = MessageBox.Show("Game Over");
            if (result == DialogResult.OK)
            {
                Game.Instance.Start();
            }
        }

        private void OnMapPaint(Bitmap img)
        {
            map.Image = img;
        }

        private void OnNextBrickPaint(Bitmap img)
        {
            nextBrickBox.Image = img;
        }
    }
}
