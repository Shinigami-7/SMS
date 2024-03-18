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
    public partial class UCSearch : UserControl
    {
        public UCSearch()
        {
            InitializeComponent();
        }

       

        private void UCSearch_Load(object sender, EventArgs e)
        {
            cboclass.SelectedIndex = 0;
        }
    }
}
