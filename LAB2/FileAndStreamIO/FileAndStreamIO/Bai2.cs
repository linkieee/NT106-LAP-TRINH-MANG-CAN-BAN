using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileAndStreamIO
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                //ofd.Filter = "Text (*.txt) |.txt";
                ofd.ShowDialog();
                if (!ofd.SafeFileName.EndsWith(".txt"))
                {
                    throw new ArgumentException("Vui lòng chọn đúng định dạng .txt");
                }
                FileStream f = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader s = new StreamReader(f);

                //Đọc file
                string content = s.ReadToEnd();
                tbFile.Text = content;
                f.Close();
                //Đọc tên file
                string filename = ofd.SafeFileName.ToString();
                tbFileName.Text = filename;

                //Đếm kí tự
                int charcount = content.Length;
                tbCharCount.Text = charcount.ToString();

                //Đếm số dòng
                content = content.Replace("\r\n", "\r");
                int linecount = 0;
                linecount = tbFile.Lines.Count();
                content = content.Replace('\r', ' ');
                tbLineCount.Text = linecount.ToString();

                //url của file
                string link = f.Name.ToString();
                tbURL.Text = link;

                //Đếm số từ
                string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int wordcount = source.Count();
                tbWordCount.Text = wordcount.ToString();


            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
