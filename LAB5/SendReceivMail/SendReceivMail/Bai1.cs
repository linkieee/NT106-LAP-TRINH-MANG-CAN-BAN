using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SendReceivMail
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailfrom = tbMailfr.Text.ToString().Trim();
                string mailto = tbMailto.Text.ToString().Trim();
                string password = tbPass.Text.ToString().Trim();
                var basicCredential = new NetworkCredential(mailfrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;

                    message.From = fromAddress;
                    message.Subject = tbSubj.Text.ToString().Trim();
                    message.IsBodyHtml = true;
                    message.Body = rtbBody.Text.ToString();
                    message.To.Add(mailto);

                    try
                    {
                        smtpClient.Send(message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
    }
}
