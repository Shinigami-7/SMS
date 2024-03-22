using Businesslayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace tryy
{
    public partial class UCSearch : UserControl
    {
        public UCSearch()
        {
            InitializeComponent();
        }

        BLLStudent blu = new BLLStudent();

        private void UCSearch_Load(object sender, EventArgs e)
        {
            cboclass.SelectedIndex = 0;
            cboegrade.SelectedIndex = 0;
            LoadGrid();
        }

        public void LoadGrid()
        {
            DataTable dt = blu.GetAllUser();
            dataGridView1.DataSource = dt;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataTable dt = blu.GetAllUserbyusername(txtSearch.Text, cboclass.Text);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Student not found");
            }
            cboclass.SelectedIndex = 0;
            txtSearch.Clear();
        }

        private void pbedit_Click(object sender, EventArgs e)
        {
     
            int i = blu.EditStudent(Convert.ToInt32(txtroll.Text), txtename.Text, txtguardianname.Text, txtguardianno.Text, cboegrade.Text);



        }
    }
}
