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
    public partial class UCEdit : UserControl
    {
        public UCEdit()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtroll_TextChanged(object sender, EventArgs e)
        {

        }

        private void UCEdit_Load(object sender, EventArgs e)
        {
            cboclass.SelectedIndex = 0;
        }
    }
}
