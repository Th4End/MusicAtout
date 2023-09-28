namespace WindowsFormsApp1
{
    partial class Fgestion
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
            this.txtdebut = new System.Windows.Forms.TextBox();
            this.txtfin = new System.Windows.Forms.TextBox();
            this.dgvCompositeur = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bsstyle = new System.Windows.Forms.BindingSource(this.components);
            this.bscompo = new System.Windows.Forms.BindingSource(this.components);
            this.bsoeuvre = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompositeur)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsstyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscompo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoeuvre)).BeginInit();
            this.SuspendLayout();
            // 
            // cbostyle
            // 
            this.cbostyle.Location = new System.Drawing.Point(12, 80);
            this.cbostyle.Name = "cbostyle";
            this.cbostyle.Size = new System.Drawing.Size(179, 21);
            this.cbostyle.TabIndex = 0;
            // 
            // txtdebut
            // 
            this.txtdebut.Location = new System.Drawing.Point(12, 134);
            this.txtdebut.Name = "txtdebut";
            this.txtdebut.Size = new System.Drawing.Size(50, 20);
            this.txtdebut.TabIndex = 1;
            // 
            // txtfin
            // 
            this.txtfin.Location = new System.Drawing.Point(131, 134);
            this.txtfin.Name = "txtfin";
            this.txtfin.Size = new System.Drawing.Size(45, 20);
            this.txtfin.TabIndex = 2;
            // 
            // dgvCompositeur
            // 
            this.dgvCompositeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompositeur.Location = new System.Drawing.Point(3, 185);
            this.dgvCompositeur.Name = "dgvCompositeur";
            this.dgvCompositeur.Size = new System.Drawing.Size(254, 226);
            this.dgvCompositeur.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Location = new System.Drawing.Point(248, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 406);
            this.panel1.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(38, 157);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(441, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(38, 259);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(441, 140);
            this.dataGridView2.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(319, 131);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(57, 20);
            this.textBox7.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(196, 131);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(66, 20);
            this.textBox6.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(368, 94);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(103, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(182, 23);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(235, 20);
            this.textBox3.TabIndex = 0;
            // 
            // bsstyle
            // 
            this.bsstyle.CurrentChanged += new System.EventHandler(this.bsstyle_CurrentChanged);
            // 
            // bscompo
            // 
            this.bscompo.CurrentChanged += new System.EventHandler(this.bscompo_CurrentChanged);
            // 
            // Fgestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCompositeur);
            this.Controls.Add(this.txtfin);
            this.Controls.Add(this.txtdebut);
            this.Controls.Add(this.cbostyle);
            this.Name = "Fgestion";
            this.Text = "Fgestion";
            this.Load += new System.EventHandler(this.Fgestion_load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompositeur)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsstyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscompo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoeuvre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbostyle;
        private System.Windows.Forms.TextBox txtdebut;
        private System.Windows.Forms.TextBox txtfin;
        private System.Windows.Forms.DataGridView dgvCompositeur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource bsstyle;
        private System.Windows.Forms.BindingSource bscompo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.BindingSource bsoeuvre;
    }
}