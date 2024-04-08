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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Int32.Parse(sothunhat.Text.Trim());
                int num2 = Int32.Parse(sothuhai.Text.Trim());
                long sum = num1 + num2;
                ketqua.Text = sum.ToString();
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
