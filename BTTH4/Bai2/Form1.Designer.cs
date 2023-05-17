namespace Bai2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtA = new TextBox();
            button1 = new Button();
            label2 = new Label();
            txtB = new TextBox();
            button2 = new Button();
            btnSwap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 106);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "a = ";
            // 
            // txtA
            // 
            txtA.Location = new Point(171, 103);
            txtA.Name = "txtA";
            txtA.Size = new Size(48, 23);
            txtA.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(249, 148);
            button1.Name = "button1";
            button1.Size = new Size(75, 63);
            button1.TabIndex = 2;
            button1.Text = "Dừng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 152);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "b = ";
            // 
            // txtB
            // 
            txtB.Location = new Point(171, 149);
            txtB.Name = "txtB";
            txtB.Size = new Size(48, 23);
            txtB.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(249, 103);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnSwap
            // 
            btnSwap.Location = new Point(110, 188);
            btnSwap.Name = "btnSwap";
            btnSwap.Size = new Size(109, 23);
            btnSwap.TabIndex = 5;
            btnSwap.Text = "Hoán đổi";
            btnSwap.UseVisualStyleBackColor = true;
            btnSwap.Click += btnSwap_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 398);
            Controls.Add(btnSwap);
            Controls.Add(txtB);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtA);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtA;
        private Button button1;
        private Label label2;
        private TextBox txtB;
        private Button button2;
        private Button btnSwap;
    }
}