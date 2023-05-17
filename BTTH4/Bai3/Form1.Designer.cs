namespace Bai3
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
            txtN = new TextBox();
            btnShow = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 90);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập số n";
            // 
            // txtN
            // 
            txtN.Location = new Point(156, 82);
            txtN.Name = "txtN";
            txtN.Size = new Size(184, 23);
            txtN.TabIndex = 1;
            txtN.TextChanged += textBox1_TextChanged;
            txtN.Leave += txtN_Leave;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(405, 81);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 2;
            btnShow.Text = "Hiển thị";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 158);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 3;
            label2.Text = "Các số nguyên tố nhỏ hơn n: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 200);
            label3.Name = "label3";
            label3.Size = new Size(184, 15);
            label3.TabIndex = 4;
            label3.Text = "Các số chính phương nhỏ hơn n: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 244);
            label4.Name = "label4";
            label4.Size = new Size(169, 15);
            label4.TabIndex = 5;
            label4.Text = "Các số hoàn chỉnh nhỏ hơn n: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 592);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnShow);
            Controls.Add(txtN);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtN;
        private Button btnShow;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}