using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace IE4C1_WinForm
{
    internal class Student
    {
        public int ID { get;set; }
        public string SID { get;set; }
        public string Name { get;set; }
        public Sex Gender { get; set; }
        public StudyShift Shift { get; set; }
        public Address StuAddress { get; set; }
        public string Info 
        { 
            get {
                return "ID: " + SID + "\nName:" + Name;
            }
        }
        public bool Add()
        {
            try
            {
                //Open connectoin
                MyConfig.AccCon.Open();
                //Create command
                OleDbCommand cmd = MyConfig.AccCon.CreateCommand();
                cmd.CommandText = "INSERT INTO tblStudent([SID]," +
                    "[SName], [Gender], [StudyShift], [Address]) " +
                    "VALUES([@sid],[@sname], [@gender], [@shift], " +
                    "[@address])";
                cmd.Parameters.AddWithValue("sid", SID);
                cmd.Parameters.AddWithValue("sname", Name);
                cmd.Parameters.AddWithValue("gender", Gender);
                cmd.Parameters.AddWithValue("shift", Shift);
                cmd.Parameters.AddWithValue("address", StuAddress);
                //Create DataReader and execute command
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (MyConfig.AccCon.State == ConnectionState.Open)
                    MyConfig.AccCon.Close();
            }
        }
        public bool Delete()
        {
            try
            {
                //Open connectoin
                MyConfig.AccCon.Open();
                //Create command
                OleDbCommand cmd = MyConfig.AccCon.CreateCommand();
                cmd.CommandText = "DELETE FROM tblStudent WHERE " +
                    "[ID] = [@id]";
                cmd.Parameters.AddWithValue("id", ID);
                
                //Create DataReader and execute command
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (MyConfig.AccCon.State == ConnectionState.Open)
                    MyConfig.AccCon.Close();
            }
        }
        public static bool ClearData()
        {
            try
            {
                //Open connectoin
                MyConfig.AccCon.Open();
                //Create command
                OleDbCommand cmd = MyConfig.AccCon.CreateCommand();
                cmd.CommandText = "DELETE FROM tblStudent";

                //Create DataReader and execute command
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (MyConfig.AccCon.State == ConnectionState.Open)
                    MyConfig.AccCon.Close();
            }
        }
        public bool UpdateData()
        {
            try
            {
                //Open connectoin
                MyConfig.AccCon.Open();
                //Create command
                OleDbCommand cmd = MyConfig.AccCon.CreateCommand();
                cmd.CommandText = "UPDATE tblStudent SET " +
                    "[SID]=@sid, [SName]=@sname, [Gender]=@gender," +
                    " [StudyShift]=@shift, [Address]=@address" +
                    " WHERE [ID]=@id";
                cmd.Parameters.AddWithValue("sid", SID);
                cmd.Parameters.AddWithValue("sname", Name);
                cmd.Parameters.AddWithValue("gender", Gender);
                cmd.Parameters.AddWithValue("shift", Shift);
                cmd.Parameters.AddWithValue("address", StuAddress);
                cmd.Parameters.AddWithValue("id", ID);

                //Execute command
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (MyConfig.AccCon.State == ConnectionState.Open)
                    MyConfig.AccCon.Close();
            }
        }
    }
}
