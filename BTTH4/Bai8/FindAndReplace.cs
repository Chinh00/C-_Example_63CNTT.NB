using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class FindAndReplace : Form
    {
        private RichTextBox richText;
        private Form1 _Form1;
        private int _curr_index = -1;
        public FindAndReplace(RichTextBox richTextBox, Form1 form1)
        {
            InitializeComponent();
            richText = richTextBox;
            _Form1 = form1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                richText.SelectionStart = richText.Text.IndexOf(txtFind.Text, _curr_index + 1);
                _curr_index = richText.Text.IndexOf(txtFind.Text, _curr_index + 1);
                richText.SelectionLength = txtFind.Text.Length;
                _Form1.Focus();
            }
            catch
            {
                _curr_index = -1;
            }


        }

        private void FindAndReplace_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richText.Text = richText.Text.Replace(txtFind.Text, txtReplace.Text);
            _Form1.Focus();
        }
    }
}
