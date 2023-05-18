using System.Data;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtInp.Text += ((Button)sender).Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtInp.Text += ((Button)sender).Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtInp.Text += ((Button)sender).Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtInp.Text += ((Button)sender).Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtInp.Text += ((Button)sender).Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtInp.Text += ((Button)sender).Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtInp.Text += ((Button)sender).Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtInp.Text += ((Button)sender).Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtInp.Text += ((Button)sender).Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtInp.Text += ((Button)sender).Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtInp.Text += ((Button)sender).Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtInp.Text += ((Button)sender).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtInp.Text += "";
            textBox1.Text = string.Empty;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtInp.Text += ((Button)sender).Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = (new DataTable().Compute($"{txtInp.Text}", null)).ToString();   
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtInp.Text += ((Button)sender).Text;
        }
    }
}