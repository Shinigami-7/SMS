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
            DataTable dt = bls.GetAllUserinfo(txtroll.Text,txtname.Text, txtguardianname.Text, txtguardianno.Text,cboclass.Text);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("user alreasy exist");
                return;
            }
            else
            {
                int i = bls.CreateStudent(Convert.ToInt32(txtroll.Text),txtname.Text, txtguardianname.Text, txtguardianno.Text, cboclass.Text);
                if (i > 0)
                {
                    MessageBox.Show("User Created");
                }
            }
            txtroll.Clear();
            txtguardianname.Clear();
            txtguardianno.Clear();
            txtname.Clear();
            cboclass.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageUser frm = new ManageUser();
            frm.Close();
        }

        private void UCcreate_Load(object sender, EventArgs e)
        {
            
            cboclass.SelectedIndex = 0;


        }
    }
}
