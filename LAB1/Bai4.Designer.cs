namespace LAB1
{
    partial class Bai4
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
            socandoc = new TextBox();
            label4 = new Label();
            thuchien = new Button();
            label5 = new Label();
            ketqua = new TextBox();
            kieuhientai = new ComboBox();
            kieumuonchuyen = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(366, 66);
            label1.Name = "label1";
            label1.Size = new Size(223, 38);
            label1.TabIndex = 0;
            label1.Text = "CHUYỂN ĐỔI SỐ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 162);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 1;
            label2.Text = "Nhập một số:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 224);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "Chọn:";
            // 
            // socandoc
            // 
            socandoc.Location = new Point(216, 157);
            socandoc.Name = "socandoc";
            socandoc.Size = new Size(529, 31);
            socandoc.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(456, 224);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 6;
            label4.Text = "Sang";
            // 
            // thuchien
            // 
            thuchien.Location = new Point(215, 280);
            thuchien.Name = "thuchien";
            thuchien.Size = new Size(530, 34);
            thuchien.TabIndex = 7;
            thuchien.Text = "Thực hiện";
            thuchien.UseVisualStyleBackColor = true;
            thuchien.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 369);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 8;
            label5.Text = "Kết quả:";
            // 
            // ketqua
            // 
            ketqua.Location = new Point(215, 369);
            ketqua.Name = "ketqua";
            ketqua.ReadOnly = true;
            ketqua.Size = new Size(530, 31);
            ketqua.TabIndex = 9;
            // 
            // kieuhientai
            // 
            kieuhientai.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            kieuhientai.AutoCompleteSource = AutoCompleteSource.ListItems;
            kieuhientai.FormattingEnabled = true;
            kieuhientai.Items.AddRange(new object[] { "Decimal", "Binary", "Hexadecimal" });
            kieuhientai.Location = new Point(215, 221);
            kieuhientai.Name = "kieuhientai";
            kieuhientai.Size = new Size(221, 33);
            kieuhientai.TabIndex = 10;
            kieuhientai.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // kieumuonchuyen
            // 
            kieumuonchuyen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            kieumuonchuyen.AutoCompleteSource = AutoCompleteSource.ListItems;
            kieumuonchuyen.FormattingEnabled = true;
            kieumuonchuyen.Items.AddRange(new object[] { "Decimal", "Binary", "Hexadecimal" });
            kieumuonchuyen.Location = new Point(524, 221);
            kieumuonchuyen.Name = "kieumuonchuyen";
            kieumuonchuyen.Size = new Size(221, 33);
            kieumuonchuyen.TabIndex = 11;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 520);
            Controls.Add(kieumuonchuyen);
            Controls.Add(kieuhientai);
            Controls.Add(ketqua);
            Controls.Add(label5);
            Controls.Add(thuchien);
            Controls.Add(label4);
            Controls.Add(socandoc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai4";
            Text = "Bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox socandoc;
        private Label label4;
        private Button thuchien;
        private Label label5;
        private TextBox ketqua;
        private ComboBox kieuhientai;
        private ComboBox kieumuonchuyen;
    }
}