using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket_in_C_
{
    public partial class Bai1_Server : Form
    {
        public Bai1_Server()
        {
            InitializeComponent();
        }

        public void serverThread()
        {
            int port = Convert.ToInt32(portTextbox.Text);
            UdpClient udpClient = new UdpClient(port);
            while (true)
            {
                IPEndPoint IpEnd = new IPEndPoint(IPAddress.Any, port);
                Byte[] recvByte = udpClient.Receive(ref IpEnd);
                string Data = Encoding.UTF8.GetString(recvByte);
                string mess = IpEnd.Address.ToString() + ":" + IpEnd.Port.ToString() + ": " + Data.ToString();
                receivedMessages.Invoke(new Action(() => receivedMessages.Text += mess + "\r\n"));
            }
        }

        private Thread servers;


        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (servers != null)
            {
                servers.Interrupt();
                servers.Join();
            }
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            servers = new Thread(serverThread);
            servers.Start();
        }
    }
}
