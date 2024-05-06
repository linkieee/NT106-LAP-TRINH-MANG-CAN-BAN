using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket_in_C_
{
    public partial class Bai1_Client : Form
    {
        public Bai1_Client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            IPAddress ipadd = IPAddress.Parse(ipConnect.Text);
            int port = Convert.ToInt32(portTextbox.Text);
            IPEndPoint ipend = new IPEndPoint(ipadd, port);
            Byte[] sendBytes = Encoding.UTF8.GetBytes(messageTextbox.Text);
            udpClient.Send(sendBytes, sendBytes.Length, ipend);
            messageTextbox.Text = "";
        }
    }
}
