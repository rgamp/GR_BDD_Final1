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
    public partial class F_ajoutCommande : Form
    {
        public F_ajoutCommande()
        {
            InitializeComponent();
        }

        private void btn_SendComm_Click(object sender, EventArgs e)
        {
            string ncomM = tb_NumComm.Text;
            string nclI = tb_nCli.Text;
            string datE = tb_date.Text;

            DBconnect bdd = new DBconnect();

            if (bdd.Insert_Comm(ncomM, nclI, datE) == true)
            {
                tb_NumComm.Text = "NProduit";
                tb_nCli.Text = "Libelle";
                tb_date.Text = "Prix";
            }
            this.Close();
        }
    }
}
