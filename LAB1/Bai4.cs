using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB1
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Int32.Parse(socandoc.Text.Trim());
                ketqua.Text = number.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(socandoc.Text))
                {
                kieuhientai.Items.Add("Decimal");
                kieuhientai.Items.Add("Binary");
                kieuhientai.Items.Add("Hexadecimal");
                }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
        }
    }
}
