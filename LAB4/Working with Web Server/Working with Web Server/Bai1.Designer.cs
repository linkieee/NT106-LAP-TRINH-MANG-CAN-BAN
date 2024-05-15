namespace Working_with_Web_Server
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
            this.tbHTML = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbHTML
            // 
            this.tbHTML.Location = new System.Drawing.Point(16, 80);
            this.tbHTML.Name = "tbHTML";
            this.tbHTML.Size = new System.Drawing.Size(767, 357);
            this.tbHTML.TabIndex = 5;
            this.tbHTML.Text = "";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(668, 14);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(116, 38);
            this.btnGet.TabIndex = 4;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(16, 14);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(630, 39);
            this.tbURL.TabIndex = 3;
            this.tbURL.Text = "";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbHTML);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.tbURL);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbHTML;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RichTextBox tbURL;
    }
}