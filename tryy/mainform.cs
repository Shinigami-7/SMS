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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void calenderToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {


        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUser frm = new ManageUser();
            frm.Show();
            frm.MdiParent = this;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changepwd frm =new Changepwd();
            frm.Show();
            frm.MdiParent = this;
        }
    }
}
