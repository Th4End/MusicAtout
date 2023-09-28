namespace WindowsFormsApp1
{
    partial class FVille
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvVille = new System.Windows.Forms.DataGridView();
            this.bsVille = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVille)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVille
            // 
            this.dgvVille.AllowUserToAddRows = false;
            this.dgvVille.AllowUserToDeleteRows = false;
            this.dgvVille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVille.Location = new System.Drawing.Point(237, 79);
            this.dgvVille.Name = "dgvVille";
            this.dgvVille.ReadOnly = true;
            this.dgvVille.Size = new System.Drawing.Size(255, 222);
            this.dgvVille.TabIndex = 0;
            // 
            // FVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVille);
            this.Name = "FVille";
            this.Text = "FVille";
            this.Load += new System.EventHandler(this.FVille_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVille)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsVille;
        private System.Windows.Forms.DataGridView dgvVille;
    }
}

