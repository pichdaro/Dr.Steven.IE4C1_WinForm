using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE4C1_WinForm
{
    public partial class frmListBoxV1 : Form
    {
        public frmListBoxV1()
        {
            InitializeComponent();
        }

        private void Add()
        {
            if (string.IsNullOrEmpty(txtStudent.Text))
            {
                MessageBox.Show("Please enter a name!",
                    "No data", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            lbStudent.Items.Add(txtStudent.Text);
            txtStudent.Clear();
            txtStudent.Focus();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void txtStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Add();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            if (lbStudent.SelectedItems.Count == 0)
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
                //lbStudent.Items.Remove(lbStudent.SelectedItem);
                //lbStudent.Items.RemoveAt(lbStudent.SelectedIndex);
                for (int i = lbStudent.SelectedItems.Count - 1; i > -1; i--)
                {
                    lbStudent.Items.RemoveAt(lbStudent.SelectedIndices[i]);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            DialogResult confirm = MessageBox.Show("Are you sure you" +
                " want to clear all data?", "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.Yes)
            {
                lbStudent.Items.Clear();
            }
        }

        private void lbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbStudent.SelectedIndex != -1)
            {
                txtStudent.Text = lbStudent.Items[lbStudent.SelectedIndex].ToString();
                return;
            }
            txtStudent.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudent.Text))
            {
                MessageBox.Show("Please enter a name!",
                    "No data", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            lbStudent.Items[lbStudent.SelectedIndex] = txtStudent.Text;
        }
    }
}
