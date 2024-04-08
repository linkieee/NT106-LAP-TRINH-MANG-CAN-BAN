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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FileAndStreamIO
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string MSSV = tbMSSV.Text;  
                string HoTen = tbName.Text;
                string SDT = tbSDT.Text;
                if (SDT.Length != 10 || !SDT.All(char.IsDigit))
                {
                    throw new Exception("Vui lòng nhập số điện thoại có 10 chữ số.");
                }

                float DiemToan = float.Parse(tbMath.Text);
                if (DiemToan > 10 || DiemToan < 0)
                {
                    throw new Exception("Điểm toán không hợp lệ. Vui lòng nhập điểm từ 0 đến 10.");
                }
                float DiemVan = float.Parse(tbVan.Text);
                if (DiemVan > 10 || DiemVan < 0)
                {
                    throw new Exception("Điểm văn không hợp lệ. Vui lòng nhập điểm từ 0 đến 10.");
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text (*.txt) | *.txt";
                sfd.ShowDialog();
                FileStream f = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                StreamWriter s = new StreamWriter(f);

                s.WriteLine($"{MSSV}\n{HoTen}\n{SDT}\n{DiemToan}\n{DiemVan}");
                MessageBox.Show("Dữ liệu ghi vào file thành công");
                tbMSSV.Clear();
                tbName.Clear();
                tbSDT.Clear();
                tbMath.Clear();
                tbVan.Clear();

                s.Close();
                f.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        List<SinhVien> dssv = new List<SinhVien>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = tbMSSV.Text;
            sv.HoTen = tbName.Text;
            sv.SDT = tbSDT.Text;
            sv.DiemToan = float.Parse(tbMath.Text);
            sv.DiemVan = float.Parse(tbVan.Text);
            dssv.Add(sv);
            XuatSV();
        }
        void XuatSV()
        {
            lbDSSV.Items.Clear();
            foreach (SinhVien sv in dssv)
            {
                lbDSSV.Items.Add(sv);
            }
        }
    }
}
