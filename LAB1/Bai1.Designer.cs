namespace LAB1
{
    partial class Bai1
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
            label2 = new Label();
            label3 = new Label();
            sothunhat = new TextBox();
            sothuhai = new TextBox();
            tinhTong = new Button();
            ketqua = new TextBox();
            xoa = new Button();
            thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(156, 88);
            label1.Name = "label1";
            label1.Size = new Size(120, 37);
            label1.TabIndex = 0;
            label1.Text = "Số thứ 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(156, 180);
            label2.Name = "label2";
            label2.Size = new Size(126, 37);
            label2.TabIndex = 1;
            label2.Text = "Số thứ 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(166, 349);
            label3.Name = "label3";
            label3.Size = new Size(115, 37);
            label3.TabIndex = 2;
            label3.Text = "Kết quả";
            // 
            // sothunhat
            // 
            sothunhat.Location = new Point(335, 95);
            sothunhat.Name = "sothunhat";
            sothunhat.Size = new Size(306, 31);
            sothunhat.TabIndex = 3;
            // 
            // sothuhai
            // 
            sothuhai.Location = new Point(335, 190);
            sothuhai.Name = "sothuhai";
            sothuhai.Size = new Size(306, 31);
            sothuhai.TabIndex = 4;
            // 
            // tinhTong
            // 
            tinhTong.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tinhTong.Location = new Point(413, 258);
            tinhTong.Name = "tinhTong";
            tinhTong.Size = new Size(144, 66);
            tinhTong.TabIndex = 5;
            tinhTong.Text = "Tính tổng";
            tinhTong.UseVisualStyleBackColor = true;
            tinhTong.Click += button1_Click;
            // 
            // ketqua
            // 
            ketqua.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ketqua.Location = new Point(335, 359);
            ketqua.Name = "ketqua";
            ketqua.ReadOnly = true;
            ketqua.Size = new Size(306, 31);
            ketqua.TabIndex = 6;
            // 
            // xoa
            // 
            xoa.Location = new Point(680, 130);
            xoa.Name = "xoa";
            xoa.Size = new Size(87, 52);
            xoa.TabIndex = 7;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += button2_Click;
            // 
            // thoat
            // 
            thoat.ForeColor = Color.Red;
            thoat.Location = new Point(691, 11);
            thoat.Name = "thoat";
            thoat.Size = new Size(98, 38);
            thoat.TabIndex = 8;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += button3_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(ketqua);
            Controls.Add(tinhTong);
            Controls.Add(sothuhai);
            Controls.Add(sothunhat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox sothunhat;
        private TextBox sothuhai;
        private Button tinhTong;
        private TextBox ketqua;
        private Button xoa;
        private Button thoat;
    }
}