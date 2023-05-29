namespace Tetris
{
    partial class HomeView
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
            ((System.ComponentModel.ISupportInitialize)map).BeginInit();
            SuspendLayout();
            // 
            // map
            // 
            map.BackColor = Color.Black;
            map.Location = new Point(0, 0);
            map.Name = "map";
            map.Size = new Size(430, 502);
            map.TabIndex = 0;
            map.TabStop = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 500;
            timer.Tick += UpdateGame;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 502);
            Controls.Add(map);
            Name = "HomeView";
            Text = "俄罗斯方块";
            Load += StartGame;
            KeyDown += OnKeyDown;
            ((System.ComponentModel.ISupportInitialize)map).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox map;
        private System.Windows.Forms.Timer timer;
    }
}