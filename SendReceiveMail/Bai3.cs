using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using MimeKit;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SendReceiveMail
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string mailfrom = tbMailto.Text.Trim();
            string mailto = tbMailto.Text.Trim();
            string subject = tbSubj.Text.Trim();
            string body = rtbBody.Text.Trim();

            try
            {
                // Thực hiện xác thực OAuth2 và nhận Credential object
                UserCredential credential;
                using (var stream = new FileStream("client_secret_1.json", FileMode.Open, FileAccess.Read))
                {
                    string[] scopes = { GmailService.Scope.GmailSend };
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        scopes,
                        "user",
                        CancellationToken.None).Result;
                }

                // Khởi tạo Gmail API service
                var service = new GmailService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "NT106Lab5",
                });

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
                    service.Users.Messages.Send(gmailMessage, "me").Execute();
                }

                MessageBox.Show("Email đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
