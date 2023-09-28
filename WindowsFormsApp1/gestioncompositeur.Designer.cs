namespace WindowsFormsApp1
{
    partial class ajoutcompositeur
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
            this.cbonation = new System.Windows.Forms.ComboBox();
            this.dgvcompositeur = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.modif = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bsnation = new System.Windows.Forms.BindingSource(this.components);
            this.bscompositeur = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompositeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsnation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscompositeur)).BeginInit();
            this.SuspendLayout();
            // 
            // cbonation
            // 
            this.cbonation.FormattingEnabled = true;
            this.cbonation.Location = new System.Drawing.Point(131, 25);
            this.cbonation.Name = "cbonation";
            this.cbonation.Size = new System.Drawing.Size(170, 21);
            this.cbonation.TabIndex = 0;
            // 
            // dgvcompositeur
            // 
            this.dgvcompositeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcompositeur.Location = new System.Drawing.Point(44, 66);
            this.dgvcompositeur.Name = "dgvcompositeur";
            this.dgvcompositeur.Size = new System.Drawing.Size(767, 388);
            this.dgvcompositeur.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(219, 494);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            // 
            // modif
            // 
            this.modif.Location = new System.Drawing.Point(438, 493);
            this.modif.Name = "modif";
            this.modif.Size = new System.Drawing.Size(75, 23);
            this.modif.TabIndex = 3;
            this.modif.Text = "alter";
            this.modif.UseVisualStyleBackColor = true;
            this.modif.Click += new System.EventHandler(this.modif_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(28, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 13);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Nationnalité :";
            // 
            // bsnation
            // 
            this.bsnation.CurrentChanged += new System.EventHandler(this.bsNation_CurrentChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ajoutcompositeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.modif);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dgvcompositeur);
            this.Controls.Add(this.cbonation);
            this.Name = "ajoutcompositeur";
            this.Text = "gestioncompositeur";
            this.Load += new System.EventHandler(this.gestioncompo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompositeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsnation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscompositeur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbonation;
        private System.Windows.Forms.DataGridView dgvcompositeur;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button modif;
        private System.Windows.Forms.BindingSource bsnation;
        private System.Windows.Forms.BindingSource bscompositeur;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}