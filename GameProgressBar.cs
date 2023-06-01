using Newtonsoft.Json.Linq;
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
        private Color pBackgroundColor = Color.FromArgb(0, 0, 0);//初始化颜色
        private Color pForegroundColor = Color.FromArgb(118, 186, 0);
        public GameProgressBar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 背景色
        /// </summary>
        public Color PBackgroundColor
        {
            get
            {
                return pBackgroundColor;
            }
            set
            {
                pBackgroundColor = value;
                this.BackColor = pBackgroundColor;
            }
        }
        /// <summary>
        /// 前景色
        /// </summary>
        public Color PForegroundColor
        {
            get
            {
                return pForegroundColor;
            }
            set
            {
                pForegroundColor = value;
            }
        }
        /// <summary>
        /// 当前值
        /// </summary>
        public int Value
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
            SolidBrush brush = new SolidBrush(pForegroundColor);
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
