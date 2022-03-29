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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            frm_Table_mgmt frm = new frm_Table_mgmt();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cb_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ShowPass.Checked)
                txt_Password.UseSystemPasswordChar = false;
            else
                txt_Password.UseSystemPasswordChar = true;
        }

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo!", 
                MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true; 
        }
    }
}
