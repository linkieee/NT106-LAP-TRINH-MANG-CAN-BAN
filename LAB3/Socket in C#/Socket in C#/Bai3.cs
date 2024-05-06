using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket_in_C_
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Bai3_Server tcpServer = new Bai3_Server();
            tcpServer.Show();
            //tcpServer = null;
            //this.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Bai3_Client tcpClient = new Bai3_Client();
            tcpClient.Show();
            //tcpClient = null;
            //this.Show();
        }
    }
}
