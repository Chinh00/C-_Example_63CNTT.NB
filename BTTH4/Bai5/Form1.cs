namespace Bai5
{
    public partial class Form1 : Form
    {
        public List<Computer> ComputerList = new List<Computer>();
        public Form1()
        {
            InitializeComponent();


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                ComputerList.Add(new Computer()
                {
                    id = i,
                    status = "Trống",
                    current_time = 0
                });
            }
            dataGridView1.DataSource = ComputerList;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int maMay = dataGridView1.CurrentRow.Index;
            var data = ComputerList.Where(e => e.id == maMay).FirstOrDefault();
            textBox1.Text = data.id.ToString();
            textBox2.Text = data.status.ToString();
            textBox3.Text = data.current_time.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        public async Task start(Computer computer)
        {
            while (true)
            {

                computer.current_time += 1;
                Thread.Sleep(2000);
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Trống")
            {
                var check = MessageBox.Show("Xác nhận đặt máy", "Confirm", MessageBoxButtons.YesNo);
                if (check == DialogResult.Yes)
                {
                    MessageBox.Show("Đặt máy thành công");
                    Computer data = ComputerList.Where(e => e.id == (Convert.ToInt32(textBox1.Text))).FirstOrDefault();
                    data.status = "Đang sử dụng";
                    dataGridView1.DataSource = ComputerList;

                    Task.Run(() =>
                    {
                        while (true)
                        {
                            data.current_time += 1;
                            dataGridView1.DataSource = ComputerList;
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                        }
                    });
                }
            }
            else
            {
                MessageBox.Show("Máy đang được sử dụng");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Đang sử dụng") {
                MessageBox.Show($"Máy {textBox1.Text} thanh toán {textBox3.Text} giờ sử dụng tổng {5000 * Convert.ToInt32(textBox3.Text)}");
            }
        }
    }
}