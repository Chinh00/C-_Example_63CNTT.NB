namespace Bai8
{
    partial class FindAndReplace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFind = new TextBox();
            button1 = new Button();
            txtReplace = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtFind
            // 
            txtFind.Location = new Point(73, 29);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(163, 23);
            txtFind.TabIndex = 0;
            txtFind.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(259, 29);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtReplace
            // 
            txtReplace.Location = new Point(73, 58);
            txtReplace.Name = "txtReplace";
            txtReplace.Size = new Size(163, 23);
            txtReplace.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(259, 62);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Replace";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 4;
            label1.Text = "Find";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 5;
            label2.Text = "Replace";
            // 
            // FindAndReplace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 139);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(txtReplace);
            Controls.Add(button1);
            Controls.Add(txtFind);
            Name = "FindAndReplace";
            Text = "FindAndReplace";
            Load += FindAndReplace_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFind;
        private Button button1;
        private TextBox txtReplace;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}