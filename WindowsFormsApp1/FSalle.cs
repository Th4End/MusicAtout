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
    public partial class FSalle : Form
    {
        public FSalle()
        {
            InitializeComponent();
        }
        private void FSalle_Load(object sender, EventArgs e)
        {
            bgsalle.DataSource = Modele.listsalle();
            viewsalle.DataSource = bgsalle;
            viewsalle.Columns[0].Visible = false;
            viewsalle.Columns[5].Visible = false;
            viewsalle.Columns[4].Visible = false;
            viewsalle.Columns[3].Visible = false;
            viewsalle.Columns[6].Visible = false;
            viewsalle.Columns[5].Visible = false;

        }
    }
}
