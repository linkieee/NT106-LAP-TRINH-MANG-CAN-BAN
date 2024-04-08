namespace FileAndStreamIO
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
            this.btnRead = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.RichTextBox();
            this.fileName = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.Label();
            this.tbWordCount = new System.Windows.Forms.TextBox();
            this.wordCount = new System.Windows.Forms.Label();
            this.tbLineCount = new System.Windows.Forms.TextBox();
            this.lineCount = new System.Windows.Forms.Label();
            this.tbCharCount = new System.Windows.Forms.TextBox();
            this.charCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(90, 26);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(191, 77);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Đọc file";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(380, 51);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(394, 377);
            this.tbFile.TabIndex = 1;
            this.tbFile.Text = "";
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(24, 131);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(60, 20);
            this.fileName.TabIndex = 2;
            this.fileName.Text = "Tên file";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(124, 125);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(217, 26);
            this.tbFileName.TabIndex = 3;
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(124, 191);
            this.tbURL.Name = "tbURL";
            this.tbURL.ReadOnly = true;
            this.tbURL.Size = new System.Drawing.Size(217, 26);
            this.tbURL.TabIndex = 5;
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.Location = new System.Drawing.Point(24, 197);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(29, 20);
            this.url.TabIndex = 4;
            this.url.Text = "Url";
            // 
            // tbWordCount
            // 
            this.tbWordCount.Location = new System.Drawing.Point(124, 327);
            this.tbWordCount.Name = "tbWordCount";
            this.tbWordCount.ReadOnly = true;
            this.tbWordCount.Size = new System.Drawing.Size(217, 26);
            this.tbWordCount.TabIndex = 9;
            // 
            // wordCount
            // 
            this.wordCount.AutoSize = true;
            this.wordCount.Location = new System.Drawing.Point(24, 333);
            this.wordCount.Name = "wordCount";
            this.wordCount.Size = new System.Drawing.Size(47, 20);
            this.wordCount.TabIndex = 8;
            this.wordCount.Text = "Số từ";
            // 
            // tbLineCount
            // 
            this.tbLineCount.Location = new System.Drawing.Point(124, 261);
            this.tbLineCount.Name = "tbLineCount";
            this.tbLineCount.ReadOnly = true;
            this.tbLineCount.Size = new System.Drawing.Size(217, 26);
            this.tbLineCount.TabIndex = 7;
            // 
            // lineCount
            // 
            this.lineCount.AutoSize = true;
            this.lineCount.Location = new System.Drawing.Point(24, 267);
            this.lineCount.Name = "lineCount";
            this.lineCount.Size = new System.Drawing.Size(69, 20);
            this.lineCount.TabIndex = 6;
            this.lineCount.Text = "Số dòng";
            // 
            // tbCharCount
            // 
            this.tbCharCount.Location = new System.Drawing.Point(124, 391);
            this.tbCharCount.Name = "tbCharCount";
            this.tbCharCount.ReadOnly = true;
            this.tbCharCount.Size = new System.Drawing.Size(217, 26);
            this.tbCharCount.TabIndex = 11;
            // 
            // charCount
            // 
            this.charCount.AutoSize = true;
            this.charCount.Location = new System.Drawing.Point(24, 397);
            this.charCount.Name = "charCount";
            this.charCount.Size = new System.Drawing.Size(62, 20);
            this.charCount.TabIndex = 10;
            this.charCount.Text = "Số kí tự";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCharCount);
            this.Controls.Add(this.charCount);
            this.Controls.Add(this.tbWordCount);
            this.Controls.Add(this.wordCount);
            this.Controls.Add(this.tbLineCount);
            this.Controls.Add(this.lineCount);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.url);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.btnRead);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.RichTextBox tbFile;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label url;
        private System.Windows.Forms.TextBox tbWordCount;
        private System.Windows.Forms.Label wordCount;
        private System.Windows.Forms.TextBox tbLineCount;
        private System.Windows.Forms.Label lineCount;
        private System.Windows.Forms.TextBox tbCharCount;
        private System.Windows.Forms.Label charCount;
    }
}