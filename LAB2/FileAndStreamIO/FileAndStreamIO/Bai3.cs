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
using static System.Net.WebRequestMethods;

namespace FileAndStreamIO
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
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
                MessageBox.Show("Đọc file thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                string content = tbFile.Text;
                string[] lines = content.Split('\n');
                string output = string.Empty;

                DataTable dt = new DataTable();
                foreach (string line in lines)
                {
                    object result = dt.Compute(line, "");
                    output = output + line + " = " + result + "\n";
                }

                tbFile.Clear();

                s.WriteLine(output);
                MessageBox.Show("Ghi file thành công!");
                s.Close();
                f.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
