namespace IE4C1_WinForm
{
    partial class frmListView
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
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            rbPro = new RadioButton();
            rbPP = new RadioButton();
            panel1 = new Panel();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            label5 = new Label();
            cboStudyShift = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            btnEdit = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtStudent = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lvStudent = new ListView();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboStudyShift);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtStudent);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(666, 364);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "បញ្ចូល / កែតម្រូវព័ត៌មាននិស្សិត";
            // 
            // panel2
            // 
            panel2.Controls.Add(rbPro);
            panel2.Controls.Add(rbPP);
            panel2.Location = new Point(162, 235);
            panel2.Name = "panel2";
            panel2.Size = new Size(253, 52);
            panel2.TabIndex = 4;
            // 
            // rbPro
            // 
            rbPro.AutoSize = true;
            rbPro.Location = new Point(162, 9);
            rbPro.Name = "rbPro";
            rbPro.Size = new Size(70, 37);
            rbPro.TabIndex = 1;
            rbPro.TabStop = true;
            rbPro.Text = "ខេត្ត";
            rbPro.UseVisualStyleBackColor = true;
            // 
            // rbPP
            // 
            rbPP.AutoSize = true;
            rbPP.Location = new Point(15, 7);
            rbPP.Name = "rbPP";
            rbPP.Size = new Size(141, 37);
            rbPP.TabIndex = 0;
            rbPP.TabStop = true;
            rbPP.Text = "រាជធានីភ្នំពេញ";
            rbPP.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbMale);
            panel1.Controls.Add(rbFemale);
            panel1.Location = new Point(162, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 45);
            panel1.TabIndex = 2;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(13, 3);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(76, 37);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "ប្រុស";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(95, 3);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(64, 37);
            rbFemale.TabIndex = 1;
            rbFemale.TabStop = true;
            rbFemale.Text = "ស្រី";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 247);
            label5.Name = "label5";
            label5.Size = new Size(109, 33);
            label5.TabIndex = 17;
            label5.Text = "អាសយដ្ឋាន៖";
            // 
            // cboStudyShift
            // 
            cboStudyShift.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStudyShift.FormattingEnabled = true;
            cboStudyShift.Location = new Point(162, 188);
            cboStudyShift.Name = "cboStudyShift";
            cboStudyShift.Size = new Size(182, 41);
            cboStudyShift.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 191);
            label4.Name = "label4";
            label4.Size = new Size(90, 33);
            label4.TabIndex = 15;
            label4.Text = "វេនសិក្សា៖";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 141);
            label3.Name = "label3";
            label3.Size = new Size(55, 33);
            label3.TabIndex = 8;
            label3.Text = "ភេទ៖";
            // 
            // txtID
            // 
            txtID.Location = new Point(162, 37);
            txtID.Name = "txtID";
            txtID.Size = new Size(350, 40);
            txtID.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 41);
            label2.Name = "label2";
            label2.Size = new Size(85, 33);
            label2.TabIndex = 6;
            label2.Text = "អត្តលេខ៖";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(540, 309);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(88, 48);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "កែតម្រូវ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(398, 309);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(136, 48);
            btnClear.TabIndex = 7;
            btnClear.Text = "លុបទាំងអស់";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(280, 309);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 48);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "លុប";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(162, 309);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 48);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "បញ្ចូល";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtStudent
            // 
            txtStudent.Location = new Point(162, 83);
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(350, 40);
            txtStudent.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 87);
            label1.Name = "label1";
            label1.Size = new Size(116, 33);
            label1.TabIndex = 0;
            label1.Text = "ឈ្មោះនិស្សិត៖";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(lvStudent);
            groupBox2.Location = new Point(12, 399);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(666, 239);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "បញ្ជីឈ្មោះនិស្សិត";
            // 
            // lvStudent
            // 
            lvStudent.Dock = DockStyle.Fill;
            lvStudent.Location = new Point(3, 36);
            lvStudent.Name = "lvStudent";
            lvStudent.Size = new Size(660, 200);
            lvStudent.TabIndex = 0;
            lvStudent.UseCompatibleStateImageBehavior = false;
            // 
            // frmListView
            // 
            AutoScaleDimensions = new SizeF(10F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 650);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmListView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Infomation";
            Load += frmListView_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label label3;
        private TextBox txtID;
        private Label label2;
        private Button btnEdit;
        private Button btnClear;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtStudent;
        private Label label1;
        private Label label5;
        private ComboBox cboStudyShift;
        private GroupBox groupBox2;
        private ListView lvStudent;
        private Panel panel2;
        private RadioButton rbPro;
        private RadioButton rbPP;
        private Panel panel1;
    }
}