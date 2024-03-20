using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryy
{
    public partial class Changepwd : Form
    {
        public Changepwd()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtconfirmpwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtconfirmpwd.Text != txtnewpwd.Text)
            {
                MessageBox.Show("Password Doesn't match");
                txtconfirmpwd.Clear();
                txtconfirmpwd.Focus();
            }
            else
            {
                MessageBox.Show("Password Changed");
                txtcurrentpwd.Clear();
                txtnewpwd.Clear();
                txtconfirmpwd.Clear();
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
