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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }
        private void FMenu_Load(object sender, EventArgs e)
        {
             
            
        }

        private void fenetreFville_Click(object sender, EventArgs e)
        {
            FVille fenetreFVille = new FVille();
            fenetreFVille.Show();
        }

        private void sallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSalle fenetreSalle = new FSalle();
            fenetreSalle.Show();
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fcompositeur fcompositeur = new Fcompositeur();
            fcompositeur.Show();
        }

        private void styleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FStyle fStyle = new FStyle();
            fStyle.Show();
        }
        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fgestion fgestion = new Fgestion();
            fgestion.Show();
        }

        private void gestionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ajoutcompositeur gestcompo = new ajoutcompositeur();
            gestcompo.Show();
        }
    }
}
