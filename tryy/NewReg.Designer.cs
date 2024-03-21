namespace tryy
{
    partial class NewReg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbogender = new ComboBox();
            txtcpassword = new TextBox();
            txtpassword = new TextBox();
            txtemail = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtname = new TextBox();
            label5 = new Label();
            gbnewreg = new GroupBox();
            txtusername = new TextBox();
            label6 = new Label();
            gbnewreg.SuspendLayout();
            SuspendLayout();
            // 
            // cbogender
            // 
            cbogender.Font = new Font("Segoe UI", 10F);
            cbogender.FormattingEnabled = true;
            cbogender.Items.AddRange(new object[] { "Choose Gender", "Male", "Female" });
            cbogender.Location = new Point(243, 301);
            cbogender.Name = "cbogender";
            cbogender.Size = new Size(182, 36);
            cbogender.TabIndex = 10;
            // 
            // txtcpassword
            // 
            txtcpassword.Font = new Font("Segoe UI", 10F);
            txtcpassword.Location = new Point(243, 252);
            txtcpassword.Multiline = true;
            txtcpassword.Name = "txtcpassword";
            txtcpassword.PasswordChar = '*';
            txtcpassword.Size = new Size(313, 39);
            txtcpassword.TabIndex = 9;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 10F);
            txtpassword.Location = new Point(243, 203);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(313, 39);
            txtpassword.TabIndex = 8;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 10F);
            txtemail.Location = new Point(243, 105);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(313, 39);
            txtemail.TabIndex = 6;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(407, 371);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 12;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(262, 371);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 11;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(31, 315);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 13;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(31, 265);
            label3.Name = "label3";
            label3.Size = new Size(176, 28);
            label3.TabIndex = 12;
            label3.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(31, 215);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 11;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(31, 115);
            label1.Name = "label1";
            label1.Size = new Size(60, 28);
            label1.TabIndex = 10;
            label1.Text = "Email";
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 10F);
            txtname.Location = new Point(243, 56);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(313, 39);
            txtname.TabIndex = 5;
            txtname.Click += txtname_Click;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(31, 65);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 20;
            label5.Text = "Name";
            // 
            // gbnewreg
            // 
            gbnewreg.Controls.Add(txtusername);
            gbnewreg.Controls.Add(label6);
            gbnewreg.Controls.Add(txtname);
            gbnewreg.Controls.Add(label5);
            gbnewreg.Controls.Add(cbogender);
            gbnewreg.Controls.Add(txtcpassword);
            gbnewreg.Controls.Add(txtpassword);
            gbnewreg.Controls.Add(txtemail);
            gbnewreg.Controls.Add(button2);
            gbnewreg.Controls.Add(button1);
            gbnewreg.Controls.Add(label4);
            gbnewreg.Controls.Add(label3);
            gbnewreg.Controls.Add(label2);
            gbnewreg.Controls.Add(label1);
            gbnewreg.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbnewreg.Location = new Point(52, 21);
            gbnewreg.Name = "gbnewreg";
            gbnewreg.Size = new Size(653, 445);
            gbnewreg.TabIndex = 22;
            gbnewreg.TabStop = false;
            gbnewreg.Text = "New Register";
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI", 10F);
            txtusername.Location = new Point(243, 154);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(313, 39);
            txtusername.TabIndex = 7;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(31, 165);
            label6.Name = "label6";
            label6.Size = new Size(104, 28);
            label6.TabIndex = 22;
            label6.Text = "Username";
            // 
            // NewReg
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 499);
            Controls.Add(gbnewreg);
            Name = "NewReg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewReg";
            Load += NewReg_Load;
            gbnewreg.ResumeLayout(false);
            gbnewreg.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbogender;
        private TextBox txtcpassword;
        private TextBox txtpassword;
        private TextBox txtemail;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtname;
        private Label label5;
        private GroupBox gbnewreg;
        private TextBox txtusername;
        private Label label6;
    }
}