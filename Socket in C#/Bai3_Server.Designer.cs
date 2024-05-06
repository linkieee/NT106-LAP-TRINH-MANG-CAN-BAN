namespace Socket_in_C_
{
    partial class Bai3_Server
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
            this.receivedMessage = new System.Windows.Forms.RichTextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // receivedMessage
            // 
            this.receivedMessage.Location = new System.Drawing.Point(48, 106);
            this.receivedMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.receivedMessage.Name = "receivedMessage";
            this.receivedMessage.Size = new System.Drawing.Size(710, 303);
            this.receivedMessage.TabIndex = 6;
            this.receivedMessage.Text = "";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(555, 33);
            this.btnListen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(203, 52);
            this.btnListen.TabIndex = 5;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // Bai3_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receivedMessage);
            this.Controls.Add(this.btnListen);
            this.Name = "Bai3_Server";
            this.Text = "Bai3_Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox receivedMessage;
        private System.Windows.Forms.Button btnListen;
    }
}