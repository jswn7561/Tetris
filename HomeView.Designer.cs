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
            startBtn = new SuperButton();
            selectDifficult = new Label();
            btnDifficultSelectRight = new SuperButton();
            btnDifficultSelectLeft = new SuperButton();
            pbxLevel = new PictureBox();
            tipLabel = new Label();
            nameSbtn = new SuperButton();
            nameTextBox = new TextBox();
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
            // startBtn
            // 
            startBtn.BackColor = Color.Transparent;
            startBtn.Font = new Font("Kleptocracy Titling Rg", 40F, FontStyle.Bold, GraphicsUnit.Point);
            startBtn.ForeColor = Color.White;
            startBtn.Location = new Point(210, 717);
            startBtn.Margin = new Padding(12, 10, 12, 10);
            startBtn.Name = "startBtn";
            startBtn.PressedBackgroundImage = null;
            startBtn.Size = new Size(155, 75);
            startBtn.TabIndex = 2;
            startBtn.Text = "Start";
            startBtn.Click += StartGame;
            // 
            // selectDifficult
            // 
            selectDifficult.AutoSize = true;
            selectDifficult.Font = new Font("Kleptocracy Titling Rg", 20F, FontStyle.Bold, GraphicsUnit.Point);
            selectDifficult.ForeColor = Color.White;
            selectDifficult.Location = new Point(189, 506);
            selectDifficult.Name = "selectDifficult";
            selectDifficult.Size = new Size(196, 33);
            selectDifficult.TabIndex = 3;
            selectDifficult.Text = "SELECT DIFFUCULT";
            selectDifficult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDifficultSelectRight
            // 
            btnDifficultSelectRight.BackgroundImage = Properties.Resources.difficulty_select_right;
            btnDifficultSelectRight.BackgroundImageLayout = ImageLayout.Center;
            btnDifficultSelectRight.Font = new Font("Kleptocracy Titling Rg", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDifficultSelectRight.Location = new Point(362, 591);
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
            btnDifficultSelectLeft.Location = new Point(186, 591);
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
            pbxLevel.Location = new Point(227, 554);
            pbxLevel.Name = "pbxLevel";
            pbxLevel.Size = new Size(114, 116);
            pbxLevel.TabIndex = 6;
            pbxLevel.TabStop = false;
            // 
            // tipLabel
            // 
            tipLabel.Font = new Font("Kleptocracy Titling Rg", 11F, FontStyle.Bold, GraphicsUnit.Point);
            tipLabel.ForeColor = Color.Tomato;
            tipLabel.Location = new Point(166, 471);
            tipLabel.Name = "tipLabel";
            tipLabel.Size = new Size(236, 18);
            tipLabel.TabIndex = 8;
            tipLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameSbtn
            // 
            nameSbtn.BackgroundImage = Properties.Resources.input_box;
            nameSbtn.BackgroundImageLayout = ImageLayout.Center;
            nameSbtn.Font = new Font("Kleptocracy Titling Rg", 14F, FontStyle.Bold, GraphicsUnit.Point);
            nameSbtn.Location = new Point(166, 413);
            nameSbtn.Margin = new Padding(3, 2, 3, 2);
            nameSbtn.Name = "nameSbtn";
            nameSbtn.PressedBackgroundImage = null;
            nameSbtn.RightToLeft = RightToLeft.No;
            nameSbtn.Size = new Size(236, 56);
            nameSbtn.TabIndex = 9;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = SystemColors.HighlightText;
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Font = new Font("Kleptocracy Titling Rg", 14F, FontStyle.Bold, GraphicsUnit.Point);
            nameTextBox.Location = new Point(182, 429);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "please enter a nickname";
            nameTextBox.Size = new Size(206, 23);
            nameTextBox.TabIndex = 10;
            nameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // HomeView
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            Controls.Add(nameTextBox);
            Controls.Add(nameSbtn);
            Controls.Add(tipLabel);
            Controls.Add(pbxLevel);
            Controls.Add(btnDifficultSelectLeft);
            Controls.Add(btnDifficultSelectRight);
            Controls.Add(selectDifficult);
            Controls.Add(startBtn);
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
        private SuperButton startBtn;
        private Label selectDifficult;
        private SuperButton btnDifficultSelectRight;
        private SuperButton btnDifficultSelectLeft;
        private PictureBox pbxLevel;
        private Label tipLabel;
        private SuperButton nameSbtn;
        private TextBox nameTextBox;
    }
}
