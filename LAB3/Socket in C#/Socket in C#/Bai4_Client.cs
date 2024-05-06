using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket_in_C_
{
    public partial class Bai4_Client : Form
    {
        TcpClient tcpClient;
        NetworkStream stream;
        IPEndPoint ipEndPoint;
        Thread receiveThread;
        public Bai4_Client()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
            receiveThread = new Thread(new ThreadStart(Receive));
            receiveThread.Start();
        }

        public void Disconnect()
        {
            try
            {
                if (tcpClient != null)
                {
                    stream = tcpClient.GetStream();
                    byte[] buffer = Encoding.UTF8.GetBytes("Quit");
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
            catch { }
            if (stream != null)
            {
                stream.Close();
                tcpClient.Close();
            }
        }
        public void Connect()
        {
            try
            {
                tcpClient = new TcpClient();
                ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                tcpClient.Connect(ipEndPoint);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Send()
        {
            stream = tcpClient.GetStream();
            //byte[] buffer = new byte[1024];
            byte[] buffer = Encoding.UTF8.GetBytes(rtbName.Text + ": " + rtbMessage.Text + "\n");
            stream.Write(buffer, 0, buffer.Length);
            ttbChatAll.AppendText(rtbName.Text + ": " + rtbMessage.Text + "\n");
            // richTextBox1.Clear();
        }
        public void Receive()
        {
            while (tcpClient.Connected)
            {
                try
                {
                    stream = tcpClient.GetStream();
                    byte[] buffer = new byte[1024];
                    stream.Read(buffer, 0, buffer.Length);
                    ttbChatAll.AppendText(Encoding.UTF8.GetString(buffer) + "\r\n");
                }
                catch
                {
                    //tcpClient.Close();
                }
            }
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            if (tcpClient != null)
            {
                Send();
                rtbMessage.Clear();
            }
            else
            {
                MessageBox.Show("Don't connect to server!");
            }
        }
    }
}
