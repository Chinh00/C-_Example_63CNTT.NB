namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPass.Text = string.Empty;
            txtUser.Text = string.Empty;
            txtUser.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Login with username: {txtUser.Text} and password: {txtPass.Text}" + ((chkNho.Checked == true) ? " Bạn có ghi nhớ" : ""));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}