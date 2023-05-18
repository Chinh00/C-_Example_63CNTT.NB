namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(textBox1.Text);
                var b = Convert.ToDouble(textBox2.Text);
                var c = Convert.ToDouble(textBox3.Text);

                var dental = (Math.Pow(b, 2) - 4 * a * c);

                if (dental < 0) throw new Exception("Phương trình vô nghiệm");
                label3.Text += " " + (-b + Math.Sqrt(dental)) / 2 * a + (dental > 0 ? " và" + (-b - Math.Sqrt(dental)) / 2 * a : "");


            }
            catch (FormatException ex)
            {
                MessageBox.Show("Vui lòng nhập số");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            this.BackColor = colorDialog.Color;

        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            this.Font = fontDialog.Font;


        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MenuStrip menuStrip = new MenuStrip();
                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
                toolStripMenuItem.Text = "Change font";
                menuStrip.Items.Add(toolStripMenuItem);
                menuStrip.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}