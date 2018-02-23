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
    public partial class F_ReschClient : Form
    {
        public F_ReschClient()
        {
            InitializeComponent();
        }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            DBconnect bdd = new DBconnect();

            string resche = "";
            if (rb_ncli.Checked == true)
            {
                resche = tb_serchCli.Text;
                bdd.Recherche_Client(resche);
            }
            else if (rb_nom.Checked == true)
            {
                resche = tb_serchCli.Text;
            }
            else if (rb_adresse.Checked == true)
            {
                resche = tb_serchCli.Text;
            }
            else if (rb_localite.Checked == true)
            {
                resche = tb_serchCli.Text;
            }
        }
    }
}
