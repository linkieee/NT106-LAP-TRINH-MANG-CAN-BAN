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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string url = tbURL.Text.Trim();
            string htmlContent = GetHTML(url);

            if (htmlContent != null)
            {
                tbHTML.Text = htmlContent;
            }
            else
            {
                tbHTML.Text = "Không thể tải nội dung từ URL đã cung cấp.";
            }
        }

        private string GetHTML(string szURL)
        {
            try
            {
                WebRequest request = WebRequest.Create(szURL);
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                response.Close();
                return responseFromServer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
        }
    }
}
