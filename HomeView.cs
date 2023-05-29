namespace Tetris
{
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
            InitGame();
        }

        private void InitGame()
        {
            Game.Instance.Init(map, timer);
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
    }
}