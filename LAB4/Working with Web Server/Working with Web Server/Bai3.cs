using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Working_with_Web_Server
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string URL = tbURL.Text;
            string fileURL = tbSaveFile.Text;
            string WebHTML = "";
            WebHTML = getHTML(tbURL.Text);
            tbHTML.Text = WebHTML;
            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(URL);
            myClient.DownloadFile(URL, fileURL);
        }

        private string getHTML(string szURL)
        {
            WebRequest request = WebRequest.Create(szURL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }

    }
}
