namespace tryy
{
    partial class UCSearch
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
            pictureBox1 = new PictureBox();
            cboclass = new ComboBox();
            txtSearch = new TextBox();
            pbedit = new PictureBox();
            dataGridView1 = new DataGridView();
            txtroll = new TextBox();
            cboegrade = new ComboBox();
            txtguardianno = new TextBox();
            txtguardianname = new TextBox();
            txtename = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbedit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(cboclass);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(74, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(797, 171);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Student";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(498, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // cboclass
            // 
            cboclass.FormattingEnabled = true;
            cboclass.Items.AddRange(new object[] { "Grade", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboclass.Location = new Point(376, 80);
            cboclass.Name = "cboclass";
            cboclass.Size = new Size(101, 40);
            cboclass.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(113, 80);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Name";
            txtSearch.Size = new Size(241, 34);
            txtSearch.TabIndex = 0;
            // 
            // pbedit
            // 
            pbedit.BackgroundImageLayout = ImageLayout.Center;
            pbedit.Image = Properties.Resources.edit;
            pbedit.Location = new Point(812, 356);
            pbedit.Name = "pbedit";
            pbedit.Size = new Size(33, 32);
            pbedit.SizeMode = PictureBoxSizeMode.StretchImage;
            pbedit.TabIndex = 4;
            pbedit.TabStop = false;
            pbedit.Click += pbedit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(905, 96);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtroll
            // 
            txtroll.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtroll.Location = new Point(76, 349);
            txtroll.Multiline = true;
            txtroll.Name = "txtroll";
            txtroll.PlaceholderText = "Roll No";
            txtroll.Size = new Size(78, 35);
            txtroll.TabIndex = 20;
            // 
            // cboegrade
            // 
            cboegrade.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cboegrade.FormattingEnabled = true;
            cboegrade.Items.AddRange(new object[] { "Grade", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboegrade.Location = new Point(712, 348);
            cboegrade.Name = "cboegrade";
            cboegrade.Size = new Size(78, 36);
            cboegrade.TabIndex = 24;
            // 
            // txtguardianno
            // 
            txtguardianno.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtguardianno.Location = new Point(547, 345);
            txtguardianno.Multiline = true;
            txtguardianno.Name = "txtguardianno";
            txtguardianno.PlaceholderText = "Guardian no";
            txtguardianno.Size = new Size(146, 39);
            txtguardianno.TabIndex = 23;
            // 
            // txtguardianname
            // 
            txtguardianname.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtguardianname.Location = new Point(355, 349);
            txtguardianname.Multiline = true;
            txtguardianname.Name = "txtguardianname";
            txtguardianname.PlaceholderText = "Guardian name";
            txtguardianname.Size = new Size(173, 39);
            txtguardianname.TabIndex = 22;
            // 
            // txtename
            // 
            txtename.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtename.Location = new Point(173, 349);
            txtename.Multiline = true;
            txtename.Name = "txtename";
            txtename.PlaceholderText = "Name";
            txtename.Size = new Size(163, 39);
            txtename.TabIndex = 21;
            // 
            // UCSearch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbedit);
            Controls.Add(txtroll);
            Controls.Add(cboegrade);
            Controls.Add(txtguardianno);
            Controls.Add(txtguardianname);
            Controls.Add(txtename);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "UCSearch";
            Size = new Size(941, 499);
            Load += UCSearch_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbedit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSearch;
        private ComboBox cboclass;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private PictureBox pbedit;
        private TextBox txtroll;
        private ComboBox cboegrade;
        private TextBox txtguardianno;
        private TextBox txtguardianname;
        private TextBox txtename;
    }
}
