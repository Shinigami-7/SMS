namespace tryy
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbousertype.SelectedIndex = 0;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Mainform frm = new Mainform();
            frm.lblUsername.Text ="Welcome "+txtusername.Text;
            //if (string.IsNullOrWhiteSpace(txtusername.Text))
            //{
            //    MessageBox.Show("Please enter a username");
            //    txtusername.Focus();
            //    return;
            //}
            //if (string.IsNullOrWhiteSpace(txtpassword.Text))
            //{
            //    MessageBox.Show("Please enter a Password");
            //    txtpassword.Focus();
            //    return;
            //}
            //if (cbousertype.Text == "Admin")
            //{
            //    frm.Show();
            //    this.Hide();
            //}
            //else if (cbousertype.Text == "User")
            //{
            //    frm.adminToolStripMenuItem.Enabled = false;
            //    frm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Please choose user type");
            //    return;

            //}
            frm.Show();
            this.Hide();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_MouseHover(object sender, EventArgs e)
        {
            lblnewreg.ForeColor = Color.Black;
        }

        private void linkLabel2_MouseLeave(object sender, EventArgs e)
        {
            lblnewreg.ForeColor = SystemColors.ControlText;
        }
    }
}
