using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace IE4C1_WinForm
{
    internal class MidtermExam
    {
        private void Answer()
        {
            ComboBox comboBox1 = new ComboBox();
            comboBox1.Items.Add("Dummy data");

            ListBox listBox1 = new ListBox();
            listBox1.Items.Add("Hello");

            ListView listView1 = new ListView();
            //string[]...
            ListViewItem listItem = new ListViewItem();
            listView1.Items.Add(listItem);

            Form form1 = new Form();
            Form form2 = new Form();
            form2.IsMdiContainer = true;
            form1.MdiParent = form2;
            form1.Show();

            RadioButton rb1 = new RadioButton();
            rb1.Checked = true;

            CheckBox cb1 = new CheckBox();
            cb1.Checked = true;
        }

        public void Insert()
        {
            OleDbConnection AccCon = new
                OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=" + Application.StartupPath +
                "myDB.accdb;Jet OLEDB:Database Password=ADM@123;");
            AccCon.Open();
            OleDbCommand cmd = AccCon.CreateCommand();
            cmd.CommandText = "INSERT INTO tblProduct([Product_Code]," +
                "[Product_Name], [Type], [Origin], [Description]) " +
                "VALUES(@pcode, @pname, @type, @origin, @desc)";
            cmd.Parameters.AddWithValue("pcode", "P001");
            cmd.Parameters.AddWithValue("pName", "Drinking Water");
            cmd.Parameters.AddWithValue("type", 1);
            cmd.Parameters.AddWithValue("origin", 1);
            cmd.Parameters.AddWithValue("desc", "Lorem Ipsum...");
            cmd.ExecuteNonQuery();
        }

        public void Read(ListView lv)
        {
            OleDbConnection AccCon = new
                OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=" + Application.StartupPath +
                "myDB.accdb;Jet OLEDB:Database Password=ADM@123;");
            AccCon.Open();
            OleDbCommand cmd = AccCon.CreateCommand();
            cmd.CommandText = "SELECT * FROM tblProduct";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] arr = new string[6];
                arr[0] = reader[0].ToString();
                arr[1] = reader[1].ToString();
                arr[2] = reader[2].ToString();
                arr[3] = reader[3].ToString();
                arr[4] = reader[4].ToString();
                arr[5] = reader[5].ToString();
                ListViewItem li = new ListViewItem(arr);
                lv.Items.Add(li);
            }
        }
    }
}