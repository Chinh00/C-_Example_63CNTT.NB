namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            HoanDoi hoanDoi = new HoanDoi(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text));
            hoanDoi.HoanVi();
            txtA.Text = hoanDoi.a.ToString();
            txtB.Text = hoanDoi.b.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtA .Text = txtB.Text = string.Empty;
            txtA.Focus();
        }
    }
}