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
    public partial class ajoutcompositeur : Form
    {
        public ajoutcompositeur()
        {
            InitializeComponent();
        }
        private void gestioncompo_Load(object sender, EventArgs e)
        {
            //bsnation.ValueMember = "idNation";//permet de stocker l'identifiant
            cbonation.DisplayMember = "libNation";
            bsnation.DataSource = Modele.listnationalite();
            cbonation.DataSource = bsnation;

        }
        private void bsNation_CurrentChanged(object sender, EventArgs e)
        {
            bscompositeur.DataSource = ((NATIONALITE)bsnation.Current).COMPOSITEUR.Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.STYLE.libStyle, x.anNais, x.anMort, x.remarque, x.idCompositeur })
                                       .OrderBy(x => x.nomCompositeur);
            dgvcompositeur.DataSource = bscompositeur;
            dgvcompositeur.Columns[0].HeaderText = "NOM";
            dgvcompositeur.Columns[1].HeaderText = "PRENOM";
            dgvcompositeur.Columns[2].HeaderText = "STYLE";
            dgvcompositeur.Columns[3].HeaderText = "Né le";
            dgvcompositeur.Columns[4].HeaderText = "Mort le";
            dgvcompositeur.Columns[5].HeaderText = "Informations";
            dgvcompositeur.Columns[6].Visible = false;
        }
        private void add_Click(object sender, EventArgs e)
        {
            Modele.Action1 = 1;
            Fajoutmodifcompo add = new Fajoutmodifcompo();
            add.Show();
            
        }

        private void modif_Click(object sender, EventArgs e)
        {
            Modele.Action1 = 2;
            System.Type type = bscompositeur.Current.GetType();
            int id = (int)type.GetProperty("idCompositeur").GetValue(bscompositeur.Current, null);
            Modele.Compochoisi = Modele.Trvcompo(id);
            Fajoutmodifcompo modif = new Fajoutmodifcompo();
            modif.Show();
        }
    }
}
