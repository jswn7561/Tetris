namespace Tetris
{
    partial class HomeView
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
            pictureBox1 = new PictureBox();
            superButton1 = new SuperButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.xbrick_title_new;
            pictureBox1.Location = new Point(112, 82);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // superButton1
            // 
            superButton1.BackColor = Color.Transparent;
            superButton1.Font = new Font("Kleptocracy Titling Rg", 40F, FontStyle.Bold, GraphicsUnit.Point);
            superButton1.ForeColor = Color.White;
            superButton1.Location = new Point(210, 717);
            superButton1.Margin = new Padding(12, 10, 12, 10);
            superButton1.Name = "superButton1";
            superButton1.PressedBackgroundImage = null;
            superButton1.Size = new Size(155, 75);
            superButton1.TabIndex = 2;
            superButton1.Text = "Start";
            superButton1.Click += StartGame;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(superButton1);
            Controls.Add(pictureBox1);
            Font = new Font("Kleptocracy Titling Rg", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(0);
            Name = "HomeView";
            Size = new Size(568, 838);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private SuperButton superButton1;
    }
}
