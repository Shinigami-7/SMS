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
            // cboclass
            // 
            cboclass.FormattingEnabled = true;
            cboclass.Items.AddRange(new object[] { "Choose Class", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboclass.Location = new Point(270, 241);
            cboclass.Name = "cboclass";
            cboclass.Size = new Size(182, 40);
            cboclass.TabIndex = 9;
            cboclass.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtguardianno
            // 
            txtguardianno.Location = new Point(270, 191);
            txtguardianno.Multiline = true;
            txtguardianno.Name = "txtguardianno";
            txtguardianno.Size = new Size(313, 39);
            txtguardianno.TabIndex = 8;
            // 
            // txtguardianname
            // 
            txtguardianname.Location = new Point(270, 141);
            txtguardianname.Multiline = true;
            txtguardianname.Name = "txtguardianname";
            txtguardianname.Size = new Size(313, 39);
            txtguardianname.TabIndex = 7;
            // 
            // txtname
            // 
            txtname.Location = new Point(270, 91);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(313, 39);
            txtname.TabIndex = 6;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(434, 308);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(289, 308);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 251);
            label4.Name = "label4";
            label4.Size = new Size(67, 32);
            label4.TabIndex = 3;
            label4.Text = "Class";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 200);
            label3.Name = "label3";
            label3.Size = new Size(149, 32);
            label3.TabIndex = 2;
            label3.Text = "Guardian No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 149);
            label2.Name = "label2";
            label2.Size = new Size(177, 32);
            label2.TabIndex = 1;
            label2.Text = "Guardian name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 98);
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
    }
}
