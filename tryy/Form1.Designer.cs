namespace tryy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtusername = new TextBox();
            txtpassword = new TextBox();
            btnsubmit = new Button();
            btncancel = new Button();
            pictureBox1 = new PictureBox();
            lblForgetpwd = new LinkLabel();
            lblnewreg = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI", 12F);
            txtusername.Location = new Point(255, 24);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "Username";
            txtusername.Size = new Size(288, 31);
            txtusername.TabIndex = 0;
            txtusername.TextChanged += txtusername_TextChanged;
            txtusername.KeyPress += txtusername_KeyPress;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 12F);
            txtpassword.Location = new Point(255, 70);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.PlaceholderText = "Password";
            txtpassword.Size = new Size(288, 31);
            txtpassword.TabIndex = 1;
            // 
            // btnsubmit
            // 
            btnsubmit.Location = new Point(265, 120);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(126, 36);
            btnsubmit.TabIndex = 3;
            btnsubmit.Text = "Login";
            btnsubmit.UseVisualStyleBackColor = true;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(417, 120);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(126, 36);
            btncancel.TabIndex = 4;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.userfront;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(35, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 176);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblForgetpwd
            // 
            lblForgetpwd.AutoSize = true;
            lblForgetpwd.Location = new Point(266, 169);
            lblForgetpwd.Name = "lblForgetpwd";
            lblForgetpwd.Size = new Size(144, 25);
            lblForgetpwd.TabIndex = 6;
            lblForgetpwd.TabStop = true;
            lblForgetpwd.Text = "Forget Password";
            lblForgetpwd.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblnewreg
            // 
            lblnewreg.AutoSize = true;
            lblnewreg.Location = new Point(429, 169);
            lblnewreg.Name = "lblnewreg";
            lblnewreg.Size = new Size(73, 25);
            lblnewreg.TabIndex = 7;
            lblnewreg.TabStop = true;
            lblnewreg.Text = "Sign up";
            lblnewreg.LinkClicked += lblnewreg_LinkClicked_1;
            lblnewreg.MouseLeave += linkLabel2_MouseLeave;
            lblnewreg.MouseHover += linkLabel2_MouseHover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 227);
            Controls.Add(lblnewreg);
            Controls.Add(lblForgetpwd);
            Controls.Add(pictureBox1);
            Controls.Add(btncancel);
            Controls.Add(btnsubmit);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btnsubmit;
        private Button btncancel;
        private PictureBox pictureBox1;
        private LinkLabel lblForgetpwd;
        private LinkLabel lblnewreg;
    }
}
