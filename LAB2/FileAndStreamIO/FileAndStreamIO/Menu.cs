using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileAndStreamIO
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai1 b1 = new Bai1();
            b1.ShowDialog();
            b1 = null;
            this.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai2 b2 = new Bai2();
            b2.ShowDialog();
            b2 = null;
            this.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai3 b3 = new Bai3();
            b3.ShowDialog();
            b3 = null;
            this.Show();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai4 b4 = new Bai4();
            b4.ShowDialog();
            b4 = null;
            this.Show();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai5 b5 = new Bai5();
            b5.ShowDialog();
            b5 = null;
            this.Show();
        }
    }
}
