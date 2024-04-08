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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }
        private void btnChooseFol_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedFolderPath = folderBrowserDialog.SelectedPath;
                LoadFilesToListView(selectedFolderPath);
            }
        }

        private void LoadFilesToListView(string folderPath)
        {
            DirectoryInfo di = new DirectoryInfo(folderPath);

            if (di.Exists)
            {
                listViewFiles.Items.Clear();
                foreach (FileInfo file in di.GetFiles())
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.Length.ToString());
                    item.SubItems.Add(file.Extension);
                    item.SubItems.Add(file.CreationTime.ToString());
                    listViewFiles.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Thư mục không tồn tại.");
            }
        }

        private void Bai5_Load(object sender, EventArgs e)
        {
            listViewFiles.View = View.Details;
            listViewFiles.Columns.Add("Tên file", 200);
            listViewFiles.Columns.Add("Kích thước", 100);
            listViewFiles.Columns.Add("Đuôi mở rộng", 100);
            listViewFiles.Columns.Add("Ngày tạo", 200);
        }
    }
}
