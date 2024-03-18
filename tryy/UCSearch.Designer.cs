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
            cboclass = new ComboBox();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboclass);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(74, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(797, 273);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Student";
            // 
            // cboclass
            // 
            cboclass.FormattingEnabled = true;
            cboclass.Items.AddRange(new object[] { "Choose Class", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboclass.Location = new Point(161, 135);
            cboclass.Name = "cboclass";
            cboclass.Size = new Size(182, 40);
            cboclass.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(78, 135);
            label2.Name = "label2";
            label2.Size = new Size(55, 28);
            label2.TabIndex = 3;
            label2.Text = "Class";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(161, 80);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(416, 34);
            txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(78, 80);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(231, 204);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // UCSearch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "UCSearch";
            Size = new Size(941, 348);
            Load += UCSearch_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSearch;
        private Label label1;
        private Button button1;
        private Label label2;
        private ComboBox cboclass;
    }
}
