﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Net.Http;

namespace Socket_in_C_
{
    public partial class Bai3_Client : Form
    {
        public Bai3_Client()
        {
            InitializeComponent();
        }

        private TcpClient tcpClient = new TcpClient();

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, 8080);
            tcpClient.Connect(iPEndPoint);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            NetworkStream ns = tcpClient.GetStream();
            Byte[] data = Encoding.ASCII.GetBytes("Hello server.\n");
            richTextBox1.AppendText("You: " + "Hello server." + "\n");
            ns.Write(data, 0, data.Length);
        }


    }
}
