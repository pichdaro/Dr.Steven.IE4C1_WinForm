namespace IE4C1_WinForm
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnLogin = new Button();
            txtUsername = new TextBox();
            btnExit = new Button();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Image = Properties.Resources._3005767_account_door_enter_login_icon;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(203, 104);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(139, 43);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "ចូលប្រើប្រាស់";
            btnLogin.TextAlign = ContentAlignment.MiddleRight;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(203, 12);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(254, 40);
            txtUsername.TabIndex = 0;
            txtUsername.KeyPress += txtUsername_KeyPress;
            // 
            // btnExit
            // 
            btnExit.Image = Properties.Resources._10132175_logout_line_icon;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(348, 104);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(109, 43);
            btnExit.TabIndex = 3;
            btnExit.Text = "ចាកចេញ";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(203, 58);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(254, 40);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login_icon_3060;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._11185794_user_person_profile_avatar_people_icon;
            pictureBox2.Location = new Point(159, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._9025656_password_icon;
            pictureBox3.Location = new Point(159, 58);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._211739_eye_icon;
            pictureBox4.Location = new Point(463, 58);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            pictureBox4.MouseDown += pictureBox4_MouseDown;
            pictureBox4.MouseUp += pictureBox4_MouseUp;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Show/hide password";
            toolTip1.Popup += toolTip1_Popup;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 164);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(btnExit);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Authentication";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUsername;
        private Label label1;
        private Button btnExit;
        private Label label2;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ToolTip toolTip1;
    }
}