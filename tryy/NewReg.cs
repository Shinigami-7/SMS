using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Businesslayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tryy
{
    public partial class NewReg : Form
    {
        public NewReg()
        {
            InitializeComponent();
        }
        BLLUser blu = new BLLUser();

        private void NewReg_Load(object sender, EventArgs e)
        {
            cbogender.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Please enter name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Prevent further action
            }
            if (txtcpassword.Text != txtpassword.Text)
            {
                MessageBox.Show("Password doesn't match");
                txtcpassword.Clear();
                txtcpassword.Focus();
                return;
            }
            int i = blu.CreateUser(txtname.Text, txtusername.Text, txtpassword.Text, txtcpassword.Text, txtemail.Text, cbogender.Text);
            if (i > 0)
            {
                MessageBox.Show("User Created");
            }
            //txtcpassword.Clear();
            //txtemail.Clear();
            //txtname.Clear();
            //txtpassword.Clear();
            //cbogender.Items.Clear();
            this.Close();
            Form1 frm = new Form1();
            frm.Show();

        }

        private void txtname_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
