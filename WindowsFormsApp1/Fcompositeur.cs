﻿using System;
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
    public partial class Fcompositeur : Form
    {
        public Fcompositeur()
        {
            InitializeComponent();
        }
        private void FCompositeurNation_Load(object sender, EventArgs e)
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

    }
}
