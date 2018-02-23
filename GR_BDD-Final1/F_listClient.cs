using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace GR_BDD_Final1
{
    public partial class F_listClient : Form
    {
        public F_listClient()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBconnect bdd = new DBconnect();

            if (bdd.List_Client() == true)
            {
                cb_listClient.Items.Add(bdd.List_Client());
            }

            

            this.Close();
        }
    }
}
