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
            selectDifficult = new Label();
            btnDifficultSelectRight = new SuperButton();
            btnDifficultSelectLeft = new SuperButton();
            pbxLevel = new PictureBox();
            nameTextBox = new TextBox();
            tipLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxLevel).BeginInit();
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
            superButton1.Location = new Point(206, 692);
            superButton1.Margin = new Padding(12, 10, 12, 10);
            superButton1.Name = "superButton1";
            superButton1.PressedBackgroundImage = null;
            superButton1.Size = new Size(155, 75);
            superButton1.TabIndex = 2;
            superButton1.Text = "Start";
            superButton1.Click += StartGame;
            // 
            // selectDifficult
            // 
            selectDifficult.AutoSize = true;
            selectDifficult.Font = new Font("Kleptocracy Titling Rg", 20F, FontStyle.Bold, GraphicsUnit.Point);
            selectDifficult.ForeColor = Color.White;
            selectDifficult.Location = new Point(165, 450);
            selectDifficult.Name = "selectDifficult";
            selectDifficult.Size = new Size(243, 41);
            selectDifficult.TabIndex = 3;
            selectDifficult.Text = "SELECT DIFFUCULT";
            selectDifficult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDifficultSelectRight
            // 
            btnDifficultSelectRight.BackgroundImage = Properties.Resources.difficulty_select_right;
            btnDifficultSelectRight.BackgroundImageLayout = ImageLayout.Center;
            btnDifficultSelectRight.Font = new Font("Kleptocracy Titling Rg", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDifficultSelectRight.Location = new Point(342, 548);
            btnDifficultSelectRight.Margin = new Padding(3, 2, 3, 2);
            btnDifficultSelectRight.Name = "btnDifficultSelectRight";
            btnDifficultSelectRight.PressedBackgroundImage = Properties.Resources.difficulty_select_right_pressed;
            btnDifficultSelectRight.RightToLeft = RightToLeft.No;
            btnDifficultSelectRight.Size = new Size(20, 43);
            btnDifficultSelectRight.TabIndex = 4;
            btnDifficultSelectRight.Click += AddDifficult;
            // 
            // btnDifficultSelectLeft
            // 
            btnDifficultSelectLeft.BackgroundImage = Properties.Resources.difficulty_select_left;
            btnDifficultSelectLeft.BackgroundImageLayout = ImageLayout.Center;
            btnDifficultSelectLeft.Font = new Font("Kleptocracy Titling Rg", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDifficultSelectLeft.Location = new Point(196, 548);
            btnDifficultSelectLeft.Margin = new Padding(3, 2, 3, 2);
            btnDifficultSelectLeft.Name = "btnDifficultSelectLeft";
            btnDifficultSelectLeft.PressedBackgroundImage = Properties.Resources.difficulty_select_left_pressed;
            btnDifficultSelectLeft.RightToLeft = RightToLeft.No;
            btnDifficultSelectLeft.Size = new Size(20, 43);
            btnDifficultSelectLeft.TabIndex = 5;
            btnDifficultSelectLeft.Click += SubDifficult;
            // 
            // pbxLevel
            // 
            pbxLevel.BackgroundImage = Properties.Resources.level00;
            pbxLevel.BackgroundImageLayout = ImageLayout.Center;
            pbxLevel.Location = new Point(223, 514);
            pbxLevel.Name = "pbxLevel";
            pbxLevel.Size = new Size(114, 116);
            pbxLevel.TabIndex = 6;
            pbxLevel.TabStop = false;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = SystemColors.Info;
            nameTextBox.Font = new Font("Kleptocracy Titling Rg", 14F, FontStyle.Bold, GraphicsUnit.Point);
            nameTextBox.ForeColor = SystemColors.WindowText;
            nameTextBox.Location = new Point(172, 353);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "请输入昵称";
            nameTextBox.Size = new Size(224, 36);
            nameTextBox.TabIndex = 7;
            nameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // tipLabel
            // 
            tipLabel.AutoSize = true;
            tipLabel.ForeColor = Color.Tomato;
            tipLabel.Location = new Point(201, 392);
            tipLabel.Name = "tipLabel";
            tipLabel.Size = new Size(0, 18);
            tipLabel.TabIndex = 8;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(tipLabel);
            Controls.Add(nameTextBox);
            Controls.Add(pbxLevel);
            Controls.Add(btnDifficultSelectLeft);
            Controls.Add(btnDifficultSelectRight);
            Controls.Add(selectDifficult);
            Controls.Add(superButton1);
            Controls.Add(pictureBox1);
            Font = new Font("Kleptocracy Titling Rg", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(0);
            Name = "HomeView";
            Size = new Size(568, 838);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxLevel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private SuperButton superButton1;
        private Label selectDifficult;
        private SuperButton btnDifficultSelectRight;
        private SuperButton btnDifficultSelectLeft;
        private PictureBox pbxLevel;
        private TextBox nameTextBox;
        private Label tipLabel;
    }
}
