using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GR_BDD_Final1
{
    public partial class F_menuCommande : Form
    {
        public F_menuCommande()
        {
            InitializeComponent();
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            Form fac = new F_ajoutCommande();
            fac.Visible = true;
        }
    }
}
