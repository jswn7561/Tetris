using Tetris.Properties;

namespace Tetris
{
    public partial class GameView : Form
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

        private void StartGame(object sender, EventArgs e)
        {
            Game.Instance.Start();
        }

        private void UpdateGame(object sender, EventArgs e)
        {
            Game.Instance.Update();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            var key = e.KeyData;
            switch (key)
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
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData is Keys.Up or Keys.Down or Keys.Left or Keys.Right)
                return false;

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