namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtN.Text != "")
            {
                try
                {
                    var n = Convert.ToInt32(txtN.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Vui lòng nhập số");
                    txtN.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void txtN_Leave(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(txtN.Text);

            if (n <= 0 || n >= 1000) MessageBox.Show("Số vừa nhập không nằm trong khoảng cho phép");

        }

        private static bool checkPrime(int n)
        {
            for (int j = 2; j <= Math.Sqrt(n); ++j)
            {
                if (n % j == 0) return false;
            }
            return true;
        }
        private static bool checkCp(int n)
        {
            if (Math.Pow(Convert.ToInt32(Math.Sqrt(n)), 2) == n) return true;
            return false;
        }
        private static bool checkHp(int n) {
            int sum = 1;
            for (int i = 2; i < n; i++) {
                if (n % i == 0) {
                    sum += i;
                }
            }
            return sum == n;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(txtN.Text);
            for (int i = 2; i < n; i++)
            {
                if (checkPrime(i))
                {
                    label2.Text += i.ToString() + ((i < n - 1) ? " - " : "");
                }
                if (checkCp(i))
                {
                    label3.Text += i.ToString() + ((i < n) ? " - " : "");
                }
                if (checkHp(i))
                {
                    label4.Text += i.ToString() + ((i < n) ? " - " : "");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}