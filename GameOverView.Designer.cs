namespace Tetris
{
    partial class GameOverView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            title = new PictureBox();
            superButton1 = new SuperButton();
            ((System.ComponentModel.ISupportInitialize)title).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.Image = Properties.Resources.text_gameover;
            title.Location = new Point(33, 130);
            title.Margin = new Padding(2);
            title.Name = "title";
            title.Size = new Size(347, 82);
            title.SizeMode = PictureBoxSizeMode.AutoSize;
            title.TabIndex = 0;
            title.TabStop = false;
            // 
            // superButton1
            // 
            superButton1.BackgroundImage = Properties.Resources.button_mode00;
            superButton1.BackgroundImageLayout = ImageLayout.Zoom;
            superButton1.Font = new Font("Kleptocracy Titling Rg", 20F, FontStyle.Bold, GraphicsUnit.Point);
            superButton1.ForeColor = Color.FromArgb(33, 90, 55);
            superButton1.Location = new Point(134, 459);
            superButton1.Margin = new Padding(6, 5, 6, 5);
            superButton1.Name = "superButton1";
            superButton1.PressedBackgroundImage = Properties.Resources.button_mode00_pressed;
            superButton1.Size = new Size(151, 81);
            superButton1.TabIndex = 1;
            superButton1.Text = "RETRY";
            superButton1.Click += Retry;
            // 
            // GameOverView
            // 
            AutoScaleDimensions = new SizeF(5F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(superButton1);
            Controls.Add(title);
            Font = new Font("Kleptocracy Titling Rg", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(2);
            Name = "GameOverView";
            Size = new Size(418, 838);
            ((System.ComponentModel.ISupportInitialize)title).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox title;
        private SuperButton superButton1;
    }
}
