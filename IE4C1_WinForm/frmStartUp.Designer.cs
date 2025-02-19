namespace IE4C1_WinForm
{
    partial class frmStartUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClickMe = new Button();
            btnWelcome = new Button();
            txtYourName = new TextBox();
            label1 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClickMe
            // 
            btnClickMe.ForeColor = SystemColors.ControlText;
            btnClickMe.Location = new Point(112, 60);
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Size = new Size(75, 32);
            btnClickMe.TabIndex = 0;
            btnClickMe.Text = "Click Me";
            btnClickMe.UseVisualStyleBackColor = true;
            btnClickMe.Click += btnClickMe_Click;
            btnClickMe.MouseLeave += btnClickMe_MouseLeave;
            btnClickMe.MouseHover += btnClickMe_MouseHover;
            // 
            // btnWelcome
            // 
            btnWelcome.Location = new Point(193, 60);
            btnWelcome.Name = "btnWelcome";
            btnWelcome.Size = new Size(75, 32);
            btnWelcome.TabIndex = 1;
            btnWelcome.Text = "សួស្ដី";
            btnWelcome.UseVisualStyleBackColor = true;
            btnWelcome.Click += btnWelcome_Click;
            // 
            // txtYourName
            // 
            txtYourName.Location = new Point(112, 22);
            txtYourName.Name = "txtYourName";
            txtYourName.Size = new Size(174, 29);
            txtYourName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(72, 22);
            label1.TabIndex = 3;
            label1.Text = "Your Name:";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(12, 100);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 4;
            button1.Text = "បិទ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtYourName);
            groupBox1.Controls.Add(btnClickMe);
            groupBox1.Controls.Add(btnWelcome);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(144, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 112);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hello, world!";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // frmStartUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 216);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmStartUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Start Up";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClickMe;
        private Button btnWelcome;
        private TextBox txtYourName;
        private Label label1;
        private Button button1;
        private GroupBox groupBox1;
    }
}
