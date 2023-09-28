using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FStyle : Form
    {
        public FStyle()
        {
            InitializeComponent();
        }
        private void Fstyle_load(object sender, EventArgs e)
        {
            cbostyle.DisplayMember = "libStyle";
            bsstyle.DataSource = Modele.liststyle();
            cbostyle.DataSource = bsstyle;
        }

        private void bsstyle_CurrentChanged(object sender, EventArgs e)
        {
            STYLE style =  (STYLE) bsstyle.Current;
            txtdebut.Text = style.dateDebut.ToString();
            txtfin.Text = style.dateFin.ToString();
            //COMPOSITEUR cOMPOSITEUR = (COMPOSITEUR)bscompositeur.Current;
            dgvCompositeur.DataSource = style.COMPOSITEUR.ToList();
            dgvCompositeur.Columns[0].Visible = false;
            dgvCompositeur.Columns[1].Visible = false;
            dgvCompositeur.Columns[2].Visible = false;
            dgvCompositeur.Columns[3].Visible = true;
            dgvCompositeur.Columns[4].Visible = true;
            dgvCompositeur.Columns[5].Visible = true;
            dgvCompositeur.Columns[6].Visible = true;
            dgvCompositeur.Columns[7].Visible = true;
            dgvCompositeur.Columns[8].Visible = false;
            dgvCompositeur.Columns[9].Visible = false;
            dgvCompositeur.Columns[10].Visible = false;

        }
    }
}
