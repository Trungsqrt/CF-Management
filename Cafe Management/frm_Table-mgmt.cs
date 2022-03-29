using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management
{
    public partial class frm_Table_mgmt : Form
    {
        public frm_Table_mgmt()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AccountDetail frm = new frm_AccountDetail();
            frm.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Admin frm = new frm_Admin();
            frm.ShowDialog();

        }
    }
}
