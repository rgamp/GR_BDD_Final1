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
    public partial class F_menu : Form
    {
        public F_menu()
        {
            InitializeComponent();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            Form fmc = new F_menuClient();
            fmc.Visible = true;
        }

        private void btn_prod_Click(object sender, EventArgs e)
        {
            Form fmp = new F_menuProduit();
            fmp.Visible = true;
        }

        private void btn_comm_Click(object sender, EventArgs e)
        {
            Form fmc = new F_menuCommande();
            fmc.Visible = true;
        }
    }
}
