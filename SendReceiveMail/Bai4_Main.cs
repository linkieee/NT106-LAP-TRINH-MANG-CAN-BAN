using Google.Apis.Gmail.v1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendReceiveMail
{
    public partial class Bai4_Main : Form
    {
        private GmailService _service;
        private List<Google.Apis.Gmail.v1.Data.Message> _allEmails;
        private int _currentPage;
        private const int PageSize = 50;
        public Bai4_Main(GmailService service)
        {
            InitializeComponent();
            _service = service;
            _allEmails = new List<Google.Apis.Gmail.v1.Data.Message>();
            _currentPage = 0;
        }

        private async void Bai4_Main_Load(object sender, EventArgs e)
        {
            btnInbox.Enabled = false;
            btnSent.Enabled = true;
            await Bai4_Main_LoadAsync();
        }

        private async Task Bai4_Main_LoadAsync()
        {
            var profileRequest = _service.Users.GetProfile("me");
            var profile = await profileRequest.ExecuteAsync();

            labelEmail.Text += profile.EmailAddress;

            ConfigureListView();
            await LoadEmailsAsync();
        }

        private void ConfigureListView()
        {
            listViewEmails.View = View.Details;
            listViewEmails.Columns.Clear();
            listViewEmails.Items.Clear();
            listViewEmails.Columns.Add("From", 200);
            listViewEmails.Columns.Add("Email", 450);
            listViewEmails.Columns.Add("Thời gian", 150);
        }

        private async Task LoadEmailsAsync()
        {
            try
            {
                var request = _service.Users.Messages.List("me");
                request.LabelIds = "INBOX";
                request.IncludeSpamTrash = false;
                request.MaxResults = 200;

                var response = await request.ExecuteAsync();
                _allEmails.AddRange(response.Messages);

                DisplayEmails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayEmails()
        {
            listViewEmails.Items.Clear();

            int start = _currentPage * PageSize;
            int end = Math.Min(start + PageSize, _allEmails.Count);

            for (int i = start; i < end; i++)
            {
                var message = _allEmails[i];
                AddEmailToListView(message);
            }

            btnPrevious.Enabled = _currentPage > 0;
            btnNext.Enabled = end < _allEmails.Count;
        }

        private async void AddEmailToListView(Google.Apis.Gmail.v1.Data.Message message)
        {
            var emailInfoReq = _service.Users.Messages.Get("me", message.Id);
            var emailInfoResponse = await emailInfoReq.ExecuteAsync();

            string from = "";
            string subject = emailInfoResponse.Snippet;
            string date = emailInfoResponse.InternalDate.ToString();

            foreach (var header in emailInfoResponse.Payload.Headers)
            {
                if (header.Name == "From")
                {
                    from = header.Value;
                }
                else if (header.Name == "Subject")
                {
                    subject = header.Value;
                }
                else if (header.Name == "Date")
                {
                    date = header.Value;
                }
            }

            var listViewItem = new ListViewItem(new[] { from, subject, date });
            listViewEmails.Items.Add(listViewItem);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Bai4 bai4 = new Bai4();
            bai4.ShowDialog();
            this.Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _currentPage--;
            DisplayEmails();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            DisplayEmails();
        }

        private async void btnInbox_Click(object sender, EventArgs e)
        {
            btnInbox.Enabled = false;
            btnSent.Enabled = true;
            await LoadEmailsAsync();
        }

        private async void btnSent_Click(object sender, EventArgs e)
        {
            btnInbox.Enabled = true;
            btnSent.Enabled = false;
            await LoadSentEmailsAsync();

        }

        private async Task LoadSentEmailsAsync()
        {
            try
            {
                var request = _service.Users.Messages.List("me");
                request.LabelIds = "SENT";
                request.IncludeSpamTrash = false;
                request.MaxResults = 200;

                var response = await request.ExecuteAsync();
                _allEmails.Clear(); // Clear the existing list
                _allEmails.AddRange(response.Messages);

                DisplayEmails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompose_Click(object sender, EventArgs e)
        {
            Bai4_Compose bai4_Compose = new Bai4_Compose(_service);
            bai4_Compose.ShowDialog();

        }
    }
}
