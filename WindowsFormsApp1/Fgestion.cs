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
    public partial class Fgestion : Form
    {
        public Fgestion()
        {
            InitializeComponent();
        }
        private void Fgestion_load(object sender, EventArgs e)
        {
            cbostyle.DisplayMember = "libStyle";
            bsstyle.DataSource = Modele.liststyle();
            cbostyle.DataSource = bsstyle;
        }

        private void bsstyle_CurrentChanged(object sender, EventArgs e)
        {
            STYLE style = (STYLE)bsstyle.Current;
            bscompo.DataSource = style.COMPOSITEUR.ToList();
            txtdebut.Text = style.dateDebut.ToString();
            txtfin.Text = style.dateFin.ToString();
            //COMPOSITEUR cOMPOSITEUR = (COMPOSITEUR)bscompositeur.Current;
            dgvCompositeur.DataSource = bscompo;
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

        private void bscompo_CurrentChanged(object sender, EventArgs e)
        {
            COMPOSITEUR compo = (COMPOSITEUR)bscompo.Current;
            textBox3.Text = compo.prenomCompositeur.ToString().Trim() + " " + compo.nomCompositeur.ToString();
            textBox4.Text = compo.NATIONALITE.libNation.ToString();
            textBox5.Text = compo.STYLE.libStyle.ToString();
            textBox6.Text = compo.anNais.ToString();
            textBox7.Text = compo.anMort.ToString();
            richTextBox1.Text = compo.remarque.ToString();
            bsoeuvre.DataSource= compo.OEUVRE.ToList();
            dataGridView2.DataSource = bsoeuvre;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[6].Visible = false;
            dataGridView2.Columns[7].Visible = false;

        }
    }
}
