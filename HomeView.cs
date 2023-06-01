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

        private void levelAdd(object sender, EventArgs e)
        {
            var game = Game.Instance;
            game.AddLevel();
            SelectLevelPic(game.Level);
        }
        private void LevelSub(object sender, EventArgs e)
        {
            var game = Game.Instance;
            game.SubLevel();
            SelectLevelPic(game.Level);
        }

        private void SelectLevelPic(int level)
        {
            string imgName = string.Format("level{0:d2}", level - 1);
            object bitmap = Properties.Resources.ResourceManager.GetObject(imgName, Properties.Resources.Culture);
            pbxLevel.Image = (Bitmap)bitmap;
        }
    }
}
