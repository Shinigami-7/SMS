namespace tryy
{
    partial class Changepwd
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
            groupBox1 = new GroupBox();
            btncancel = new Button();
            btnsubmit = new Button();
            txtconfirmpwd = new TextBox();
            txtnewpwd = new TextBox();
            txtcurrentpwd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btncancel);
            groupBox1.Controls.Add(btnsubmit);
            groupBox1.Controls.Add(txtconfirmpwd);
            groupBox1.Controls.Add(txtnewpwd);
            groupBox1.Controls.Add(txtcurrentpwd);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Navy;
            groupBox1.Location = new Point(73, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(637, 328);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Change Password";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btncancel
            // 
            btncancel.Font = new Font("Segoe UI", 10F);
            btncancel.ForeColor = Color.Black;
            btncancel.Location = new Point(442, 231);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(129, 40);
            btncancel.TabIndex = 7;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // btnsubmit
            // 
            btnsubmit.Font = new Font("Segoe UI", 10F);
            btnsubmit.ForeColor = Color.Black;
            btnsubmit.Location = new Point(296, 231);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(129, 40);
            btnsubmit.TabIndex = 6;
            btnsubmit.Text = "Submit";
            btnsubmit.UseVisualStyleBackColor = true;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // txtconfirmpwd
            // 
            txtconfirmpwd.ForeColor = Color.Black;
            txtconfirmpwd.Location = new Point(268, 171);
            txtconfirmpwd.Name = "txtconfirmpwd";
            txtconfirmpwd.PasswordChar = '*';
            txtconfirmpwd.Size = new Size(320, 39);
            txtconfirmpwd.TabIndex = 5;
            txtconfirmpwd.TextChanged += txtconfirmpwd_TextChanged;
            // 
            // txtnewpwd
            // 
            txtnewpwd.ForeColor = Color.Black;
            txtnewpwd.Location = new Point(268, 117);
            txtnewpwd.Name = "txtnewpwd";
            txtnewpwd.PasswordChar = '*';
            txtnewpwd.Size = new Size(320, 39);
            txtnewpwd.TabIndex = 4;
            // 
            // txtcurrentpwd
            // 
            txtcurrentpwd.ForeColor = Color.Black;
            txtcurrentpwd.Location = new Point(268, 70);
            txtcurrentpwd.Name = "txtcurrentpwd";
            txtcurrentpwd.PasswordChar = '*';
            txtcurrentpwd.Size = new Size(320, 39);
            txtcurrentpwd.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(52, 177);
            label3.Name = "label3";
            label3.Size = new Size(168, 28);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(52, 128);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 1;
            label2.Text = "New Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(52, 76);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 0;
            label1.Text = "Current Password";
            // 
            // Changepwd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 385);
            Controls.Add(groupBox1);
            Name = "Changepwd";
            Text = "Changepwd";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btncancel;
        private Button btnsubmit;
        private TextBox txtconfirmpwd;
        private TextBox txtnewpwd;
        private TextBox txtcurrentpwd;
    }
}