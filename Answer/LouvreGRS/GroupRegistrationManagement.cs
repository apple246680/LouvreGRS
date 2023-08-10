using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
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
        LouvreGRS_ANMEntities entities=new LouvreGRS_ANMEntities();
        private void GroupRegistrationManagement_Load(object sender, EventArgs e)
        {
            var data = entities.Packages;
            foreach (var item in data)
            {
                if (item.IsValid=="0")
                    continue;
                var peoplematch= entities.GroupRegistrations.Select(x=>new {packid=x.PackageID,people=x.Minors+x.Adults}).ToList().GroupBy(z=>z.packid).Select(group => new { AccountID = group.Key, TotalAmount = group.Sum(z => z.people) }).ToDictionary(x=>x.AccountID,y=>y.TotalAmount);
                dt.Rows.Add(item.PackageName, item.VisitTime, item.TotalHours,null, item.Maximum,item.Maximum-peoplematch[item.ID],null);
            }
            CaseDatagridview.DataSource = dt;
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "ActionColumn";
            buttonColumn.HeaderText = "Actions";
            buttonColumn.Text = "Click Me";
            buttonColumn.UseColumnTextForButtonValue = true;
            CaseDatagridview.Columns.Add(buttonColumn);
        }

        private void CaseDatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var aaa = CaseDatagridview.SelectedRows[0];
            var aa= aaa.Cells["套裝名稱"].Value.ToString();
            CaseLabel.Text = "套裝名稱:"+aa;
            var a = entities.Packages.FirstOrDefault(x => x.PackageName == aa);
            FeaturesLabel.Text = "特色:"+a.Features;
            var aaaa = a.PackageItineraries.Where(x => x.Package.ID == x.PackageID).Select(x => x.ExhibitionActivityData.DisplayTitle).ToList();
            ActivitiesLabel.Text = "關聯活動" + aaaa[0];
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var a = dt;
            if (CaseTextbox.Text!="")
                try
                {
                    a = dt.Select($"套裝名稱 LIKE '*{CaseTextbox.Text.Replace("'", "''")}*'").CopyToDataTable();
                }
                catch
                {
                    MessageBox.Show("找不到");
                }
            CaseDatagridview.DataSource=a;
        }
    }
}
