﻿namespace SendReceivMail
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
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.tbSubj = new System.Windows.Forms.TextBox();
            this.tbMailto = new System.Windows.Forms.TextBox();
            this.tbMailfr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(704, 29);
            this.tbPass.Multiline = true;
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(253, 35);
            this.tbPass.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(604, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Password:";
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(90, 227);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(907, 261);
            this.rtbBody.TabIndex = 19;
            this.rtbBody.Text = "";
            // 
            // tbSubj
            // 
            this.tbSubj.Location = new System.Drawing.Point(90, 167);
            this.tbSubj.Multiline = true;
            this.tbSubj.Name = "tbSubj";
            this.tbSubj.Size = new System.Drawing.Size(907, 35);
            this.tbSubj.TabIndex = 18;
            // 
            // tbMailto
            // 
            this.tbMailto.Location = new System.Drawing.Point(249, 87);
            this.tbMailto.Multiline = true;
            this.tbMailto.Name = "tbMailto";
            this.tbMailto.Size = new System.Drawing.Size(310, 35);
            this.tbMailto.TabIndex = 17;
            // 
            // tbMailfr
            // 
            this.tbMailfr.Location = new System.Drawing.Point(249, 31);
            this.tbMailfr.Multiline = true;
            this.tbMailfr.Name = "tbMailfr";
            this.tbMailfr.Size = new System.Drawing.Size(310, 35);
            this.tbMailfr.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-90, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Body:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-92, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "From:";
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(17, 35);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(120, 65);
            this.btSend.TabIndex = 11;
            this.btSend.Text = "SEND";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Body:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Subject:";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 532);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
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
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbBody;
        private System.Windows.Forms.TextBox tbSubj;
        private System.Windows.Forms.TextBox tbMailto;
        private System.Windows.Forms.TextBox tbMailfr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}