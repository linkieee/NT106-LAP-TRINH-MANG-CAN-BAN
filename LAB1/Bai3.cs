using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
        static string DocSo(int n)
        {
            switch (n)
            {
                case 0:
                    return "không";
                case 1:
                    return "một";
                case 2:
                    return "hai";
                case 3:
                    return "ba";
                case 4:
                    return "bốn";
                case 5:
                    return "năm";
                case 6:
                    return "sáu";
                case 7:
                    return "bảy";
                case 8:
                    return "tám";
                case 9:
                    return "chín";
                default:
                    return "Số không hợp lệ";
                }
            }
            private void button1_Click(object sender, EventArgs e)
            {
                int number = Int32.Parse(socandoc.Text.Trim());
                try
                {
                    if (number < 10)
                    {
                        ketqua.Text = DocSo(number);
                    }
                    else if (10 <= number && number <= 99)
                    {
                        int donvi = number % 10;
                        int hangchuc = number / 10;
                        if (number == 10)
                        {
                            ketqua.Text = "mười";
                        }
                        else if (hangchuc == 1)
                        {
                            if(donvi == 5)
                        {
                            ketqua.Text = "mười lăm";
                        }
                            ketqua.Text = "mười " + DocSo(donvi);
                        }
                        else
                        {
                            ketqua.Text = DocSo(hangchuc) + " mươi " + DocSo(donvi);
                        }
                    }
                    else if (100 <= number && number <= 999)
                    {
                        int hangtram = number / 100;
                        int hangchuc = (number % 100) / 10;
                        int donvi = number % 10;

                        if (hangchuc == 0 && donvi == 0)
                        {
                            ketqua.Text = DocSo(hangtram) + " trăm";
                        }
                        else if (hangchuc == 0)
                        {
                            ketqua.Text = DocSo(hangtram) + " trăm linh " + DocSo(donvi);
                        }
                        else if (hangchuc == 1)
                        {
                            ketqua.Text = DocSo(hangtram) + " trăm mười " + DocSo(donvi);
                        }
                        else
                        {
                            ketqua.Text = DocSo(hangtram) + " trăm " + DocSo(hangchuc) + "mươi" + DocSo(donvi);
                        }
                    }
                    else
                    {
                        ketqua.Text = "Số quá lớn, vui lòng nhập số có tối đa 4 chữ số.";
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên.");
                }
            }

            private void button2_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Bạn có chắc chắn muốn xóa không?");
                Action<Control.ControlCollection> func = null;
                func = (controls) =>
                {
                    foreach (Control ctrl in controls)
                    {
                        if (ctrl is TextBox)
                        {
                            (ctrl as TextBox).Clear();
                        }
                        else
                            func(ctrl.Controls);
                    }
                };
                func(Controls);
            }

            private void button3_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }