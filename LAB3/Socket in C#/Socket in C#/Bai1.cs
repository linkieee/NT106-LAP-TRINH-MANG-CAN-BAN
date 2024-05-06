using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket_in_C_
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        private void serverThread()
        {
            Bai1_Server b1 = new Bai1_Server();
            b1.ShowDialog();
            b1 = null;
            this.Show();
        }

        private void clientThread()
        {
            Bai1_Client b2 = new Bai1_Client();
            b2.ShowDialog();
            b2 = null;
            this.Show();
        }

        private Thread server, client;

        private void btnServer_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            server = new Thread(serverThread);
            server.Start();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            client = new Thread(clientThread);
            client.Start();
        }
    }
}
