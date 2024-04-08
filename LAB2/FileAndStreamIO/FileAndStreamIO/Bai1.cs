using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileAndStreamIO
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        public static void ReadFile(string[] args)
        {
            
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                //ofd.Filter = "Text (*.txt) | *.txt";
                ofd.ShowDialog();
                if (!ofd.SafeFileName.EndsWith(".txt"))
                {
                    throw new ArgumentException("Vui lòng chọn đúng định dạng .txt");
                }
                FileStream f = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader s = new StreamReader(f);


                string content = s.ReadToEnd();
                tbFile.Text = content;
                f.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể đọc file: " + ex.Message);
            }

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text (*.txt) | *.txt";
                sfd.ShowDialog();
                FileStream f = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                StreamWriter s = new StreamWriter(f);

                string contentUpperCase = tbFile.Text.ToUpper();
                
                s.WriteLine(contentUpperCase);
                MessageBox.Show("Ghi file thành công!");
                s.Close();
                f.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi file: " + ex.Message);
            }
        }
    }
}
