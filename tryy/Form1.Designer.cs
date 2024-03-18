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
            label1 = new Label();
            label2 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            btnsubmit = new Button();
            btncancel = new Button();
            pictureBox1 = new PictureBox();
            cbousertype = new ComboBox();
            label3 = new Label();
            lblForgetpwd = new LinkLabel();
            lblnewreg = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(285, 88);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(285, 157);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI", 12F);
            txtusername.Location = new Point(403, 82);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(365, 39);
            txtusername.TabIndex = 0;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 12F);
            txtpassword.Location = new Point(403, 155);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(365, 39);
            txtpassword.TabIndex = 1;
            // 
            // btnsubmit
            // 
            btnsubmit.Location = new Point(414, 284);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(126, 36);
            btnsubmit.TabIndex = 3;
            btnsubmit.Text = "Submit";
            btnsubmit.UseVisualStyleBackColor = true;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(576, 284);
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
            pictureBox1.Location = new Point(57, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 193);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // cbousertype
            // 
            cbousertype.FormattingEnabled = true;
            cbousertype.Items.AddRange(new object[] { "Choose Type", "Admin", "Teacher" });
            cbousertype.Location = new Point(403, 226);
            cbousertype.Name = "cbousertype";
            cbousertype.Size = new Size(227, 33);
            cbousertype.TabIndex = 2;
            cbousertype.SelectedIndexChanged += cbousertype_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(285, 226);
            label3.Name = "label3";
            label3.Size = new Size(108, 32);
            label3.TabIndex = 0;
            label3.Text = "Usertype";
            // 
            // lblForgetpwd
            // 
            lblForgetpwd.AutoSize = true;
            lblForgetpwd.Location = new Point(404, 334);
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
            lblnewreg.Location = new Point(576, 334);
            lblnewreg.Name = "lblnewreg";
            lblnewreg.Size = new Size(115, 25);
            lblnewreg.TabIndex = 7;
            lblnewreg.TabStop = true;
            lblnewreg.Text = "New Register";
            lblnewreg.LinkClicked += lblnewreg_LinkClicked_1;
            lblnewreg.MouseLeave += linkLabel2_MouseLeave;
            lblnewreg.MouseHover += linkLabel2_MouseHover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 485);
            Controls.Add(lblnewreg);
            Controls.Add(lblForgetpwd);
            Controls.Add(pictureBox1);
            Controls.Add(btncancel);
            Controls.Add(btnsubmit);
            Controls.Add(cbousertype);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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

        private Label label1;
        private Label label2;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btnsubmit;
        private Button btncancel;
        private PictureBox pictureBox1;
        private ComboBox cbousertype;
        private Label label3;
        private LinkLabel lblForgetpwd;
        private LinkLabel lblnewreg;
    }
}
