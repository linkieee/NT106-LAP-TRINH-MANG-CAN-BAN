namespace LAB1
{
    partial class Bai3
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
            socandoc = new TextBox();
            doc = new Button();
            xoa = new Button();
            label2 = new Label();
            ketqua = new TextBox();
            thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(132, 131);
            label1.Name = "label1";
            label1.Size = new Size(353, 32);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào số nguyên từ 0 đến 9";
            // 
            // socandoc
            // 
            socandoc.Location = new Point(502, 131);
            socandoc.Name = "socandoc";
            socandoc.Size = new Size(127, 31);
            socandoc.TabIndex = 1;
            // 
            // doc
            // 
            doc.Location = new Point(191, 241);
            doc.Name = "doc";
            doc.Size = new Size(136, 38);
            doc.TabIndex = 2;
            doc.Text = "Đọc";
            doc.UseVisualStyleBackColor = true;
            doc.Click += button1_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(470, 241);
            xoa.Name = "xoa";
            xoa.Size = new Size(136, 38);
            xoa.TabIndex = 3;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(148, 348);
            label2.Name = "label2";
            label2.Size = new Size(96, 32);
            label2.TabIndex = 4;
            label2.Text = "Kết quả";
            // 
            // ketqua
            // 
            ketqua.Location = new Point(250, 348);
            ketqua.Name = "ketqua";
            ketqua.ReadOnly = true;
            ketqua.Size = new Size(335, 31);
            ketqua.TabIndex = 5;
            // 
            // thoat
            // 
            thoat.Location = new Point(652, 12);
            thoat.Name = "thoat";
            thoat.Size = new Size(136, 38);
            thoat.TabIndex = 6;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += button3_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(thoat);
            Controls.Add(ketqua);
            Controls.Add(label2);
            Controls.Add(xoa);
            Controls.Add(doc);
            Controls.Add(socandoc);
            Controls.Add(label1);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox socandoc;
        private Button doc;
        private Button xoa;
        private Label label2;
        private TextBox ketqua;
        private Button thoat;
    }
}