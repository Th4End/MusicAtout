namespace WindowsFormsApp1
{
    partial class FSalle
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
            this.viewsalle = new System.Windows.Forms.DataGridView();
            this.bgsalle = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.viewsalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgsalle)).BeginInit();
            this.SuspendLayout();
            // 
            // viewsalle
            // 
            this.viewsalle.AllowUserToAddRows = false;
            this.viewsalle.AllowUserToDeleteRows = false;
            this.viewsalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewsalle.Location = new System.Drawing.Point(246, 87);
            this.viewsalle.Name = "viewsalle";
            this.viewsalle.ReadOnly = true;
            this.viewsalle.Size = new System.Drawing.Size(228, 205);
            this.viewsalle.TabIndex = 0;
            // 
            // FSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewsalle);
            this.Name = "FSalle";
            this.Text = "FSalle";
            this.Load += new System.EventHandler(this.FSalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewsalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgsalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewsalle;
        private System.Windows.Forms.BindingSource bgsalle;
    }
}