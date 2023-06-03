namespace Tetris
{
    partial class GameView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameView));
            map = new PictureBox();
            rightBox = new Panel();
            retryBtn = new SuperButton();
            pbarGoal = new GameProgressBar();
            homeBtn = new SuperButton();
            nextBrickBox = new PictureBox();
            label1 = new Label();
            score = new Label();
            scoreTitle = new Label();
            goalTitle = new Label();
            level = new Label();
            levelTitle = new Label();
            timer = new System.Windows.Forms.Timer(components);
            leftBox = new Panel();
            ((System.ComponentModel.ISupportInitialize)map).BeginInit();
            rightBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nextBrickBox).BeginInit();
            leftBox.SuspendLayout();
            SuspendLayout();
            // 
            // map
            // 
            map.BackColor = Color.Black;
            map.Location = new Point(0, 0);
            map.Margin = new Padding(0);
            map.Name = "map";
            map.Size = new Size(418, 838);
            map.TabIndex = 1;
            map.TabStop = false;
            // 
            // rightBox
            // 
            rightBox.BackColor = Color.FromArgb(38, 12, 2);
            rightBox.Controls.Add(retryBtn);
            rightBox.Controls.Add(pbarGoal);
            rightBox.Controls.Add(homeBtn);
            rightBox.Controls.Add(nextBrickBox);
            rightBox.Controls.Add(label1);
            rightBox.Controls.Add(score);
            rightBox.Controls.Add(scoreTitle);
            rightBox.Controls.Add(goalTitle);
            rightBox.Controls.Add(level);
            rightBox.Controls.Add(levelTitle);
            rightBox.Font = new Font("Kleptocracy Titling Rg", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rightBox.Location = new Point(418, 0);
            rightBox.Margin = new Padding(3, 2, 3, 2);
            rightBox.Name = "rightBox";
            rightBox.Size = new Size(150, 838);
            rightBox.TabIndex = 2;
            // 
            // retryBtn
            // 
            retryBtn.BackColor = Color.Transparent;
            retryBtn.BackgroundImage = (Image)resources.GetObject("retryBtn.BackgroundImage");
            retryBtn.BackgroundImageLayout = ImageLayout.Zoom;
            retryBtn.Font = new Font("Kleptocracy Titling Rg", 15F, FontStyle.Bold, GraphicsUnit.Point);
            retryBtn.ForeColor = Color.Black;
            retryBtn.Location = new Point(48, 757);
            retryBtn.Margin = new Padding(4, 3, 4, 3);
            retryBtn.Name = "retryBtn";
            retryBtn.PressedBackgroundImage = (Image)resources.GetObject("retryBtn.PressedBackgroundImage");
            retryBtn.Size = new Size(60, 60);
            retryBtn.TabIndex = 101;
            retryBtn.Visible = false;
            retryBtn.Click += Retry;
            // 
            // pbarGoal
            // 
            pbarGoal.BackColor = Color.FromArgb(0, 0, 0);
            pbarGoal.CausesValidation = false;
            pbarGoal.ForeColor = Color.Lime;
            pbarGoal.Location = new Point(26, 154);
            pbarGoal.Margin = new Padding(3, 2, 3, 2);
            pbarGoal.Name = "pbarGoal";
            pbarGoal.PBackgroundColor = Color.FromArgb(0, 0, 0);
            pbarGoal.PForegroundColor = Color.FromArgb(118, 186, 0);
            pbarGoal.Size = new Size(100, 40);
            pbarGoal.TabIndex = 100;
            pbarGoal.TabStop = false;
            pbarGoal.Value = 0;
            // 
            // homeBtn
            // 
            homeBtn.BackColor = Color.Transparent;
            homeBtn.BackgroundImage = Properties.Resources.button_home;
            homeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            homeBtn.Font = new Font("Kleptocracy Titling Rg", 15F, FontStyle.Bold, GraphicsUnit.Point);
            homeBtn.ForeColor = Color.Black;
            homeBtn.Location = new Point(48, 691);
            homeBtn.Margin = new Padding(4, 3, 4, 3);
            homeBtn.Name = "homeBtn";
            homeBtn.PressedBackgroundImage = Properties.Resources.button_home_pressed;
            homeBtn.Size = new Size(60, 60);
            homeBtn.TabIndex = 11;
            homeBtn.Click += ShowHome;
            // 
            // nextBrickBox
            // 
            nextBrickBox.BackColor = Color.FromArgb(81, 40, 19);
            nextBrickBox.Location = new Point(25, 376);
            nextBrickBox.Name = "nextBrickBox";
            nextBrickBox.Size = new Size(100, 100);
            nextBrickBox.TabIndex = 10;
            nextBrickBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kleptocracy Titling Rg", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 226, 107);
            label1.Location = new Point(36, 331);
            label1.Name = "label1";
            label1.Size = new Size(80, 42);
            label1.TabIndex = 7;
            label1.Text = "NEXT";
            // 
            // score
            // 
            score.BackColor = Color.Transparent;
            score.Font = new Font("Kleptocracy Titling Rg", 22F, FontStyle.Bold, GraphicsUnit.Point);
            score.ForeColor = Color.White;
            score.Image = Properties.Resources.score_back;
            score.Location = new Point(18, 261);
            score.Name = "score";
            score.Size = new Size(114, 48);
            score.TabIndex = 6;
            score.Text = "0";
            score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scoreTitle
            // 
            scoreTitle.AutoSize = true;
            scoreTitle.Font = new Font("Kleptocracy Titling Rg", 26F, FontStyle.Bold, GraphicsUnit.Point);
            scoreTitle.ForeColor = Color.FromArgb(255, 226, 107);
            scoreTitle.Location = new Point(26, 219);
            scoreTitle.Name = "scoreTitle";
            scoreTitle.Size = new Size(98, 42);
            scoreTitle.TabIndex = 5;
            scoreTitle.Text = "SCORE";
            // 
            // goalTitle
            // 
            goalTitle.AutoSize = true;
            goalTitle.Font = new Font("Kleptocracy Titling Rg", 26F, FontStyle.Bold, GraphicsUnit.Point);
            goalTitle.ForeColor = Color.FromArgb(255, 226, 107);
            goalTitle.Location = new Point(36, 110);
            goalTitle.Name = "goalTitle";
            goalTitle.Size = new Size(78, 42);
            goalTitle.TabIndex = 2;
            goalTitle.Text = "GOAL";
            // 
            // level
            // 
            level.BackColor = Color.Black;
            level.Font = new Font("Kleptocracy Titling Rg", 22F, FontStyle.Bold, GraphicsUnit.Point);
            level.ForeColor = Color.White;
            level.Location = new Point(25, 51);
            level.Name = "level";
            level.Size = new Size(100, 40);
            level.TabIndex = 1;
            level.Text = "1";
            level.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // levelTitle
            // 
            levelTitle.AutoSize = true;
            levelTitle.Font = new Font("Kleptocracy Titling Rg", 26F, FontStyle.Bold, GraphicsUnit.Point);
            levelTitle.ForeColor = Color.FromArgb(255, 226, 107);
            levelTitle.Location = new Point(32, 9);
            levelTitle.Name = "levelTitle";
            levelTitle.Size = new Size(90, 42);
            levelTitle.TabIndex = 0;
            levelTitle.Text = "LEVEL";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += UpdateGame;
            // 
            // leftBox
            // 
            leftBox.BackColor = Color.IndianRed;
            leftBox.Controls.Add(map);
            leftBox.Location = new Point(0, 0);
            leftBox.Name = "leftBox";
            leftBox.Size = new Size(418, 838);
            leftBox.TabIndex = 3;
            // 
            // GameView
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(leftBox);
            Controls.Add(rightBox);
            Font = new Font("Kleptocracy Titling Rg", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(0);
            Name = "GameView";
            Size = new Size(568, 838);
            ((System.ComponentModel.ISupportInitialize)map).EndInit();
            rightBox.ResumeLayout(false);
            rightBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nextBrickBox).EndInit();
            leftBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox map;
        private Panel rightBox;
        private PictureBox nextBrickBox;
        private Label label1;
        private Label score;
        private Label scoreTitle;
        private Label goalTitle;
        private Label level;
        private Label levelTitle;
        private System.Windows.Forms.Timer timer;
        private SuperButton homeBtn;
        private Panel leftBox;
        private GameProgressBar pbarGoal;
        private SuperButton retryBtn;
    }
}
