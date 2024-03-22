namespace tryy
{
    partial class UCcreate
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
            label5 = new Label();
            cboclass = new ComboBox();
            txtguardianno = new TextBox();
            txtguardianname = new TextBox();
            txtname = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtroll);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboclass);
            groupBox1.Controls.Add(txtguardianno);
            groupBox1.Controls.Add(txtguardianname);
            groupBox1.Controls.Add(txtname);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(63, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(632, 482);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Student";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtroll
            // 
            txtroll.Location = new Point(272, 92);
            txtroll.Multiline = true;
            txtroll.Name = "txtroll";
            txtroll.Size = new Size(104, 39);
            txtroll.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 99);
            label5.Name = "label5";
            label5.Size = new Size(92, 32);
            label5.TabIndex = 10;
            label5.Text = "Roll No";
            // 
            // cboclass
            // 
            cboclass.FormattingEnabled = true;
            cboclass.Items.AddRange(new object[] { "Choose Class", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboclass.Location = new Point(272, 284);
            cboclass.Name = "cboclass";
            cboclass.Size = new Size(182, 40);
            cboclass.TabIndex = 4;
            cboclass.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtguardianno
            // 
            txtguardianno.Location = new Point(272, 236);
            txtguardianno.Multiline = true;
            txtguardianno.Name = "txtguardianno";
            txtguardianno.Size = new Size(313, 39);
            txtguardianno.TabIndex = 3;
            // 
            // txtguardianname
            // 
            txtguardianname.Location = new Point(272, 188);
            txtguardianname.Multiline = true;
            txtguardianname.Name = "txtguardianname";
            txtguardianname.Size = new Size(313, 39);
            txtguardianname.TabIndex = 2;
            // 
            // txtname
            // 
            txtname.Location = new Point(272, 140);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(313, 39);
            txtname.TabIndex = 1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(436, 354);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(291, 354);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 295);
            label4.Name = "label4";
            label4.Size = new Size(67, 32);
            label4.TabIndex = 3;
            label4.Text = "Class";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 246);
            label3.Name = "label3";
            label3.Size = new Size(149, 32);
            label3.TabIndex = 2;
            label3.Text = "Guardian No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 197);
            label2.Name = "label2";
            label2.Size = new Size(177, 32);
            label2.TabIndex = 1;
            label2.Text = "Guardian name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 148);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // UCcreate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "UCcreate";
            Size = new Size(752, 579);
            Load += UCcreate_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button button2;
        private Button button1;
        private ComboBox cboclass;
        private TextBox txtguardianno;
        private TextBox txtguardianname;
        private TextBox txtname;
        private TextBox txtroll;
        private Label label5;
    }
}
