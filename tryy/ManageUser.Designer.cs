namespace tryy
{
    partial class ManageUser
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 74);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(233, 9);
            label1.Name = "label1";
            label1.Size = new Size(331, 54);
            label1.TabIndex = 0;
            label1.Text = "Manage Teacher";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 491);
            panel2.Name = "panel2";
            panel2.Size = new Size(1030, 66);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(167, 417);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 25);
            label2.Name = "label2";
            label2.Size = new Size(122, 37);
            label2.TabIndex = 0;
            label2.Text = "Create User";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(167, 74);
            panel4.Name = "panel4";
            panel4.Size = new Size(863, 417);
            panel4.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(122, 37);
            label3.TabIndex = 1;
            label3.Text = "Edit User";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(12, 142);
            label4.Name = "label4";
            label4.Size = new Size(122, 37);
            label4.TabIndex = 2;
            label4.Text = "Delete User";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(12, 193);
            label5.Name = "label5";
            label5.Size = new Size(122, 37);
            label5.TabIndex = 3;
            label5.Text = "Exit";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManageUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 557);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManageUser";
            Text = "ManageUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}