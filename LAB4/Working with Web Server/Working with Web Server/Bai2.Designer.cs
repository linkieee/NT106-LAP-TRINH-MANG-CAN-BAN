namespace Working_with_Web_Server
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
            this.tbHTML = new System.Windows.Forms.RichTextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.RichTextBox();
            this.tbData = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbHTML
            // 
            this.tbHTML.Location = new System.Drawing.Point(16, 121);
            this.tbHTML.Name = "tbHTML";
            this.tbHTML.Size = new System.Drawing.Size(767, 316);
            this.tbHTML.TabIndex = 8;
            this.tbHTML.Text = "";
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(668, 14);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(116, 38);
            this.btnPost.TabIndex = 7;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(16, 14);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(630, 39);
            this.tbURL.TabIndex = 6;
            this.tbURL.Text = "";
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(16, 67);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(630, 39);
            this.tbData.TabIndex = 9;
            this.tbData.Text = "";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbHTML);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.tbURL);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbHTML;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.RichTextBox tbURL;
        private System.Windows.Forms.RichTextBox tbData;
    }
}