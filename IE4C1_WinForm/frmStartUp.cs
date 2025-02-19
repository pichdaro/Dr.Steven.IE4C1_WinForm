namespace IE4C1_WinForm
{
    public partial class frmStartUp : Form
    {
        public frmStartUp()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, world!", "Welcome",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, " + txtYourName.Text,
                "Welcome",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void btnClickMe_MouseHover(object sender, EventArgs e)
        {
            btnClickMe.ForeColor = Color.Red;
        }
        private void btnClickMe_MouseLeave(object sender, EventArgs e)
        {
            btnClickMe.ForeColor = Color.Black;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }
    }
}
