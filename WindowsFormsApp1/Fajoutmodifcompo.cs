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
    public partial class Fajoutmodifcompo : Form
    {
        public Fajoutmodifcompo()
        {
            InitializeComponent();
        }
        private void ajoutmodif_Load(object sender, EventArgs e)
        {
            //bsnation.ValueMember = "idNation";//permet de stocker l'identifiant
            cbonation.DisplayMember = "libNation";
            bsnation.DataSource = Modele.listnationalite();
            cbonation.DataSource = bsnation;
            cbostyle.DisplayMember = "libStyle";
            bsstyle.DataSource = Modele.liststyle();
            cbostyle.DataSource = bsstyle;
            if(Modele.Action1 == 1)
            {

            }
            if(Modele.Action1 == 2)
            {
                txtnom.Text = Modele.Compochoisi.nomCompositeur.ToString();
                txtprenom.Text = Modele.Compochoisi.prenomCompositeur.ToString();
                txtremarque.Text = Modele.Compochoisi.remarque.ToString();
                txtnaiss.Text = Modele.Compochoisi.anNais.ToString();
                txtmort.Text = Modele.Compochoisi.anMort.ToString();
                bsnation.DataSource = Modele.Compochoisi.NATIONALITE.libNation;
                cbonation.DataSource = bsnation;
                bsstyle.DataSource = Modele.Compochoisi.STYLE.libStyle;
                cbostyle.DataSource = bsstyle;
            }

        }
        private void bsNation_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bsstyle_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
