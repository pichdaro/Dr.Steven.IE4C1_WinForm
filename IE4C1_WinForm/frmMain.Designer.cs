namespace IE4C1_WinForm
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            userPreferenceToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            changeEmailToolStripMenuItem = new ToolStripMenuItem();
            changToolStripMenuItem = new ToolStripMenuItem();
            openFormToolStripMenuItem = new ToolStripMenuItem();
            frmStartupToolStripMenuItem = new ToolStripMenuItem();
            listBoxStudentToolStripMenuItem = new ToolStripMenuItem();
            listBoxStudentV1ToolStripMenuItem = new ToolStripMenuItem();
            listViewStudentToolStripMenuItem = new ToolStripMenuItem();
            userManagerToolStripMenuItem = new ToolStripMenuItem();
            windowsToolStripMenuItem = new ToolStripMenuItem();
            arrangeToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileVerticleToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            donateToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tsDate = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, openFormToolStripMenuItem, windowsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1013, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 34);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userPreferenceToolStripMenuItem, accountToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // userPreferenceToolStripMenuItem
            // 
            userPreferenceToolStripMenuItem.Name = "userPreferenceToolStripMenuItem";
            userPreferenceToolStripMenuItem.Size = new Size(270, 34);
            userPreferenceToolStripMenuItem.Text = "User Preference";
            userPreferenceToolStripMenuItem.Click += userPreferenceToolStripMenuItem_Click;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changePasswordToolStripMenuItem, changeEmailToolStripMenuItem, changToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(270, 34);
            accountToolStripMenuItem.Text = "Account";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(270, 34);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // changeEmailToolStripMenuItem
            // 
            changeEmailToolStripMenuItem.Name = "changeEmailToolStripMenuItem";
            changeEmailToolStripMenuItem.Size = new Size(270, 34);
            changeEmailToolStripMenuItem.Text = "Change Email";
            // 
            // changToolStripMenuItem
            // 
            changToolStripMenuItem.Name = "changToolStripMenuItem";
            changToolStripMenuItem.Size = new Size(270, 34);
            changToolStripMenuItem.Text = "Change Avata";
            changToolStripMenuItem.Click += changToolStripMenuItem_Click;
            // 
            // openFormToolStripMenuItem
            // 
            openFormToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { frmStartupToolStripMenuItem, listBoxStudentToolStripMenuItem, listBoxStudentV1ToolStripMenuItem, listViewStudentToolStripMenuItem, userManagerToolStripMenuItem });
            openFormToolStripMenuItem.Name = "openFormToolStripMenuItem";
            openFormToolStripMenuItem.Size = new Size(119, 29);
            openFormToolStripMenuItem.Text = "&Open Form";
            // 
            // frmStartupToolStripMenuItem
            // 
            frmStartupToolStripMenuItem.Name = "frmStartupToolStripMenuItem";
            frmStartupToolStripMenuItem.Size = new Size(280, 34);
            frmStartupToolStripMenuItem.Text = "frmStartup";
            frmStartupToolStripMenuItem.Click += frmStartupToolStripMenuItem_Click;
            // 
            // listBoxStudentToolStripMenuItem
            // 
            listBoxStudentToolStripMenuItem.Name = "listBoxStudentToolStripMenuItem";
            listBoxStudentToolStripMenuItem.Size = new Size(280, 34);
            listBoxStudentToolStripMenuItem.Text = "ListBox - Student -V1";
            listBoxStudentToolStripMenuItem.Click += listBoxStudentToolStripMenuItem_Click;
            // 
            // listBoxStudentV1ToolStripMenuItem
            // 
            listBoxStudentV1ToolStripMenuItem.Name = "listBoxStudentV1ToolStripMenuItem";
            listBoxStudentV1ToolStripMenuItem.Size = new Size(280, 34);
            listBoxStudentV1ToolStripMenuItem.Text = "ListBox - Student -V2";
            listBoxStudentV1ToolStripMenuItem.Click += listBoxStudentV1ToolStripMenuItem_Click;
            // 
            // listViewStudentToolStripMenuItem
            // 
            listViewStudentToolStripMenuItem.Name = "listViewStudentToolStripMenuItem";
            listViewStudentToolStripMenuItem.Size = new Size(280, 34);
            listViewStudentToolStripMenuItem.Text = "ListView - Student";
            listViewStudentToolStripMenuItem.Click += listViewStudentToolStripMenuItem_Click;
            // 
            // userManagerToolStripMenuItem
            // 
            userManagerToolStripMenuItem.Name = "userManagerToolStripMenuItem";
            userManagerToolStripMenuItem.Size = new Size(280, 34);
            userManagerToolStripMenuItem.Text = "User Manager";
            userManagerToolStripMenuItem.Click += userManagerToolStripMenuItem_Click;
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arrangeToolStripMenuItem });
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(102, 29);
            windowsToolStripMenuItem.Text = "&Windows";
            // 
            // arrangeToolStripMenuItem
            // 
            arrangeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, tileVerticleToolStripMenuItem, tileHorizontalToolStripMenuItem });
            arrangeToolStripMenuItem.Name = "arrangeToolStripMenuItem";
            arrangeToolStripMenuItem.Size = new Size(177, 34);
            arrangeToolStripMenuItem.Text = "&Arrange";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(227, 34);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // tileVerticleToolStripMenuItem
            // 
            tileVerticleToolStripMenuItem.Name = "tileVerticleToolStripMenuItem";
            tileVerticleToolStripMenuItem.Size = new Size(227, 34);
            tileVerticleToolStripMenuItem.Text = "Tile Vertical";
            tileVerticleToolStripMenuItem.Click += tileVerticleToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(227, 34);
            tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            tileHorizontalToolStripMenuItem.Click += tileHorizontalToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, donateToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(172, 34);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // donateToolStripMenuItem
            // 
            donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            donateToolStripMenuItem.Size = new Size(172, 34);
            donateToolStripMenuItem.Text = "&Donate";
            donateToolStripMenuItem.Click += donateToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, tsDate });
            statusStrip1.Location = new Point(0, 447);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1013, 32);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(74, 25);
            toolStripStatusLabel1.Text = "Howdy!";
            // 
            // tsDate
            // 
            tsDate.Name = "tsDate";
            tsDate.Size = new Size(0, 25);
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 479);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
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
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem userPreferenceToolStripMenuItem;
        private ToolStripMenuItem openFormToolStripMenuItem;
        private ToolStripMenuItem frmStartupToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private ToolStripMenuItem arrangeToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileVerticleToolStripMenuItem;
        private ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem donateToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel tsDate;
        private ToolStripMenuItem listBoxStudentToolStripMenuItem;
        private ToolStripMenuItem listBoxStudentV1ToolStripMenuItem;
        private ToolStripMenuItem listViewStudentToolStripMenuItem;
        private ToolStripMenuItem userManagerToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem changeEmailToolStripMenuItem;
        private ToolStripMenuItem changToolStripMenuItem;
    }
}