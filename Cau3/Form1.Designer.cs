namespace Cau3
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
            txtHo = new TextBox();
            txtTen = new TextBox();
            label2 = new Label();
            btnHo = new Button();
            button2 = new Button();
            btnHoTen = new Button();
            lblHoTen = new Button();
            btnKetThuc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 158);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Ho Lot";
            label1.Click += label1_Click;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(294, 155);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(243, 27);
            txtHo.TabIndex = 1;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(294, 212);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(243, 27);
            txtTen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 219);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 2;
            label2.Text = "Ten";
            // 
            // btnHo
            // 
            btnHo.Location = new Point(154, 309);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(80, 44);
            btnHo.TabIndex = 4;
            btnHo.Text = "Ho Lot";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(327, 309);
            button2.Name = "button2";
            button2.Size = new Size(80, 44);
            button2.TabIndex = 5;
            button2.Text = "Ten";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(524, 309);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(105, 44);
            btnHoTen.TabIndex = 6;
            btnHoTen.Text = "Ho va ten";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += button3_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = SystemColors.ActiveCaption;
            lblHoTen.Location = new Point(1, 1);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(798, 135);
            lblHoTen.TabIndex = 7;
            lblHoTen.UseVisualStyleBackColor = false;
            lblHoTen.Click += button4_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(327, 394);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(80, 44);
            btnKetThuc.TabIndex = 8;
            btnKetThuc.Text = "Thoat Chuong Trinh";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKetThuc);
            Controls.Add(lblHoTen);
            Controls.Add(btnHoTen);
            Controls.Add(button2);
            Controls.Add(btnHo);
            Controls.Add(txtTen);
            Controls.Add(label2);
            Controls.Add(txtHo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bai Tap Ho Ten";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHo;
        private TextBox txtTen;
        private Label label2;
        private Button btnHo;
        private Button button2;
        private Button btnHoTen;
        private Button lblHoTen;
        private Button btnKetThuc;
    }
}
