namespace WindowsFormsApp1
{
    partial class FStyle
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
            this.cbostyle = new System.Windows.Forms.ComboBox();
            this.dgvCompositeur = new System.Windows.Forms.DataGridView();
            this.bsstyle = new System.Windows.Forms.BindingSource(this.components);
            this.txtdebut = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtfin = new System.Windows.Forms.TextBox();
            this.bscompositeur = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompositeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsstyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscompositeur)).BeginInit();
            this.SuspendLayout();
            // 
            // cbostyle
            // 
            this.cbostyle.FormattingEnabled = true;
            this.cbostyle.Location = new System.Drawing.Point(186, 17);
            this.cbostyle.Name = "cbostyle";
            this.cbostyle.Size = new System.Drawing.Size(178, 21);
            this.cbostyle.TabIndex = 0;
            // 
            // dgvCompositeur
            // 
            this.dgvCompositeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompositeur.Location = new System.Drawing.Point(28, 84);
            this.dgvCompositeur.Name = "dgvCompositeur";
            this.dgvCompositeur.Size = new System.Drawing.Size(743, 354);
            this.dgvCompositeur.TabIndex = 1;
            // 
            // bsstyle
            // 
            this.bsstyle.CurrentChanged += new System.EventHandler(this.bsstyle_CurrentChanged);
            // 
            // txtdebut
            // 
            this.txtdebut.Location = new System.Drawing.Point(476, 17);
            this.txtdebut.Name = "txtdebut";
            this.txtdebut.Size = new System.Drawing.Size(100, 20);
            this.txtdebut.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.Color.Wheat;
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt2.Location = new System.Drawing.Point(370, 21);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 13);
            this.txt2.TabIndex = 3;
            this.txt2.Text = "début du style";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Wheat;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(-2, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 13);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Selectionner un style ou une époque";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Wheat;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(582, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Fin du style";
            // 
            // txtfin
            // 
            this.txtfin.Location = new System.Drawing.Point(688, 14);
            this.txtfin.Name = "txtfin";
            this.txtfin.Size = new System.Drawing.Size(100, 20);
            this.txtfin.TabIndex = 6;
            // 
            // FStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtfin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txtdebut);
            this.Controls.Add(this.dgvCompositeur);
            this.Controls.Add(this.cbostyle);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "FStyle";
            this.Text = "FStyle";
            this.Load += new System.EventHandler(this.Fstyle_load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompositeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsstyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscompositeur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbostyle;
        private System.Windows.Forms.DataGridView dgvCompositeur;
        private System.Windows.Forms.BindingSource bsstyle;
        private System.Windows.Forms.TextBox txtdebut;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtfin;
        private System.Windows.Forms.BindingSource bscompositeur;
    }
}