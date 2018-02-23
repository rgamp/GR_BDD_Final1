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
    public partial class F_ajoutProduit : Form
    {
        public F_ajoutProduit()
        {
            InitializeComponent();
        }

        private void btn_SendItem_Click(object sender, EventArgs e)
        {
            string nproD = tb_Npro.Text;
            string libellE = tb_Libelle.Text;
            string priX = tb_Prix.Text;
            string stocK = tb_Stock.Text;

            DBconnect bdd = new DBconnect();

            if (bdd.Insert_Item(nproD, libellE, priX, stocK) == true)
            {
                tb_Npro.Text = "NProduit";
                tb_Libelle.Text = "Libelle";
                tb_Prix.Text = "Prix";
                tb_Stock.Text = "Stock";
            }
            this.Close();
        }
    }
}
