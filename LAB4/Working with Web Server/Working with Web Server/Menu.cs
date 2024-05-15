using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Working_with_Web_Server
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai1 b1 = new Bai1();
            b1.ShowDialog();
            b1 = null;
            this.Show();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai2 b2 = new Bai2();
            b2.ShowDialog();
            b2 = null;
            this.Show();
        }
    }
}
