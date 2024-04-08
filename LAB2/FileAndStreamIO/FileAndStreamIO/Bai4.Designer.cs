namespace FileAndStreamIO
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
            this.mssv = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.tbVan = new System.Windows.Forms.TextBox();
            this.van = new System.Windows.Forms.Label();
            this.tbMath = new System.Windows.Forms.TextBox();
            this.math = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.tbMSSV = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbDSSV = new System.Windows.Forms.ListBox();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mssv
            // 
            this.mssv.AutoSize = true;
            this.mssv.Location = new System.Drawing.Point(47, 54);
            this.mssv.Name = "mssv";
            this.mssv.Size = new System.Drawing.Size(59, 20);
            this.mssv.TabIndex = 0;
            this.mssv.Text = "MSSV:";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.tbVan);
            this.gbInfo.Controls.Add(this.van);
            this.gbInfo.Controls.Add(this.tbMath);
            this.gbInfo.Controls.Add(this.math);
            this.gbInfo.Controls.Add(this.tbSDT);
            this.gbInfo.Controls.Add(this.phone);
            this.gbInfo.Controls.Add(this.tbName);
            this.gbInfo.Controls.Add(this.name);
            this.gbInfo.Controls.Add(this.tbMSSV);
            this.gbInfo.Controls.Add(this.mssv);
            this.gbInfo.Location = new System.Drawing.Point(247, 15);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(730, 256);
            this.gbInfo.TabIndex = 1;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin";
            // 
            // tbVan
            // 
            this.tbVan.Location = new System.Drawing.Point(477, 116);
            this.tbVan.Name = "tbVan";
            this.tbVan.Size = new System.Drawing.Size(219, 26);
            this.tbVan.TabIndex = 9;
            // 
            // van
            // 
            this.van.AutoSize = true;
            this.van.Location = new System.Drawing.Point(381, 116);
            this.van.Name = "van";
            this.van.Size = new System.Drawing.Size(83, 20);
            this.van.TabIndex = 8;
            this.van.Text = "Điểm Văn:";
            // 
            // tbMath
            // 
            this.tbMath.Location = new System.Drawing.Point(477, 54);
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(219, 26);
            this.tbMath.TabIndex = 7;
            // 
            // math
            // 
            this.math.AutoSize = true;
            this.math.Location = new System.Drawing.Point(381, 58);
            this.math.Name = "math";
            this.math.Size = new System.Drawing.Size(90, 20);
            this.math.TabIndex = 6;
            this.math.Text = "Điểm Toán:";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(112, 174);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(219, 26);
            this.tbSDT.TabIndex = 5;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(47, 177);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(45, 20);
            this.phone.TabIndex = 4;
            this.phone.Text = "SĐT:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(112, 111);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(219, 26);
            this.tbName.TabIndex = 3;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(47, 112);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(61, 20);
            this.name.TabIndex = 2;
            this.name.Text = "Họ tên:";
            // 
            // tbMSSV
            // 
            this.tbMSSV.Location = new System.Drawing.Point(112, 52);
            this.tbMSSV.Name = "tbMSSV";
            this.tbMSSV.Size = new System.Drawing.Size(219, 26);
            this.tbMSSV.TabIndex = 1;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(23, 174);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(199, 90);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Đọc file";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(23, 25);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(199, 90);
            this.btnWrite.TabIndex = 4;
            this.btnWrite.Text = "Ghi file";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 329);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 90);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(23, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 90);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu File";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lbDSSV
            // 
            this.lbDSSV.FormattingEnabled = true;
            this.lbDSSV.ItemHeight = 20;
            this.lbDSSV.Location = new System.Drawing.Point(254, 313);
            this.lbDSSV.Name = "lbDSSV";
            this.lbDSSV.Size = new System.Drawing.Size(722, 244);
            this.lbDSSV.TabIndex = 7;
            // 
            // Bai4
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 594);
            this.Controls.Add(this.lbDSSV);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.gbInfo);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mssv;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox tbMSSV;
        private System.Windows.Forms.TextBox tbVan;
        private System.Windows.Forms.Label van;
        private System.Windows.Forms.TextBox tbMath;
        private System.Windows.Forms.Label math;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lbDSSV;
    }
}