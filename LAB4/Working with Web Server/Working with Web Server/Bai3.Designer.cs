namespace Working_with_Web_Server
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
            this.tbSaveFile = new System.Windows.Forms.RichTextBox();
            this.tbHTML = new System.Windows.Forms.RichTextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbSaveFile
            // 
            this.tbSaveFile.Location = new System.Drawing.Point(16, 67);
            this.tbSaveFile.Name = "tbSaveFile";
            this.tbSaveFile.Size = new System.Drawing.Size(630, 39);
            this.tbSaveFile.TabIndex = 13;
            this.tbSaveFile.Text = "";
            // 
            // tbHTML
            // 
            this.tbHTML.Location = new System.Drawing.Point(16, 121);
            this.tbHTML.Name = "tbHTML";
            this.tbHTML.Size = new System.Drawing.Size(767, 316);
            this.tbHTML.TabIndex = 12;
            this.tbHTML.Text = "";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(668, 14);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(116, 38);
            this.btnDownload.TabIndex = 11;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(16, 14);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(630, 39);
            this.tbURL.TabIndex = 10;
            this.tbURL.Text = "";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSaveFile);
            this.Controls.Add(this.tbHTML);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.tbURL);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbSaveFile;
        private System.Windows.Forms.RichTextBox tbHTML;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.RichTextBox tbURL;
    }
}