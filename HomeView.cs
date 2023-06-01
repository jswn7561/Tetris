using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tetris
{
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void StartGame(object sender, EventArgs e)
        {
            MainForm.Instance.ShowGame();
        }

        private void AddDifficult(object sender, EventArgs e)
        {
            var game = Game.Instance;
            game.AddLevel();
            SelectDifficultPic(game.difficuleLevel);
        }
        private void SubDifficult(object sender, EventArgs e)
        {
            var game = Game.Instance;
            game.SubLevel();
            SelectDifficultPic(game.difficuleLevel);
        }

        private void SelectDifficultPic(int difficuleLevel)
        {
            string imgName = string.Format("level{0:d2}", difficuleLevel - 1);
            object bitmap = Properties.Resources.ResourceManager.GetObject(imgName, Properties.Resources.Culture);
            pbxLevel.Image = (Bitmap)bitmap;
        }
    }
}
