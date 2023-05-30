namespace Tetris
{
    partial class GameView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            map = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            rightBox = new Panel();
            homeBtn = new Button();
            label1 = new Label();
            score = new Label();
            scoreTitle = new Label();
            goalProgress = new Label();
            goalProgressBar = new Label();
            goalTitle = new Label();
            level = new Label();
            levelTitle = new Label();
            nextBrickBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)map).BeginInit();
            rightBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nextBrickBox).BeginInit();
            SuspendLayout();
            // 
            // map
            // 
            map.BackColor = Color.Black;
            map.Location = new Point(12, 12);
            map.Margin = new Padding(3, 2, 3, 2);
            map.Name = "map";
            map.Size = new Size(418, 838);
            map.TabIndex = 0;
            map.TabStop = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 500;
            timer.Tick += UpdateGame;
            // 
            // rightBox
            // 
            rightBox.BackColor = Color.FromArgb(38, 12, 2);
            rightBox.Controls.Add(nextBrickBox);
            rightBox.Controls.Add(homeBtn);
            rightBox.Controls.Add(label1);
            rightBox.Controls.Add(score);
            rightBox.Controls.Add(scoreTitle);
            rightBox.Controls.Add(goalProgress);
            rightBox.Controls.Add(goalProgressBar);
            rightBox.Controls.Add(goalTitle);
            rightBox.Controls.Add(level);
            rightBox.Controls.Add(levelTitle);
            rightBox.Font = new Font("Kleptocracy Titling Rg", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rightBox.Location = new Point(430, 12);
            rightBox.Margin = new Padding(3, 2, 3, 2);
            rightBox.Name = "rightBox";
            rightBox.Size = new Size(150, 838);
            rightBox.TabIndex = 1;
            // 
            // homeBtn
            // 
            homeBtn.BackColor = Color.Transparent;
            homeBtn.BackgroundImage = Properties.Resources.button_home;
            homeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            homeBtn.Enabled = false;
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            homeBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Location = new Point(45, 761);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(60, 60);
            homeBtn.TabIndex = 9;
            homeBtn.UseVisualStyleBackColor = false;
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
            // goalProgress
            // 
            goalProgress.BackColor = Color.FromArgb(118, 186, 0);
            goalProgress.Font = new Font("Kleptocracy Titling Rg", 22F, FontStyle.Bold, GraphicsUnit.Point);
            goalProgress.ForeColor = Color.White;
            goalProgress.Location = new Point(25, 152);
            goalProgress.Name = "goalProgress";
            goalProgress.Size = new Size(48, 40);
            goalProgress.TabIndex = 4;
            goalProgress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // goalProgressBar
            // 
            goalProgressBar.BackColor = Color.Black;
            goalProgressBar.Font = new Font("Kleptocracy Titling Rg", 22F, FontStyle.Bold, GraphicsUnit.Point);
            goalProgressBar.ForeColor = Color.White;
            goalProgressBar.Location = new Point(25, 152);
            goalProgressBar.Name = "goalProgressBar";
            goalProgressBar.Size = new Size(100, 40);
            goalProgressBar.TabIndex = 3;
            goalProgressBar.TextAlign = ContentAlignment.MiddleCenter;
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
            // nextBrickBox
            // 
            nextBrickBox.BackColor = Color.FromArgb(81, 40, 19);
            nextBrickBox.Location = new Point(25, 376);
            nextBrickBox.Name = "nextBrickBox";
            nextBrickBox.Size = new Size(100, 100);
            nextBrickBox.TabIndex = 10;
            nextBrickBox.TabStop = false;
            // 
            // GameView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 107, 0);
            ClientSize = new Size(592, 862);
            Controls.Add(rightBox);
            Controls.Add(map);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GameView";
            Text = "俄罗斯方块";
            Load += StartGame;
            KeyDown += OnKeyDown;
            ((System.ComponentModel.ISupportInitialize)map).EndInit();
            rightBox.ResumeLayout(false);
            rightBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nextBrickBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox map;
        private System.Windows.Forms.Timer timer;
        private Panel rightBox;
        private Label levelTitle;
        private Label level;
        private Label goalProgressBar;
        private Label goalTitle;
        private Label goalProgress;
        private Label score;
        private Label scoreTitle;
        private Label label1;
        private Button homeBtn;
        private PictureBox nextBrickBox;
    }
}