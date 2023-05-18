namespace Bai8
{
    public partial class Form1 : Form
    {
        private string cache = "";
        private string pathFile = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            pathFile = fileDialog.FileName; 
            var text = File.ReadAllText(fileDialog.FileName);
            richTextBox1.Text = text;

        }

        private void savaFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (pathFile == "") {
                saveFileDialog.ShowDialog();
            }

            using (StreamWriter streamWriter = new StreamWriter(pathFile))
            {
                streamWriter.Write(richTextBox1.Text);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cache = richTextBox1.SelectedText;

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            cache = richTextBox1.SelectedText;
            richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.SelectionStart) + richTextBox1.Text.Substring(richTextBox1.SelectionStart + richTextBox1.SelectedText.Length);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = richTextBox1.Text.Insert(richTextBox1.SelectionStart, cache);
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindAndReplace findAndReplace = new FindAndReplace(richTextBox1, this);
            findAndReplace.Show();

        }

        private void upperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.SelectionStart) + richTextBox1.SelectedText.ToUpper() + richTextBox1.Text.Substring(richTextBox1.SelectionStart + richTextBox1.SelectedText.Length);


        }

        private void changeBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void lowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.SelectionStart) + richTextBox1.SelectedText.ToLower() + richTextBox1.Text.Substring(richTextBox1.SelectionStart + richTextBox1.SelectedText.Length);
        }
    }
}