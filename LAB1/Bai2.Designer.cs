namespace LAB1
{
    partial class Bai2
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
            label1 = new Label();
            sothunhat = new TextBox();
            sothuhai = new TextBox();
            label2 = new Label();
            sothuba = new TextBox();
            label3 = new Label();
            tim = new Button();
            xoa = new Button();
            thoat = new Button();
            label4 = new Label();
            solonnhat = new TextBox();
            sonhonhat = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 98);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 0;
            label1.Text = "Số thứ nhất";
            // 
            // sothunhat
            // 
            sothunhat.Location = new Point(227, 98);
            sothunhat.Name = "sothunhat";
            sothunhat.Size = new Size(188, 31);
            sothunhat.TabIndex = 1;
            // 
            // sothuhai
            // 
            sothuhai.Location = new Point(227, 189);
            sothuhai.Name = "sothuhai";
            sothuhai.Size = new Size(188, 31);
            sothuhai.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(80, 189);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 2;
            label2.Text = "Số thứ hai";
            // 
            // sothuba
            // 
            sothuba.Location = new Point(227, 295);
            sothuba.Name = "sothuba";
            sothuba.Size = new Size(188, 31);
            sothuba.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(80, 295);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 4;
            label3.Text = "Số thứ ba";
            // 
            // tim
            // 
            tim.Location = new Point(635, 136);
            tim.Name = "tim";
            tim.Size = new Size(109, 42);
            tim.TabIndex = 6;
            tim.Text = "Tìm";
            tim.UseVisualStyleBackColor = true;
            tim.Click += button1_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(635, 238);
            xoa.Name = "xoa";
            xoa.Size = new Size(109, 42);
            xoa.TabIndex = 7;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += button2_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(778, 25);
            thoat.Name = "thoat";
            thoat.Size = new Size(109, 42);
            thoat.TabIndex = 8;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(112, 394);
            label4.Name = "label4";
            label4.Size = new Size(137, 32);
            label4.TabIndex = 9;
            label4.Text = "Số lớn nhất";
            // 
            // solonnhat
            // 
            solonnhat.Location = new Point(272, 399);
            solonnhat.Name = "solonnhat";
            solonnhat.ReadOnly = true;
            solonnhat.Size = new Size(185, 31);
            solonnhat.TabIndex = 10;
            // 
            // sonhonhat
            // 
            sonhonhat.Location = new Point(635, 399);
            sonhonhat.Name = "sonhonhat";
            sonhonhat.ReadOnly = true;
            sonhonhat.Size = new Size(185, 31);
            sonhonhat.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(475, 394);
            label5.Name = "label5";
            label5.Size = new Size(145, 32);
            label5.TabIndex = 11;
            label5.Text = "Số nhỏ nhất";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(230, 11);
            label6.Name = "label6";
            label6.Size = new Size(490, 54);
            label6.TabIndex = 13;
            label6.Text = "TÌM SỐ LỚN/NHỎ NHẤT";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 498);
            Controls.Add(label6);
            Controls.Add(sonhonhat);
            Controls.Add(label5);
            Controls.Add(solonnhat);
            Controls.Add(label4);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(tim);
            Controls.Add(sothuba);
            Controls.Add(label3);
            Controls.Add(sothuhai);
            Controls.Add(label2);
            Controls.Add(sothunhat);
            Controls.Add(label1);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox sothunhat;
        private TextBox sothuhai;
        private Label label2;
        private TextBox sothuba;
        private Label label3;
        private Button tim;
        private Button xoa;
        private Button thoat;
        private Label label4;
        private TextBox solonnhat;
        private TextBox sonhonhat;
        private Label label5;
        private Label label6;
    }
}