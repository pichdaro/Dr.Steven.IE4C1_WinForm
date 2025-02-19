using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IE4C1_WinForm
{
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }
        bool UpdateMode;
        Student objStudent;
        private void FetchData()
        {
            try
            {
                //Open connectoin
                MyConfig.AccCon.Open();
                //Create command
                OleDbCommand cmd = MyConfig.AccCon.CreateCommand();
                cmd.CommandText = "SELECT * FROM [tblStudent]";

                //Create DataReader and execute command
                OleDbDataReader reader = cmd.ExecuteReader();
                lvStudent.Items.Clear();
                while (reader.Read())
                {
                    //Create object student to info
                    Student stu = new Student();
                    stu.ID = (int)reader[0];
                    stu.SID = reader[1].ToString();
                    stu.Name = reader[2].ToString();
                    stu.Gender = (Sex)reader[3];
                    stu.Shift = (StudyShift)reader[4];
                    stu.StuAddress = (Address)reader[5];

                    //Creating array to store student's info
                    string[] stuInfo = new string[5];
                    stuInfo[0] = stu.SID;
                    stuInfo[1] = stu.Name;
                    if (stu.Gender == Sex.Male)
                        stuInfo[2] = "ប្រុស";
                    else
                        stuInfo[2] = "ស្រី";
                    if (stu.Shift == StudyShift.Morning)
                        stuInfo[3] = "ព្រឹក";
                    else if (stu.Shift == StudyShift.Afternoon)
                        stuInfo[3] = "ថ្ងៃ";
                    else
                        stuInfo[3] = "យប់";

                    if (stu.StuAddress == Address.Phnom_Penh)
                        stuInfo[4] = "ភ្នំពេញ";
                    else
                        stuInfo[4] = "ខេត្ត";

                    //Creating ListViewItem from array
                    ListViewItem itm = new ListViewItem(stuInfo);
                    //Attach student object to listviewitem
                    itm.Tag = stu;
                    //Add listviewitem to listview
                    lvStudent.Items.Add(itm);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(MyConfig.AccCon.State == ConnectionState.Open)
                    MyConfig.AccCon.Close();
            }
        }
        private void InitControls()
        {
            //Radio buttons gender
            rbFemale.Checked = true;
            rbPP.Checked = true;
            //ComboBox StudyShift
            cboStudyShift.Items.Add("ព្រឹក");
            cboStudyShift.Items.Add("ថ្ងៃ");
            cboStudyShift.Items.Add("យប់");
            cboStudyShift.SelectedIndex = 0;
            //Add ListView columns
            lvStudent.View = View.Details;
            lvStudent.FullRowSelect = true;
            lvStudent.MultiSelect = true;
            lvStudent.Columns.Clear();
            lvStudent.Columns.Add("អត្តលេខ", 150);
            lvStudent.Columns.Add("ឈ្មោះ", 250);
            lvStudent.Columns.Add("ភេទ", 150);
            lvStudent.Columns.Add("វេនសិក្សា", 150);
            lvStudent.Columns.Add("អាសយដ្ឋាន", 200);
            UpdateMode = false;
        }
        private void resetInput()
        {
            txtID.Clear();
            txtStudent.Clear();
            rbFemale.Checked = true;
            rbPP.Checked = true;
            cboStudyShift.SelectedIndex = 0;
            txtID.Focus();
        }
        private void AddData()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please enter a student's ID!",
                    "No data", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtStudent.Text))
            {
                MessageBox.Show("Please enter student's name!",
                    "No data", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            //Create object student to store information
            Student stu = new Student();
            stu.SID = txtID.Text;
            stu.Name = txtStudent.Text;
            if (rbMale.Checked)
                stu.Gender = Sex.Male;
            else
                stu.Gender = Sex.Female;
            stu.Shift = (StudyShift) cboStudyShift.SelectedIndex;
            if (rbPP.Checked)
                stu.StuAddress = Address.Phnom_Penh;
            else
                stu.StuAddress = Address.Province;

            //Add data to database by calling Add() method of the object
            if (stu.Add())
            {
                FetchData();
                MessageBox.Show("A new record has been added!",
                    "success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error adding new record!",
                    "Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            resetInput();
        }

        private void DeleteData()
        {
            if (lvStudent.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please selected an item to delete.",
                    "No item selected", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you" +
                " want to delete?", "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.Yes)
            {
                Student stu;
                stu = (Student)lvStudent.Items[lvStudent.SelectedIndices[0]].Tag;
                if (stu.Delete())
                    FetchData();
            }
        }

        private void SaveData()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please enter a student's ID!",
                    "No data", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtStudent.Text))
            {
                MessageBox.Show("Please enter student's name!",
                    "No data", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            
            //Pass data from controls to objStudent
            objStudent.SID = txtID.Text;
            objStudent.Name = txtStudent.Text;

            if (rbMale.Checked)
                objStudent.Gender = Sex.Male;
            else
                objStudent.Gender = Sex.Female;

            objStudent.Shift = (StudyShift)cboStudyShift.SelectedIndex;

            if (rbPP.Checked)
                objStudent.StuAddress = Address.Phnom_Penh;
            else
                objStudent.StuAddress = Address.Province;

            if (objStudent.UpdateData())
            {
                resetInput();
                LeaveUpdateMode();
                FetchData();
            }
        }

        private void EnterUpdateMode()
        {
            btnAdd.Text = "រក្សាទុក";
            btnDelete.Text = "បោះបង់";
            btnClear.Enabled = false;
            btnEdit.Enabled = false;
            lvStudent.Enabled = false;
            UpdateMode = true;
        }
        private void LeaveUpdateMode()
        {
            btnAdd.Text = "បញ្ចូល";
            btnDelete.Text = "លុប";
            btnClear.Enabled = true;
            btnEdit.Enabled = true;
            lvStudent.Enabled = true;
            UpdateMode = false;
            resetInput();
        }

        private void frmListView_Load(object sender, EventArgs e)
        {
            InitControls();
            FetchData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (UpdateMode)
                SaveData();
            else
                AddData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UpdateMode)
            {
                LeaveUpdateMode();
            }
            else
            {
                DeleteData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you" +
                " want to clear all data?", "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.Yes)
            {
                if (Student.ClearData())
                    FetchData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please selected an item to edit.",
                    "No item selected", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            
            objStudent = (Student)lvStudent.SelectedItems[0].Tag;
            txtID.Text = objStudent.SID;
            txtStudent.Text = objStudent.Name;
            
            if (objStudent.Gender == Sex.Male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            cboStudyShift.SelectedIndex = (int)objStudent.Shift ;
            
            if (objStudent.StuAddress == Address.Phnom_Penh)
                rbPP.Checked = true;
            else
                rbPro.Checked = true;

            EnterUpdateMode();
        }
    }
}
