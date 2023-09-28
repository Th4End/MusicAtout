namespace WindowsFormsApp1
{
    partial class Fcompositeur
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fcompositeur));
            this.cbonation = new System.Windows.Forms.ComboBox();
            this.dgvcompositeur = new System.Windows.Forms.DataGridView();
            this.bscompositeur = new System.Windows.Forms.BindingSource(this.components);
            this.bsnation = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompositeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscompositeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsnation)).BeginInit();
            this.SuspendLayout();
            // 
            // cbonation
            // 
            this.cbonation.FormattingEnabled = true;
            this.cbonation.Location = new System.Drawing.Point(2, 12);
            this.cbonation.Name = "cbonation";
            this.cbonation.Size = new System.Drawing.Size(109, 21);
            this.cbonation.TabIndex = 0;
            // 
            // dgvcompositeur
            // 
            this.dgvcompositeur.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvcompositeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcompositeur.Location = new System.Drawing.Point(34, 113);
            this.dgvcompositeur.Name = "dgvcompositeur";
            this.dgvcompositeur.Size = new System.Drawing.Size(729, 253);
            this.dgvcompositeur.TabIndex = 1;
            // 
            // bsnation
            // 
            this.bsnation.CurrentChanged += new System.EventHandler(this.bsNation_CurrentChanged);
            // 
            // Fcompositeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvcompositeur);
            this.Controls.Add(this.cbonation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fcompositeur";
            this.Text = "Fcompositeur";
            this.Load += new System.EventHandler(this.FCompositeurNation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompositeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscompositeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsnation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbonation;
        private System.Windows.Forms.DataGridView dgvcompositeur;
        private System.Windows.Forms.BindingSource bscompositeur;
        private System.Windows.Forms.BindingSource bsnation;
    }
}