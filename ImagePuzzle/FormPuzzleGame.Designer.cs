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
            this.Menu_PuzzleGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_PuzzleGame
            // 
            this.Menu_PuzzleGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_StartGame,
            this.Menu_Level});
            this.Menu_PuzzleGame.Location = new System.Drawing.Point(0, 0);
            this.Menu_PuzzleGame.Name = "Menu_PuzzleGame";
            this.Menu_PuzzleGame.Size = new System.Drawing.Size(747, 24);
            this.Menu_PuzzleGame.TabIndex = 0;
            this.Menu_PuzzleGame.Text = "menuStrip1";
            // 
            // Menu_StartGame
            // 
            this.Menu_StartGame.Image = ((System.Drawing.Image)(resources.GetObject("Menu_StartGame.Image")));
            this.Menu_StartGame.Name = "Menu_StartGame";
            this.Menu_StartGame.Size = new System.Drawing.Size(102, 20);
            this.Menu_StartGame.Text = "Начать игру";
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
            this.Menu_Level_3.Size = new System.Drawing.Size(180, 22);
            this.Menu_Level_3.Text = "3 х 3";
            // 
            // Menu_Level_4
            // 
            this.Menu_Level_4.Name = "Menu_Level_4";
            this.Menu_Level_4.Size = new System.Drawing.Size(180, 22);
            this.Menu_Level_4.Text = "4 х 4";
            // 
            // Menu_Level_5
            // 
            this.Menu_Level_5.Name = "Menu_Level_5";
            this.Menu_Level_5.Size = new System.Drawing.Size(180, 22);
            this.Menu_Level_5.Text = "5 х 5";
            // 
            // Menu_Level_6
            // 
            this.Menu_Level_6.Name = "Menu_Level_6";
            this.Menu_Level_6.Size = new System.Drawing.Size(180, 22);
            this.Menu_Level_6.Text = "6 х 6";
            // 
            // FormPuzzleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 438);
            this.Controls.Add(this.Menu_PuzzleGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu_PuzzleGame;
            this.Name = "FormPuzzleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle Game";
            this.Menu_PuzzleGame.ResumeLayout(false);
            this.Menu_PuzzleGame.PerformLayout();
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
    }
}

