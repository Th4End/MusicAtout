namespace WindowsFormsApp1
{
    partial class FMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.villeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bâtimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesOeuvresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compositeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeToolStripMenuItem,
            this.compositeurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.villeToolStripMenuItem,
            this.sallesToolStripMenuItem,
            this.bâtimentToolStripMenuItem,
            this.typesOeuvresToolStripMenuItem});
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.listeToolStripMenuItem.Text = "Liste";
            // 
            // villeToolStripMenuItem
            // 
            this.villeToolStripMenuItem.Name = "villeToolStripMenuItem";
            this.villeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.villeToolStripMenuItem.Text = "Ville";
            this.villeToolStripMenuItem.Click += new System.EventHandler(this.fenetreFville_Click);
            // 
            // sallesToolStripMenuItem
            // 
            this.sallesToolStripMenuItem.Name = "sallesToolStripMenuItem";
            this.sallesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.sallesToolStripMenuItem.Text = "Salles";
            this.sallesToolStripMenuItem.Click += new System.EventHandler(this.sallesToolStripMenuItem_Click);
            // 
            // bâtimentToolStripMenuItem
            // 
            this.bâtimentToolStripMenuItem.Name = "bâtimentToolStripMenuItem";
            this.bâtimentToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.bâtimentToolStripMenuItem.Text = "Bâtiment";
            // 
            // typesOeuvresToolStripMenuItem
            // 
            this.typesOeuvresToolStripMenuItem.Name = "typesOeuvresToolStripMenuItem";
            this.typesOeuvresToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.typesOeuvresToolStripMenuItem.Text = "Types oeuvres";
            // 
            // compositeurToolStripMenuItem
            // 
            this.compositeurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nToolStripMenuItem,
            this.styleToolStripMenuItem,
            this.modifToolStripMenuItem,
            this.gestionToolStripMenuItem});
            this.compositeurToolStripMenuItem.Name = "compositeurToolStripMenuItem";
            this.compositeurToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.compositeurToolStripMenuItem.Text = "Compositeur";
            // 
            // nToolStripMenuItem
            // 
            this.nToolStripMenuItem.Name = "nToolStripMenuItem";
            this.nToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.nToolStripMenuItem.Text = "Artiste";
            this.nToolStripMenuItem.Click += new System.EventHandler(this.nToolStripMenuItem_Click);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.styleToolStripMenuItem.Text = "Style";
            this.styleToolStripMenuItem.Click += new System.EventHandler(this.styleToolStripMenuItem_Click);
            // 
            // modifToolStripMenuItem
            // 
            this.modifToolStripMenuItem.Name = "modifToolStripMenuItem";
            this.modifToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.modifToolStripMenuItem.Text = "Gestion Compositeur";
            this.modifToolStripMenuItem.Click += new System.EventHandler(this.gestionToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.gestionToolStripMenuItem.Text = "Gestion";
            this.gestionToolStripMenuItem.Click += new System.EventHandler(this.gestionToolStripMenuItem_Click_1);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FMenu";
            this.Text = "FMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem villeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bâtimentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesOeuvresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compositeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
    }
}