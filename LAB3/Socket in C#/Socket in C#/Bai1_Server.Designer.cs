namespace Socket_in_C_
{
    partial class Bai1_Server
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
            this.btnListen = new System.Windows.Forms.Button();
            this.receivedMessages = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(612, 46);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(125, 50);
            this.btnListen.TabIndex = 19;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // receivedMessages
            // 
            this.receivedMessages.Location = new System.Drawing.Point(71, 153);
            this.receivedMessages.Name = "receivedMessages";
            this.receivedMessages.Size = new System.Drawing.Size(666, 242);
            this.receivedMessages.TabIndex = 18;
            this.receivedMessages.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Received Messages";
            // 
            // portTextbox
            // 
            this.portTextbox.Location = new System.Drawing.Point(111, 58);
            this.portTextbox.Name = "portTextbox";
            this.portTextbox.Size = new System.Drawing.Size(154, 26);
            this.portTextbox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Port:";
            // 
            // Bai1_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.receivedMessages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Bai1_Server";
            this.Text = "Bai1_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.RichTextBox receivedMessages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTextbox;
        private System.Windows.Forms.Label label1;
    }
}