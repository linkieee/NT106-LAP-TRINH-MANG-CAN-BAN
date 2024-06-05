using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SendReceiveMail
{
    public partial class Bai4_Compose : Form
    {
        private GmailService _service;

        public Bai4_Compose(GmailService service)
        {
            InitializeComponent();
            _service = service;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string mailto = tbTo.Text.Trim();
            string subject = tbSubject.Text.Trim();


            string body = richTextBox1.Text.Trim();

            var profileRequest = _service.Users.GetProfile("me");
            var profile = await profileRequest.ExecuteAsync();

            string mailfrom = profile.EmailAddress;

            try
            {
                // Tạo email message
                var msg = new MimeMessage();
                msg.From.Add(new MailboxAddress(mailfrom, mailfrom));
                msg.To.Add(new MailboxAddress(mailto, mailto));
                msg.Subject = subject;
                msg.Body = new TextPart("plain")
                {
                    Text = body
                };

                var bodyBuilder = new BodyBuilder { TextBody = body };

                string attachmentPath = tbAttach.Text;
                if (File.Exists(attachmentPath))
                {
                    bodyBuilder.Attachments.Add(attachmentPath);
                }

                msg.Body = bodyBuilder.ToMessageBody();

                // Chuyển đổi email thành định dạng chuỗi Base64
                using (var memory = new MemoryStream())
                {
                    msg.WriteTo(memory);
                    var gmailMessage = new Google.Apis.Gmail.v1.Data.Message
                    {
                        Raw = Convert.ToBase64String(memory.ToArray())
                    };

                    // Gửi email thông qua Gmail API
                    _service.Users.Messages.Send(gmailMessage, "me").Execute();
                }

                MessageBox.Show("Email đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "d:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbAttach.Text = openFileDialog1.FileName;
            }

        }
    }
}
