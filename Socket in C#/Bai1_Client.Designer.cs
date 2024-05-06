namespace Socket_in_C_
{
    partial class Bai1_Client
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
            this.messageTextbox = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ipConnect = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageTextbox
            // 
            this.messageTextbox.Location = new System.Drawing.Point(140, 124);
            this.messageTextbox.Name = "messageTextbox";
            this.messageTextbox.Size = new System.Drawing.Size(594, 239);
            this.messageTextbox.TabIndex = 35;
            this.messageTextbox.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(367, 382);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(128, 31);
            this.btnSend.TabIndex = 34;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Message";
            // 
            // ipConnect
            // 
            this.ipConnect.Location = new System.Drawing.Point(188, 43);
            this.ipConnect.Name = "ipConnect";
            this.ipConnect.Size = new System.Drawing.Size(260, 26);
            this.ipConnect.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "IP Remote Host:";
            // 
            // portTextbox
            // 
            this.portTextbox.Location = new System.Drawing.Point(605, 46);
            this.portTextbox.Name = "portTextbox";
            this.portTextbox.Size = new System.Drawing.Size(131, 26);
            this.portTextbox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Port:";
            // 
            // Bai1_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.messageTextbox);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ipConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Bai1_Client";
            this.Text = "Bai1_Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox messageTextbox;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ipConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTextbox;
        private System.Windows.Forms.Label label1;
    }
}