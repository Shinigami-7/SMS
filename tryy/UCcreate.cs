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

namespace tryy
{
    public partial class UCcreate : UserControl
    {
        public UCcreate()
        {
            InitializeComponent();
        }
        BLLStudent bls = new BLLStudent();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            cboclass.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = bls.CreateStudent(txtname.Text, txtguardianname.Text, txtguardianno.Text, cboclass.Text);
            if (i > 0)
            {
                MessageBox.Show("User Created");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageUser frm = new ManageUser();
            frm.Close();
        }
    }
}
