using System.CodeDom;
using System.Globalization;

namespace Bai9
{
    public partial class Form1 : Form
    {
        private LinkedList<Staff> staffs = new LinkedList<Staff>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.Hide();

            DateTimePicker dateTimePicker = new DateTimePicker();

            dateTimePicker.Value = DateTime.Now;
            staffs.AddLast(new Staff()
            {
                id = 0,
                name = "abc",
                date = dateTimePicker,
                address = "abc",
                phone = "abc",
            });
            staffs.AddLast(new Staff()
            {
                id = 1,
                name = "abcdkfhsdu",
                date = dateTimePicker,
                address = "abcsd sd",
                phone = "sdfsdf",
            });

            foreach (Staff staff in staffs)
            {
                ListViewItem item = new ListViewItem(new string[] { staff.name, staff.date.Value.ToString(), staff.address, staff.phone });

                listView1.Items.Add(item);


            }

        }

        private bool check()
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
            else
            {
                staffs.AddLast(new Staff()
                {
                    id = staffs.Count + 1,
                    name = textBox1.Text,
                    date = dateTimePicker1,
                    address = textBox2.Text,
                    phone = textBox3.Text,
                });
                listView1.Items.Clear();
                foreach (Staff staff in staffs)
                {
                    ListViewItem item = new ListViewItem(new string[] { staff.name, staff.date.Value.ToString(), staff.address, staff.phone });

                    listView1.Items.Add(item);


                }
                MessageBox.Show("Thêm thành công");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;


            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                var rectangle = listView1.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    var staff = staffs.ElementAt(i);
                    textBox4.Text = staff.id.ToString();
                    textBox1.Text = staff.name.ToString();
                    dateTimePicker1 = staff.date;
                    textBox2.Text = staff.address.ToString();
                    textBox3.Text = staff.phone.ToString();



                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != string.Empty)
            {
                var id = Convert.ToInt32(textBox4.Text);
                if (staffs.Remove(staffs.Where(e => e.id == id).FirstOrDefault()))
                {
                    listView1.Items.Clear();
                    foreach (Staff staff in staffs)
                    {
                        ListViewItem item = new ListViewItem(new string[] { staff.name, staff.date.Value.ToString(), staff.address, staff.phone });

                        listView1.Items.Add(item);


                    }
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;
                    MessageBox.Show("Remove successfully");
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
            else
            {
                MessageBox.Show("Chọn nhân viên cần xóa");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != string.Empty)
            {
                var id = Convert.ToInt32(textBox4.Text);
                var _s = staffs.Where(e => e.id == id).FirstOrDefault();
                if (_s != null) {
                    _s.name = textBox1.Text;
                    _s.address = textBox2.Text;
                    _s.phone = textBox3.Text;
                    _s.date = dateTimePicker1;
                }

                listView1.Items.Clear();
                foreach (Staff staff in staffs)
                {
                    ListViewItem item = new ListViewItem(new string[] { staff.name, staff.date.Value.ToString(), staff.address, staff.phone });

                    listView1.Items.Add(item);


                }
                MessageBox.Show("Sửa thành công");

                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Chọn nhân viên cần xóa");
            }
        }
    }
}