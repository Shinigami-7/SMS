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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUser));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            lbledit = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
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
            label1.Location = new Point(316, 9);
            label1.Name = "label1";
            label1.Size = new Size(335, 54);
            label1.TabIndex = 0;
            label1.Text = "Manage Student";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 525);
            panel2.Name = "panel2";
            panel2.Size = new Size(1030, 66);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(lbledit);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(167, 451);
            panel3.TabIndex = 2;
            // 
            // lbledit
            // 
            lbledit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbledit.BackColor = Color.White;
            lbledit.Font = new Font("Segoe UI", 10F);
            lbledit.Location = new Point(12, 160);
            lbledit.Name = "lbledit";
            lbledit.Size = new Size(142, 37);
            lbledit.TabIndex = 4;
            lbledit.Text = "Edit User";
            lbledit.TextAlign = ContentAlignment.MiddleCenter;
            lbledit.Click += lbledit_Click;
            lbledit.MouseLeave += lbledit_MouseLeave;
            lbledit.MouseHover += lbledit_MouseHover;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(12, 215);
            label5.Name = "label5";
            label5.Size = new Size(142, 37);
            label5.TabIndex = 3;
            label5.Text = "Back";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            label5.MouseLeave += label5_MouseLeave;
            label5.MouseHover += label5_MouseHover;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(142, 37);
            label3.TabIndex = 1;
            label3.Text = "Search User";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            label3.MouseLeave += label3_MouseLeave;
            label3.MouseHover += label3_MouseHover;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(142, 37);
            label2.TabIndex = 0;
            label2.Text = "Create User";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            label2.MouseLeave += label2_MouseLeave;
            label2.MouseHover += label2_MouseHover;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(167, 74);
            panel4.Name = "panel4";
            panel4.Size = new Size(863, 451);
            panel4.TabIndex = 3;
            // 
            // ManageUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 591);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
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
        private Label label3;
        private Label lbledit;
    }
}