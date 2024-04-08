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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            try
            {
                num1 = double.Parse(sothunhat.Text.Trim());
                num2 = double.Parse(sothuhai.Text.Trim());
                num3 = double.Parse(sothuba.Text.Trim());
                double max = num1;
                if (num1 >= num2 && num1 >= num3)
                {
                    max = num1;
                }
                else if (num2 >= num1 && num2 >= num3)
                {
                    max = num2;
                }
                else
                {
                    max = num3;
                }
                solonnhat.Text = max.ToString();

                double min = num1;
                if (num1 <= num2 && num1 <= num3)
                {
                    min = num1;
                }
                else if (num2 <= num1 && num2 <= num3)
                {
                    min = num2;
                }
                else
                {
                    min = num3;
                }
                sonhonhat.Text = min.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số.");
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
