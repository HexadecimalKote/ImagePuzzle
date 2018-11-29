namespace ImagePuzzle
{
    partial class FormPuzzleGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPuzzleGame));
            this.Menu_PuzzleGame = new System.Windows.Forms.MenuStrip();
            this.Menu_StartGame = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Level = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Level_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Level_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Level_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Level_6 = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.PB_ImagePart = new System.Windows.Forms.PictureBox();
            this.Menu_PuzzleGame.SuspendLayout();
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ImagePart)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_PuzzleGame
            // 
            this.Menu_PuzzleGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_StartGame,
            this.Menu_Level});
            this.Menu_PuzzleGame.Location = new System.Drawing.Point(0, 0);
            this.Menu_PuzzleGame.Name = "Menu_PuzzleGame";
            this.Menu_PuzzleGame.Size = new System.Drawing.Size(792, 24);
            this.Menu_PuzzleGame.TabIndex = 0;
            this.Menu_PuzzleGame.Text = "menuStrip1";
            // 
            // Menu_StartGame
            // 
            this.Menu_StartGame.Image = ((System.Drawing.Image)(resources.GetObject("Menu_StartGame.Image")));
            this.Menu_StartGame.Name = "Menu_StartGame";
            this.Menu_StartGame.Size = new System.Drawing.Size(102, 20);
            this.Menu_StartGame.Text = "Начать игру";
            this.Menu_StartGame.Click += new System.EventHandler(this.Menu_StartGame_Click);
            // 
            // Menu_Level
            // 
            this.Menu_Level.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Level_3,
            this.Menu_Level_4,
            this.Menu_Level_5,
            this.Menu_Level_6});
            this.Menu_Level.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Level.Image")));
            this.Menu_Level.Name = "Menu_Level";
            this.Menu_Level.Size = new System.Drawing.Size(81, 20);
            this.Menu_Level.Text = "Уровень";
            // 
            // Menu_Level_3
            // 
            this.Menu_Level_3.Name = "Menu_Level_3";
            this.Menu_Level_3.Size = new System.Drawing.Size(97, 22);
            this.Menu_Level_3.Text = "3 х 3";
            this.Menu_Level_3.Click += new System.EventHandler(this.Menu_Level_3_Click);
            // 
            // Menu_Level_4
            // 
            this.Menu_Level_4.Name = "Menu_Level_4";
            this.Menu_Level_4.Size = new System.Drawing.Size(97, 22);
            this.Menu_Level_4.Text = "4 х 4";
            this.Menu_Level_4.Click += new System.EventHandler(this.Menu_Level_4_Click);
            // 
            // Menu_Level_5
            // 
            this.Menu_Level_5.Name = "Menu_Level_5";
            this.Menu_Level_5.Size = new System.Drawing.Size(97, 22);
            this.Menu_Level_5.Text = "5 х 5";
            this.Menu_Level_5.Click += new System.EventHandler(this.Menu_Level_5_Click);
            // 
            // Menu_Level_6
            // 
            this.Menu_Level_6.Name = "Menu_Level_6";
            this.Menu_Level_6.Size = new System.Drawing.Size(97, 22);
            this.Menu_Level_6.Text = "6 х 6";
            this.Menu_Level_6.Click += new System.EventHandler(this.Menu_Level_6_Click);
            // 
            // ImagePanel
            // 
            this.ImagePanel.Controls.Add(this.PB_ImagePart);
            this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePanel.Location = new System.Drawing.Point(0, 24);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(792, 423);
            this.ImagePanel.TabIndex = 1;
            // 
            // PB_ImagePart
            // 
            this.PB_ImagePart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_ImagePart.Location = new System.Drawing.Point(55, 105);
            this.PB_ImagePart.Name = "PB_ImagePart";
            this.PB_ImagePart.Size = new System.Drawing.Size(73, 65);
            this.PB_ImagePart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_ImagePart.TabIndex = 0;
            this.PB_ImagePart.TabStop = false;
            this.PB_ImagePart.Click += new System.EventHandler(this.PB_ImagePart_Click);
            // 
            // FormPuzzleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 447);
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.Menu_PuzzleGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu_PuzzleGame;
            this.MaximizeBox = false;
            this.Name = "FormPuzzleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle Game";
            this.Load += new System.EventHandler(this.FormPuzzleGame_Load);
            this.Menu_PuzzleGame.ResumeLayout(false);
            this.Menu_PuzzleGame.PerformLayout();
            this.ImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_ImagePart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_PuzzleGame;
        private System.Windows.Forms.ToolStripMenuItem Menu_StartGame;
        private System.Windows.Forms.ToolStripMenuItem Menu_Level;
        private System.Windows.Forms.ToolStripMenuItem Menu_Level_3;
        private System.Windows.Forms.ToolStripMenuItem Menu_Level_4;
        private System.Windows.Forms.ToolStripMenuItem Menu_Level_5;
        private System.Windows.Forms.ToolStripMenuItem Menu_Level_6;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.PictureBox PB_ImagePart;
    }
}

