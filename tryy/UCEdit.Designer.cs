namespace tryy
{
    partial class UCEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtroll = new TextBox();
            cboclass = new ComboBox();
            txtguardianno = new TextBox();
            txtguardianname = new TextBox();
            txtename = new TextBox();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtroll);
            groupBox1.Controls.Add(cboclass);
            groupBox1.Controls.Add(txtguardianno);
            groupBox1.Controls.Add(txtguardianname);
            groupBox1.Controls.Add(txtename);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(55, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 452);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit Student";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtroll
            // 
            txtroll.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtroll.Location = new Point(20, 253);
            txtroll.Multiline = true;
            txtroll.Name = "txtroll";
            txtroll.PlaceholderText = "Roll No";
            txtroll.Size = new Size(78, 35);
            txtroll.TabIndex = 11;
            txtroll.TextChanged += txtroll_TextChanged;
            // 
            // cboclass
            // 
            cboclass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cboclass.FormattingEnabled = true;
            cboclass.Items.AddRange(new object[] { "Grade", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboclass.Location = new Point(656, 252);
            cboclass.Name = "cboclass";
            cboclass.Size = new Size(78, 36);
            cboclass.TabIndex = 19;
            // 
            // txtguardianno
            // 
            txtguardianno.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtguardianno.Location = new Point(491, 249);
            txtguardianno.Multiline = true;
            txtguardianno.Name = "txtguardianno";
            txtguardianno.PlaceholderText = "Guardian no";
            txtguardianno.Size = new Size(146, 39);
            txtguardianno.TabIndex = 17;
            // 
            // txtguardianname
            // 
            txtguardianname.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtguardianname.Location = new Point(299, 253);
            txtguardianname.Multiline = true;
            txtguardianname.Name = "txtguardianname";
            txtguardianname.PlaceholderText = "Guardian name";
            txtguardianname.Size = new Size(173, 39);
            txtguardianname.TabIndex = 15;
            // 
            // txtename
            // 
            txtename.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtename.Location = new Point(117, 253);
            txtename.Multiline = true;
            txtename.Name = "txtename";
            txtename.PlaceholderText = "Name";
            txtename.Size = new Size(163, 39);
            txtename.TabIndex = 13;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(506, 340);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 21;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(361, 340);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 20;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // UCEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "UCEdit";
            Size = new Size(881, 547);
            Load += UCEdit_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtroll;
        private ComboBox cboclass;
        private TextBox txtguardianno;
        private TextBox txtguardianname;
        private TextBox txtename;
        private Button button2;
        private Button button1;
    }
}
