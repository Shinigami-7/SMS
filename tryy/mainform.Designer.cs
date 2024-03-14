namespace tryy
{
    partial class mainform
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            manageUserToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            utilitiesToolStripMenuItem = new ToolStripMenuItem();
            passwordToolStripMenuItem = new ToolStripMenuItem();
            calculatorToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblusername = new ToolStripStatusLabel();
            lbltime = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            addTeacherToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, adminToolStripMenuItem, userToolStripMenuItem, utilitiesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, saveAsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(173, 34);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(173, 34);
            saveAsToolStripMenuItem.Text = "Save as";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(173, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageUserToolStripMenuItem, addTeacherToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(81, 29);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // manageUserToolStripMenuItem
            // 
            manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            manageUserToolStripMenuItem.Size = new Size(270, 34);
            manageUserToolStripMenuItem.Text = "Manage Teacher";
            manageUserToolStripMenuItem.Click += manageUserToolStripMenuItem_Click;
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changePasswordToolStripMenuItem });
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(86, 29);
            userToolStripMenuItem.Text = "Teacher";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(254, 34);
            changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // utilitiesToolStripMenuItem
            // 
            utilitiesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { passwordToolStripMenuItem, calculatorToolStripMenuItem });
            utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            utilitiesToolStripMenuItem.Size = new Size(85, 29);
            utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // passwordToolStripMenuItem
            // 
            passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            passwordToolStripMenuItem.Size = new Size(192, 34);
            passwordToolStripMenuItem.Text = "Notepad";
            passwordToolStripMenuItem.Click += passwordToolStripMenuItem_Click;
            // 
            // calculatorToolStripMenuItem
            // 
            calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            calculatorToolStripMenuItem.Size = new Size(192, 34);
            calculatorToolStripMenuItem.Text = "Calculator";
            calculatorToolStripMenuItem.Click += calculatorToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblusername, lbltime });
            statusStrip1.Location = new Point(0, 418);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 32);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblusername
            // 
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(179, 25);
            lblusername.Text = "toolStripStatusLabel1";
            // 
            // lbltime
            // 
            lbltime.Name = "lbltime";
            lbltime.Size = new Size(179, 25);
            lbltime.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // addTeacherToolStripMenuItem
            // 
            addTeacherToolStripMenuItem.Name = "addTeacherToolStripMenuItem";
            addTeacherToolStripMenuItem.Size = new Size(270, 34);
            addTeacherToolStripMenuItem.Text = "Add Teacher";
            // 
            // mainform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "mainform";
            Text = "mainform";
            WindowState = FormWindowState.Maximized;
            Load += mainform_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem utilitiesToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem manageUserToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem passwordToolStripMenuItem;
        private ToolStripMenuItem calculatorToolStripMenuItem;
        public ToolStripMenuItem adminToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblusername;
        private ToolStripStatusLabel lbltime;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem addTeacherToolStripMenuItem;
    }
}