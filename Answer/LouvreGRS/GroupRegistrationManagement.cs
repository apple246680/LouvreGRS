using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LouvreGRS
{
    public partial class GroupRegistrationManagement : Form
    {
        public GroupRegistrationManagement()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.UnhandledException += HandleUnhandledException;
        }
        private void HandleUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            MessageBox.Show($"異常: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        DataTable dt = new DataTable()
        {
            Columns =
                {
                   new DataColumn("套裝名稱"),
                   new DataColumn("參觀時段"),
                   new DataColumn("建議參觀時數"),
                   new DataColumn("售價(人)"),
                   new DataColumn("最大可報名人數"),
                   new DataColumn("剩餘可報名人數"),
                   new DataColumn("狀態"),
                }
        };
        LouvreGRS_ANMEntities entities = new LouvreGRS_ANMEntities();
        private void GroupRegistrationManagement_Load(object sender, EventArgs e)
        {
            var data = entities.Packages;
            var peoplematch = entities.GroupRegistrations.Select(x => new { packid = x.PackageID, people = x.Minors + x.Adults }).ToList().GroupBy(z => z.packid).Select(group => new { AccountID = group.Key, TotalAmount = group.Sum(z => z.people) }).ToDictionary(x => x.AccountID, y => y.TotalAmount);
            int pll = 0;
            foreach (var item in data)
            {
                if (item.IsValid == "0")
                {
                    continue;
                }
                else
                {
                    CaseDatagridview.Rows.Add(item.PackageName, item.VisitTime, item.TotalHours, item.FeePerPerson, item.Maximum, item.Maximum - peoplematch[item.ID], item.IsValid=="0"?"停售":"銷售中",item.IsValid=="0" ?"銷售":"停售");
                    dt.Rows.Add(item.PackageName, item.VisitTime, item.TotalHours, item.FeePerPerson, item.Maximum, item.Maximum - peoplematch[item.ID], dt.Rows.Add(item.PackageName, item.VisitTime, item.TotalHours, item.FeePerPerson, item.Maximum, item.Maximum - peoplematch[item.ID], item.IsValid == "0" ? "停售" : "銷售中"));
                }
            }
        }
        private void CaseDatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable casedt = new DataTable()
            {
                Columns =
                {
                   new DataColumn("旅行社名稱"),
                   new DataColumn("旅行社人員"),
                   new DataColumn("狀態"),
                   new DataColumn("付款時間"),
                   new DataColumn("慣用語言"),
                   new DataColumn("參觀日期"),
                   new DataColumn("訂單總額"),
                }
            };
            Model2.Visible = true;
            var selectrow = CaseDatagridview.SelectedRows[0].Cells["casename"].Value.ToString();
            CaseLabel.Text = "套裝名稱:" + selectrow;
            var packagematch = entities.Packages.FirstOrDefault(x => x.PackageName == selectrow);
            FeaturesLabel.Text = "特色:" + packagematch.Features;
            var title = entities.PackageItineraries.Where(x => x.Package.ID == packagematch.ID).Select(x => x.ExhibitionActivityData.DisplayTitle).ToList();
            ActivitiesLabel.Text = "關聯活動" + string.Join(",", title);
            var a1 = entities.PackageItineraries.Where(x => x.PackageID == packagematch.ID).Select(x => x.ExhibitionActivityData.ID).ToList();
            List<string> a3 = new List<string>();
            foreach (var item in a1)
            {
                var a2 = entities.ExhibitionActivityDatas.Where(x => x.ID == item).Select(x => x.HallDatas.Select(y => y.KnownName).ToList()).ToList();
                foreach (var item1 in a2[0])
                {
                    a3.Add(item1);
                }
            }
            ExhibitionLabel.Text = "關聯展館" + String.Join(",", a3.Distinct());
            var a = entities.GroupRegistrations.Where(x=>x.PackageID==packagematch.ID);
            foreach (var item in a)
            {
                string statuss = "";
                string time = "";
                if (item.Status == 1 || item.Status == 2)
                {
                    statuss = "未付款";
                    time = "N/A";
                }
                else
                {
                    statuss = "付款完成";
                    time = item.PaymentTime.Value.ToString("yyyy-MM-dd");
                }
                dataGridView1.Rows.Add(item.TravelAgencyUserData.TravelAgencyData.Name,item.TravelAgencyUserData.AccountData.FirstName+" "+ item.TravelAgencyUserData.AccountData.LastName,statuss,time,item.VisitLanguage,item.VisitDate.Value.ToString("yyyy-MM-dd"),null,"另存CSV");
            }
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var a = dt;
            if (CaseTextbox.Text != "")
                try
                {
                    a = dt.Select($"套裝名稱 LIKE '*{CaseTextbox.Text.Replace("'", "''")}*'").CopyToDataTable();
                }
                catch
                {
                    MessageBox.Show("找不到");
                }
            CaseDatagridview.DataSource = a;
        }
    }
}
