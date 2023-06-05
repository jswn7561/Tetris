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
    public partial class GameOverView : UserControl
    {
        private static Dictionary<int, Label[]> RankLabels = new();
        public GameOverView()
        {
            InitializeComponent();
            RankLabels.Add(1, new Label[] { RankLabel1, NameLabel1, SocreLabel1 });
            RankLabels.Add(2, new Label[] { RankLabel2, NameLabel2, ScoreLabel2 });
            RankLabels.Add(3, new Label[] { RankLabel3, NameLabel3, ScoreLabel3 });
            RankLabels.Add(4, new Label[] { RankLabel4, NameLabel4, ScoreLabel4 });
            RankLabels.Add(5, new Label[] { RankLabel5, NameLabel5, ScoreLabel5 });
            RankLabels.Add(6, new Label[] { RankLabel6, NameLabel6, ScoreLabel6 });
            RankLabels.Add(7, new Label[] { RankLabel7, NameLabel7, ScoreLabel7 });
            RankLabels.Add(8, new Label[] { RankLabel8, NameLabel8, ScoreLabel8 });
            RankLabels.Add(9, new Label[] { RankLabel9, NameLabel9, ScoreLabel9 });
            RankLabels.Add(10, new Label[] { RankLabel10, NameLabel10, ScoreLabel10 });
        }

        public void ShowRank()
        {
            List<UserInfo> userList = SQLiteHelper.Instance.QueryTopUserList(RankLabels.Count);
            int i = 1;
            foreach (UserInfo user in userList)
            {
                RankLabels[i][0].Text = i.ToString();
                RankLabels[i][1].Text = user.name;
                RankLabels[i][2].Text = user.score.ToString();
                if (Game.Instance.user.name == user.name)
                {
                    RankLabels[i][0].ForeColor = Color.Goldenrod;
                    RankLabels[i][0].Font = new Font("Kleptocracy Titling Rg", 16F, FontStyle.Bold, GraphicsUnit.Point);
                    RankLabels[i][1].ForeColor = Color.Goldenrod;
                    RankLabels[i][1].Font = new Font("Kleptocracy Titling Rg", 16F, FontStyle.Bold, GraphicsUnit.Point);
                    RankLabels[i][2].ForeColor = Color.Goldenrod;
                    RankLabels[i][2].Font = new Font("Kleptocracy Titling Rg", 16F, FontStyle.Bold, GraphicsUnit.Point);
                }
                i++;
            }
        }
        public async void Sparkle()
        {
            await Task.Run(() =>
            {
                int k = 10; // game over 闪动次数
                while (k > 0)
                {
                    GameOverTitle.Invoke(new Action(() =>
                    {
                        GameOverTitle.Visible = !GameOverTitle.Visible;
                    }));
                    Thread.Sleep(1000);
                    k--;
                }
            });
        }
    }
}
