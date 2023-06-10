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
            if (nameTextBox.Text == "")
            {
                tipLabel.Text = "Hi, leave your name!";
            }
            else
            {
                Game.Instance.SetName(nameTextBox.Text);
                MainForm.Instance.ShowGame();
            }
        }

        /// <summary>
        /// 右箭头按钮功能：增加困难等级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDifficult(object sender, EventArgs e)
        {
            var game = Game.Instance;
            game.AddDifficultyLevel();
            SelectDifficultPic(game.difficultyLevel);
        }
        
        /// <summary>
        /// 左箭头按钮功能：减小困难等级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubDifficult(object sender, EventArgs e)
        {
            var game = Game.Instance;
            game.SubDifficultyLevel();
            SelectDifficultPic(game.difficultyLevel);
        }
        /// <summary>
        /// 根据困难等级选择对应的图片
        /// </summary>
        /// <param name="difficuleLevel">困难等级</param>
        private void SelectDifficultPic(int difficuleLevel)
        {
            string imgName = string.Format("level{0:d2}", difficuleLevel - 1);
            object bitmap = Properties.Resources.ResourceManager.GetObject(imgName, Properties.Resources.Culture);
            pbxLevel.Image = (Bitmap)bitmap;
        }
    }
}
