namespace Tetris
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            content = new Panel();
            SuspendLayout();
            // 
            // content
            // 
            content.Location = new Point(12, 12);
            content.Name = "content";
            content.Size = new Size(568, 838);
            content.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(235, 107, 0);
            ClientSize = new Size(592, 862);
            Controls.Add(content);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "俄罗斯方块";
            Load += OnLoad;
            ResumeLayout(false);
        }

        #endregion

        private Panel content;
    }
}