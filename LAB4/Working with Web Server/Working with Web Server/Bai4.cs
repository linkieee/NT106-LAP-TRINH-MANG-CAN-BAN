using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
namespace Working_with_Web_Server
{
    public partial class Bai4 : Form
    {
        private WebView2 webView;

        public Bai4()
        {
            InitializeComponent();
            InitializeWebView();
        }
        private async void InitializeWebView()
        {
            webView = webView21;
            webView.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;
            webView.NavigationCompleted += WebView_NavigationCompleted;
            Controls.Add(webView);
            await webView.EnsureCoreWebView2Async(null);
        }
        private void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            textBox1.Text = webView.Source.AbsoluteUri;
        }

        private void WebView_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            textBox1.Text = webView.Source.AbsoluteUri;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.Source = new Uri(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (webView.CoreWebView2.CanGoBack)
                webView.CoreWebView2.GoBack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (webView.CoreWebView2.CanGoForward)
                webView.CoreWebView2.GoForward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webView.Reload();

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string url = webView.Source.AbsoluteUri;
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc;
            try
            {
                doc = await web.LoadFromWebAsync(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải trang web: {ex.Message}");
                return;
            }
            /*SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            try
            {
                webView.Source = new Uri(sfd.FileName);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn tệp HTML hợp lệ!");
            }*/
            string folderPath = @"D:\HOCTAP\NT106 - LTMCB\NT106-LAP-TRINH-MANG-CAN-BAN\LAB4\download"; // Đổi đường dẫn thư mục tải về ở đây
            Directory.CreateDirectory(folderPath);

            using (WebClient client = new WebClient())
            {
                // Tải về tệp HTML chính
                string mainHtmlFileName = Path.Combine(folderPath, "index.html");
                File.WriteAllText(mainHtmlFileName, doc.DocumentNode.OuterHtml);

                // Tải về hình ảnh, script, liên kết, v.v.
                foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//img | //link | //script | //a"))
                {
                    string fileUrl = link.GetAttributeValue("src", null) ?? link.GetAttributeValue("href", null);

                    if (!string.IsNullOrEmpty(fileUrl))
                    {
                        // Giải quyết các URL tương đối
                        Uri resolvedUri;
                        if (!Uri.TryCreate(new Uri(url), fileUrl, out resolvedUri))
                        {
                            // Bỏ qua các URL không hợp lệ
                            continue;
                        }

                        // Tạo tên tệp
                        string fileName = Path.GetFileName(resolvedUri.LocalPath);
                        if (string.IsNullOrEmpty(fileName))
                        {
                            // Xử lý URL không có tên tệp
                            fileName = $"file_{Guid.NewGuid()}";
                        }

                        // Tải về tệp
                        string filePath = Path.Combine(folderPath, fileName);
                        try
                        {
                            byte[] fileData = await client.DownloadDataTaskAsync(resolvedUri);
                            File.WriteAllBytes(filePath, fileData);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi tải về tệp '{fileName}': {ex.Message}");
                        }
                    }
                }
            }

            MessageBox.Show("Tải về hoàn tất.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            try
            {
                webView.Source = new Uri(ofd.FileName);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn tệp HTML hợp lệ!");
            }
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            string htmlSource = await GetAndShowHtmlSourceAsync();

        }
        private async Task<string> GetAndShowHtmlSourceAsync()
        {
            string htmlSource = await GetHtmlSourceAsync();
            ViewSource viewSource = new ViewSource(htmlSource);
            viewSource.Show();
            return htmlSource;
        }

        private async Task<string> GetHtmlSourceAsync()
        {
            return await webView.ExecuteScriptAsync("document.documentElement.outerHTML");
        }
    }
}
