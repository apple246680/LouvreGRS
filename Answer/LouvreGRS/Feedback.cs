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
        }
        HttpResponseMessage response = new HttpResponseMessage();
        public void Reload()
        {
            Feedback_Load(null, null);
            Entertextbox.Text = string.Empty;
            UpdateStarText(3);
        }
        int star;
        private void UpdateStarText(int selectstars)
        {
            star = selectstars;
            star1.Text = (star >= 1) ? "★" : "☆";
            star2.Text = (star >= 2) ? "★" : "☆";
            star3.Text = (star >= 3) ? "★" : "☆";
            star4.Text = (star >= 4) ? "★" : "☆";
            star5.Text = (star == 5) ? "★" : "☆";
        }
        private void Feedback_Load(object sender, EventArgs e)
        {
            var https = new HttpClient();
            https.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            response = https.GetAsync("http://localhost:500/api/UserVoice/GetRequestToken").Result;
        }
        private void Star1_Click(object sender, EventArgs e)
        {
            UpdateStarText(Convert.ToInt32((sender as Label).Tag));
        }

        private void EnterBtn_Click(object sender, EventArgs e)
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
                    Content = Entertextbox.Text,
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
                        Main.Backstatic(null);
                    }
                    else if (ResultCode != "0000")
                        MessageBox.Show("請確認您的資料正確，或是回報系統發生了些問題，請稍後再試！");
                }
            }
        }
    }
}
