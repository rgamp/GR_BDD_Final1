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
    public partial class F_menuProduit : Form
    {
        public F_menuProduit()
        {
            InitializeComponent();
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            Form fap = new F_ajoutProduit();

            fap.Visible = true;
        }
    }
}
