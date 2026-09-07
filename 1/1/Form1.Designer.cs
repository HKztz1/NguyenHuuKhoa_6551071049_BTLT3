namespace _1
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
            txtPassword1 = new TextBox();
            label2 = new Label();
            txtPassword2 = new TextBox();
            button2 = new Button();
            button4 = new Button();
            lblHienThi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(159, 82);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(153, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập Password: ";
            label1.Click += label1_Click;
            // 
            // txtPassword1
            // 
            txtPassword1.Location = new Point(329, 82);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.PasswordChar = '#';
            txtPassword1.Size = new Size(150, 31);
            txtPassword1.TabIndex = 2;
            txtPassword1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(221, 127);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(90, 25);
            label2.TabIndex = 3;
            label2.Text = "Hiển thị: ";
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(329, 127);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(150, 31);
            txtPassword2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(343, 192);
            button2.Name = "button2";
            button2.Size = new Size(107, 38);
            button2.TabIndex = 5;
            button2.Text = "Tiếp";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(489, 192);
            button4.Name = "button4";
            button4.Size = new Size(107, 38);
            button4.TabIndex = 7;
            button4.Text = "Đóng";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // lblHienThi
            // 
            lblHienThi.Location = new Point(196, 192);
            lblHienThi.Name = "lblHienThi";
            lblHienThi.Size = new Size(107, 38);
            lblHienThi.TabIndex = 8;
            lblHienThi.Text = "Hiển thị";
            lblHienThi.UseVisualStyleBackColor = true;
            lblHienThi.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 450);
            Controls.Add(lblHienThi);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(txtPassword2);
            Controls.Add(label2);
            Controls.Add(txtPassword1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword1;
        private Label label2;
        private TextBox txtPassword2;
        private Button button2;
        private Button button4;
        private Button lblHienThi;
    }
}
