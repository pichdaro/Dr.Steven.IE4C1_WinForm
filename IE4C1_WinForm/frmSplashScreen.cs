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
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }
        int duration = 0;
        int max;
        int loadingTime = 2000; // in milliesecond
        int Interval = 10; // in millisecond

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = Interval;
            max = loadingTime / Interval;
            progressBar1.Maximum = max;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            duration += 1;
            if (duration > max)
            {
                this.Close();
                return;
            }
            progressBar1.Value = duration;
            label1.Text = ((duration * 1000 / loadingTime)).ToString() +
                "%";
        }
    }
}
