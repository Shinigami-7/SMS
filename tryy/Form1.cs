using Businesslayer;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace tryy
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        //pls accept my pull request
        //k xa kta ho.

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        BLLUser blu=new BLLUser();

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Mainform frm = new Mainform();
            frm.lblUsername.Text = "Welcome " + txtusername.Text;
            if (string.IsNullOrWhiteSpace(txtusername.Text))
            {
               MessageBox.Show("Please enter a username");
                txtusername.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show("Please enter a Password");
                txtpassword.Focus();
                return;
            }

            DataTable dt1 = blu.loginUser(txtusername.Text,txtpassword.Text);
            if (dt1.Rows.Count > 0)
            {
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorect username or password");
                return;
            }
            
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Changepwd frm = new Changepwd();
            frm.Show();
            this.Hide();
        }

        private void linkLabel2_MouseHover(object sender, EventArgs e)
        {
            lblnewreg.ForeColor = Color.Black;
        }

        private void linkLabel2_MouseLeave(object sender, EventArgs e)
        {
            lblnewreg.ForeColor = SystemColors.ControlText;
        }

        private void cbousertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblnewreg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblnewreg_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewReg frm = new NewReg();
            frm.Show();
            this.Hide();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                // Cancel the key press if it's not an alphabetic character, backspace, or space
                e.Handled = true;
            }
        }
    }
}
