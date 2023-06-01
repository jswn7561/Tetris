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
    public partial class GameProgressBar : UserControl
    {
        private int val;//进度值
        private Color PBackgroundColor = Color.FromArgb(0, 0, 0);//初始化颜色
        private Color PForegroundColor = Color.FromArgb(118, 186, 0);
        public GameProgressBar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 背景色
        /// </summary>
        public Color pBackgroundColor
        {
            get
            {
                return PBackgroundColor;
            }
            set
            {
                PBackgroundColor = value;
                this.BackColor = PBackgroundColor;
            }
        }
        /// <summary>
        /// 前景色
        /// </summary>
        public Color pForegroundColor
        {
            get
            {
                return PForegroundColor;
            }
            set
            {
                PForegroundColor = value;
            }
        }
        /// <summary>
        /// 当前值
        /// </summary>
        public int Val
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
                this.Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(PForegroundColor);
            float percent = val / 100f;
            Rectangle rect = this.ClientRectangle;
            rect.Width = (int)((float)rect.Width * percent);
            rect.Height = this.Height;
            g.FillRectangle(brush, rect);
            brush.Dispose();
            g.Dispose();
        }

    }
}
