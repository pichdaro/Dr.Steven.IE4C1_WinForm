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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userPreferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction!", "Coming soon",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App version: 1.0\n" +
                "Developer: NoBody@All\n" +
                "Company: You cn't find me!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStartUp startup = new frmStartUp();
            startup.MdiParent = this;
            startup.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tsDate.Text = MyConfig.activeUser.Username;
            if (MyConfig.activeUser.Role == UserRoles.SuperAdmin)
            {

            }
            else if (MyConfig.activeUser.Role == UserRoles.Admin)
            {
                userManagerToolStripMenuItem.Enabled = false;
            }
            else
            {
                userManagerToolStripMenuItem.Enabled = false;
            }

        }

        private void listBoxStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBoxV1 lbStu = new frmListBoxV1();
            lbStu.MdiParent = this;
            lbStu.Show();
        }

        private void listBoxStudentV1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBoxV2 lbStu = new frmListBoxV2();
            lbStu.MdiParent = this;
            lbStu.Show();
        }

        private void listViewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListView lvStu = new frmListView();
            lvStu.MdiParent = this;
            lvStu.Show();
        }

        private void userManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyConfig.activeUser.Role != UserRoles.SuperAdmin)
            {
                MessageBox.Show("You don't have permission to use " +
                    "this function!", "Access Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frmUser userManager = new frmUser();
            userManager.MdiParent = this;
            userManager.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPassword pwd = new frmPassword();
            pwd.ShowDialog();
        }

        private void changToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAvata avata = new frmAvata();
            avata.StartPosition = FormStartPosition.CenterScreen;
            avata.ShowDialog();
        }
    }
}
