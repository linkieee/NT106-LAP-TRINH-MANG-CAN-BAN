namespace FileAndStreamIO
{
    partial class Bai5
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
            this.btnChooseFol = new System.Windows.Forms.Button();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnChooseFol
            // 
            this.btnChooseFol.Location = new System.Drawing.Point(407, 518);
            this.btnChooseFol.Name = "btnChooseFol";
            this.btnChooseFol.Size = new System.Drawing.Size(206, 72);
            this.btnChooseFol.TabIndex = 0;
            this.btnChooseFol.Text = "Chọn folder cần đọc";
            this.btnChooseFol.UseVisualStyleBackColor = true;
            this.btnChooseFol.Click += new System.EventHandler(this.btnChooseFol_Click_1);
            // 
            // listViewFiles
            // 
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.Location = new System.Drawing.Point(24, 27);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(1006, 485);
            this.listViewFiles.TabIndex = 1;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 602);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.btnChooseFol);
            this.Name = "Bai5";
            this.Text = "FileExplorer";
            this.Load += new System.EventHandler(this.Bai5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFol;
        private System.Windows.Forms.ListView listViewFiles;
    }
}