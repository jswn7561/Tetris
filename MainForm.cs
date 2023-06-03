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
    public partial class MainForm : Form
    {
        private static MainForm instance;
        public static MainForm Instance => instance ??= new MainForm();
        private HomeView homeView;
        private GameView gameView;

        public MainForm()
        {
            instance = this;
            InitializeComponent();
            homeView = new HomeView();
            gameView = new GameView();
            content.Controls.Add(homeView);
            content.Controls.Add(gameView);
            SQLiteHelper.Instance.CreateTable();
        }

        public void ShowHome()
        {
            homeView.Show();
            gameView.Hide();
        }

        public void ShowGame()
        {
            gameView.Show();
            homeView.Hide();
            gameView.StartGame();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            ShowHome();
        }
    }
}
