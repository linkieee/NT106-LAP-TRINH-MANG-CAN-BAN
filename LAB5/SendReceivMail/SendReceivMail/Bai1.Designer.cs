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
            this.tbMailfr = new System.Windows.Forms.TextBox();
            this.tbMailto = new System.Windows.Forms.TextBox();
            this.tbSubj = new System.Windows.Forms.TextBox();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(27, 32);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(120, 65);
            this.btSend.TabIndex = 0;
            this.btSend.Text = "SEND";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Body:";
            // 
            // tbMailfr
            // 
            this.tbMailfr.Location = new System.Drawing.Point(259, 28);
            this.tbMailfr.Multiline = true;
            this.tbMailfr.Name = "tbMailfr";
            this.tbMailfr.Size = new System.Drawing.Size(310, 35);
            this.tbMailfr.TabIndex = 5;
            // 
            // tbMailto
            // 
            this.tbMailto.Location = new System.Drawing.Point(259, 84);
            this.tbMailto.Multiline = true;
            this.tbMailto.Name = "tbMailto";
            this.tbMailto.Size = new System.Drawing.Size(310, 35);
            this.tbMailto.TabIndex = 6;
            // 
            // tbSubj
            // 
            this.tbSubj.Location = new System.Drawing.Point(100, 164);
            this.tbSubj.Multiline = true;
            this.tbSubj.Name = "tbSubj";
            this.tbSubj.Size = new System.Drawing.Size(907, 35);
            this.tbSubj.TabIndex = 7;
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(100, 224);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(907, 261);
            this.rtbBody.TabIndex = 8;
            this.rtbBody.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(654, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password:";
            // 
            // tbPass
            // 
            this.tbPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbPass.Location = new System.Drawing.Point(754, 28);
            this.tbPass.Multiline = true;
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(253, 35);
            this.tbPass.TabIndex = 10;
<<<<<<< HEAD
=======
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
>>>>>>> 569275a8ee99b89110815d2eb38ca625b1e05b64
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 511);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbBody);
            this.Controls.Add(this.tbSubj);
            this.Controls.Add(this.tbMailto);
            this.Controls.Add(this.tbMailfr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSend);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.TextBox tbMailfr;
        private System.Windows.Forms.TextBox tbMailto;
        private System.Windows.Forms.TextBox tbSubj;
        private System.Windows.Forms.RichTextBox rtbBody;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPass;
    }
}