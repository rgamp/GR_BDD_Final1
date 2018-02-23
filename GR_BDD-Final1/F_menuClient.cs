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
    public partial class F_menuClient : Form
    {
        public F_menuClient()
        {
            InitializeComponent();
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            Form fac = new F_ajoutClient();
            fac.Visible = true;
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            Form flc = new F_listClient();
            flc.Visible = true;
        }

        private void btn_cherch_Click(object sender, EventArgs e)
        {
            Form fsc = new F_ReschClient();
            fsc.Visible = true;
        }
    }
}
