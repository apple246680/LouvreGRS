using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LouvreGRS
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleUnhandledException);
        }
        HttpResponseMessage response = new HttpResponseMessage();
        private void HandleUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            MessageBox.Show($"異常: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void reload()
        {
            Feedback_Load(null, null);
            enter_textbox.Text = string.Empty;
            star = 3;
            UpdateStarText();
        }
        int star;
        private void enter_btn_Click(object sender, EventArgs e)
        {
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = response.Content.ReadAsStringAsync().Result;
                JsonDocument doc = JsonDocument.Parse(jsonResponse);
                string RequestToken = doc.RootElement.GetProperty("RequestToken").GetString();
                var time = doc.RootElement.GetProperty("EarliestApplyTime").GetDateTime();
                var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string jsonData = JsonSerializer.Serialize(new
                {
                    RequestToken = RequestToken,
                    Content = enter_textbox.Text,
                    Score = star
                });
                HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                if ((time - DateTime.Now).Seconds > 0)
                { MessageBox.Show($"請再次檢查您的資料，並於 {(time - DateTime.Now).Seconds} 秒後再傳送！"); return; }
                HttpResponseMessage esponse = httpClient.PostAsync("http://localhost:500/api/UserVoice/ApplyUserVoice", content).Result;
                if (esponse.IsSuccessStatusCode)
                {
                    string jsonResponse1 = esponse.Content.ReadAsStringAsync().Result;
                    JsonDocument doc1 = JsonDocument.Parse(jsonResponse1);
                    string ResultCode = doc1.RootElement.GetProperty("ResultCode").GetString();
                    if (ResultCode == "0000")
                    {
                        MessageBox.Show("感謝您反應寶貴的意見！");
                        Main.backstatic();
                    }
                    else if (ResultCode != "0000")
                        MessageBox.Show("請確認您的資料正確，或是回報系統發生了些問題，請稍後再試！");
                }
            }
        }
        private void UpdateStarText()
        {
            star1.Text = (star >= 1) ? "★" : "☆";
            star2.Text = (star >= 2) ? "★" : "☆";
            star3.Text = (star >= 3) ? "★" : "☆";
            star4.Text = (star >= 4) ? "★" : "☆";
            star5.Text = (star == 5) ? "★" : "☆";
        }
        private void star1_Click(object sender, EventArgs e)
        {
            star = (Convert.ToInt32((sender as Label).Tag));
            UpdateStarText();
        }
        private void Feedback_Load(object sender, EventArgs e)
        {
            var https = new HttpClient();
            https.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            response = https.GetAsync("http://localhost:500/api/UserVoice/GetRequestToken").Result;
        }
    }
}
