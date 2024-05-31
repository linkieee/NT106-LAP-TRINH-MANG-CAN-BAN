namespace SendReceivMail
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
            this.btSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMailfrom = new System.Windows.Forms.TextBox();
            this.tbMailto = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbSubj = new System.Windows.Forms.TextBox();
            this.rbBody = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(24, 31);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(121, 68);
            this.btSend.TabIndex = 0;
            this.btSend.Text = "SEND";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subject:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Body:";
            // 
            // tbMailfrom
            // 
            this.tbMailfrom.Location = new System.Drawing.Point(248, 31);
            this.tbMailfrom.Name = "tbMailfrom";
            this.tbMailfrom.Size = new System.Drawing.Size(276, 26);
            this.tbMailfrom.TabIndex = 6;
            // 
            // tbMailto
            // 
            this.tbMailto.Location = new System.Drawing.Point(248, 79);
            this.tbMailto.Name = "tbMailto";
            this.tbMailto.Size = new System.Drawing.Size(276, 26);
            this.tbMailto.TabIndex = 7;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(679, 31);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(286, 26);
            this.tbPass.TabIndex = 8;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // tbSubj
            // 
            this.tbSubj.Location = new System.Drawing.Point(93, 142);
            this.tbSubj.Multiline = true;
            this.tbSubj.Name = "tbSubj";
            this.tbSubj.Size = new System.Drawing.Size(872, 39);
            this.tbSubj.TabIndex = 9;
            // 
            // rbBody
            // 
            this.rbBody.Location = new System.Drawing.Point(93, 204);
            this.rbBody.Name = "rbBody";
            this.rbBody.Size = new System.Drawing.Size(872, 218);
            this.rbBody.TabIndex = 10;
            this.rbBody.Text = "";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.rbBody);
            this.Controls.Add(this.tbSubj);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbMailto);
            this.Controls.Add(this.tbMailfrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSend);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMailfrom;
        private System.Windows.Forms.TextBox tbMailto;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbSubj;
        private System.Windows.Forms.RichTextBox rbBody;
    }
}