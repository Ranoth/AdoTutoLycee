namespace AdoTutoLycee
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adhérentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem,
            this.basesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // basesToolStripMenuItem
            // 
            this.basesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auteursToolStripMenuItem,
            this.genresToolStripMenuItem,
            this.adhérentsToolStripMenuItem,
            this.livresToolStripMenuItem});
            this.basesToolStripMenuItem.Name = "basesToolStripMenuItem";
            this.basesToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.basesToolStripMenuItem.Text = "Bases";
            // 
            // auteursToolStripMenuItem
            // 
            this.auteursToolStripMenuItem.Name = "auteursToolStripMenuItem";
            this.auteursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.auteursToolStripMenuItem.Text = "Auteurs";
            this.auteursToolStripMenuItem.Click += new System.EventHandler(this.auteursToolStripMenuItem_Click);
            // 
            // genresToolStripMenuItem
            // 
            this.genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            this.genresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.genresToolStripMenuItem.Text = "Genres";
            this.genresToolStripMenuItem.Click += new System.EventHandler(this.genresToolStripMenuItem_Click);
            // 
            // adhérentsToolStripMenuItem
            // 
            this.adhérentsToolStripMenuItem.Name = "adhérentsToolStripMenuItem";
            this.adhérentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adhérentsToolStripMenuItem.Text = "Adhérents";
            this.adhérentsToolStripMenuItem.Click += new System.EventHandler(this.adhérentsToolStripMenuItem_Click);
            // 
            // livresToolStripMenuItem
            // 
            this.livresToolStripMenuItem.Name = "livresToolStripMenuItem";
            this.livresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.livresToolStripMenuItem.Text = "Livres";
            this.livresToolStripMenuItem.Click += new System.EventHandler(this.livresToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adhérentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livresToolStripMenuItem;
    }
}