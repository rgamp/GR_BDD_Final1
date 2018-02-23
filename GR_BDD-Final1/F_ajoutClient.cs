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
    public partial class F_ajoutClient : Form
    {
        public F_ajoutClient()
        {
            InitializeComponent();
        }

        private void btn_SendClient_Click(object sender, EventArgs e)
        {
            string nclI = tb_Ncli.Text;
            string noM = tb_Nom.Text;
            string localitE = tb_Localite.Text;
            string comptE = tb_Compte.Text;
            string caT = tb_Cat.Text;
            string adressE = tb_Adresse.Text;

            DBconnect bdd = new DBconnect();

            if (bdd.Insert_Client(nclI, noM, localitE, adressE, caT, comptE) == true)
            {
                tb_Nom.Text = "Nom";
                tb_Ncli.Text = "Nb client";
                tb_Localite.Text = "Localite";
                tb_Compte.Text = "Compte";
                tb_Cat.Text = "Cat";
                tb_Adresse.Text = "Adresse";

            }
            this.Close();
        }
    }
}
