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
    public partial class ViewSource : Form
    {
        public ViewSource()
        {
            InitializeComponent();
        }
        public ViewSource(string htmlSource)
        {
            InitializeComponent();
            richTextBox1.Text = htmlSource;
        }
    }
}
