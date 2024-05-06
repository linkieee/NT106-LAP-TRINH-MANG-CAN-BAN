using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket_in_C_
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Bai4_Server tcpServer = new Bai4_Server();
            tcpServer.Show();
            //tcpServer = null;
            //this.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Bai4_Client tcpClient = new Bai4_Client();
            tcpClient.Show();
            //tcpClient = null;
            //this.Show();
        }
    }
}
