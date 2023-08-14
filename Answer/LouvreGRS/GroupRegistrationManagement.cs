using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
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
        }
        DataTable filteredResults = new DataTable();
        string jobTitle, additionalInfo;
        public void CheckJobTitleAndSaveData(string JobTitle, string additionalInformation)
        {
            jobTitle = JobTitle;
            additionalInfo = additionalInformation;
            LoadGroupRegistrations();
        }
        public void LoadGroupRegistrations()
        {
            var groupPackageCount = entities.GroupRegistrations.Select(x => new { packid = x.PackageID, people = x.Minors + x.Adults }).ToList().GroupBy(z => z.packid).Select(group => new { AccountID = group.Key, TotalAmount = group.Sum(z => z.people) }).ToDictionary(x => x.AccountID, y => y.TotalAmount);
            dt.Rows.Clear();
            foreach (var item in entities.Packages)
                dt.Rows.Add(item.PackageName, item.VisitTime, item.TotalHours, item.FeePerPerson, item.Maximum, item.GroupRegistrations.Any() ? (item.Maximum - groupPackageCount[item.ID]).ToString() : "N/a", item.IsValid == "0" ? "停售" : "銷售中", item.IsValid == "0" ? "銷售" : "停售");
            filteredResults = dt.Clone();
            if (jobTitle == "目前使用人員：旅行社管理員")
            {
                var travelAgencyPackages = entities.GroupRegistrations.Select(x => new
                {
                    packagename = x.Package.PackageName,
                    name = x.TravelAgencyUserData.TravelAgencyData.Name
                }).ToList();
                var packagesWithApple = travelAgencyPackages.Where(item => item.name == additionalInfo).ToList();
                foreach (var item in packagesWithApple.Select(x => x.packagename).ToList())
                {
                   var filteredPackage = dt.AsEnumerable().Where(x => x.Field<string>("套裝名稱") == item).CopyToDataTable();
                    filteredResults.Rows.Add(filteredPackage.Rows[0][0], filteredPackage.Rows[0][1], filteredPackage.Rows[0][2], filteredPackage.Rows[0][3], filteredPackage.Rows[0][4], filteredPackage.Rows[0][5], filteredPackage.Rows[0][6], filteredPackage.Rows[0][7]);
                }
            }
            else if (jobTitle == "目前使用人員：Guide")
            {
                var hallPackageMapping = entities.HallDatas.Select(x=>new { 
                    hallname=x.KnownName,
                    packagename=x.ExhibitionActivityDatas.Select(y=>y.PackageItineraries.Select(z=>z.Package.PackageName).ToList()).ToList()
                }).ToList();
                var selectedHalls = additionalInfo.Split('、').ToList();
                List<string> results = new List<string>();
                foreach (var hallPackageMappingitem in hallPackageMapping) 
                    foreach (var selectedHallsitem in selectedHalls)
                        if (hallPackageMappingitem.hallname== selectedHallsitem)
                            foreach (var packagenameitem in hallPackageMappingitem.packagename)
                                foreach (var item in packagenameitem)
                                    results.Add(item);
                results = results.Distinct().ToList();
                foreach (var item in results)
                {
                    var saod = dt.AsEnumerable().Where(x => x.Field<string>("套裝名稱") == item).CopyToDataTable();
                    filteredResults.Rows.Add(saod.Rows[0][0], saod.Rows[0][1], saod.Rows[0][2], saod.Rows[0][3], saod.Rows[0][4], saod.Rows[0][5], saod.Rows[0][6], saod.Rows[0][7]);
                }
            }
            else if (jobTitle == "目前使用人員：System Administrator")
                for (int i = 0; i < dt.Rows.Count; i++)
                    filteredResults.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7]);
            caseshow();
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
                   new DataColumn("操作")
                }
        };
        LouvreGRS_ANMEntities entities=new LouvreGRS_ANMEntities();
        public void caseshow()
        {
           CaseDatagridview.Rows.Clear();
            for (int i = 0; i < filteredResults.Rows.Count; i++)
                CaseDatagridview.Rows.Add(filteredResults.Rows[i][0], filteredResults.Rows[i][1], filteredResults.Rows[i][2], filteredResults.Rows[i][3], filteredResults.Rows[i][4], filteredResults.Rows[i][5], filteredResults.Rows[i][6], filteredResults.Rows[i][7]);
        }
            List<Guid>groupid;
        private void CaseDatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupid = new List<Guid>();
            if (e.ColumnIndex == CaseDatagridview.Columns[7].Index && e.RowIndex >= 0)
            {
                string textInRow = CaseDatagridview.Rows[e.RowIndex].Cells[0].Value.ToString();
                string textInRow1 = CaseDatagridview.Rows[e.RowIndex].Cells[7].Value.ToString();
                    var selectedPackage = entities.Packages.Find(entities.Packages.Where(x=>x.PackageName== textInRow).Select(x=>x.ID).FirstOrDefault());
                if(selectedPackage != null)
                    selectedPackage.IsValid = textInRow1 == "銷售"?"1":"0";
                entities.SaveChanges();
                LoadGroupRegistrations();
                
            }
            DataTable caseDataTable = new DataTable()
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
                   new DataColumn("匯出名單")
                }
            };
            Model2.Visible = true;
            var selectrow = CaseDatagridview.SelectedRows[0].Cells["casename"].Value.ToString();
            CaseLabel.Text = "套裝名稱:" + selectrow;
            var packagematch = entities.Packages.FirstOrDefault(x => x.PackageName == selectrow);
            FeaturesLabel.Text = "特色:" + packagematch.Features;
            var title = entities.PackageItineraries.Where(x => x.Package.ID == packagematch.ID).Select(x => x.ExhibitionActivityData.DisplayTitle).ToList();
            ActivitiesLabel.Text = "關聯活動" + string.Join(",", title);
            var exhibitionActivityIds = entities.PackageItineraries.Where(x => x.PackageID == packagematch.ID).Select(x => x.ExhibitionActivityData.ID).ToList();
            List<string> distinctHallNames = new List<string>();
            foreach (var item in exhibitionActivityIds)
            {
                var hallNamesForActivity = entities.ExhibitionActivityDatas.Where(x => x.ID == item).Select(x => x.HallDatas.Select(y => y.KnownName).ToList()).ToList();
                foreach (var item1 in hallNamesForActivity[0])
                    distinctHallNames.Add(item1);
            }
            ExhibitionLabel.Text = "關聯展館" + String.Join(",", distinctHallNames.Distinct());
            var a = entities.GroupRegistrations.Where(x => x.PackageID == packagematch.ID);
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
                groupid.Add(item.ID);
                var asd= item.GroupRegistrationVisitors.ToList();
                caseDataTable.Rows.Add(item.TravelAgencyUserData.TravelAgencyData.Name, item.TravelAgencyUserData.AccountData.FirstName + " " + item.TravelAgencyUserData.AccountData.LastName, statuss, time, item.VisitLanguage, item.VisitDate.Value.ToString("yyyy-MM-dd"), (asd.Count-asd.Where(x=>x.FreeID!=null).Count())*packagematch.FeePerPerson+"EUR", "另存CSV");
            }
            if (jobTitle == "目前使用人員：旅行社管理員")
            {
                TravelCaseDataGridView.Rows.Clear();
                var ppapa = caseDataTable.AsEnumerable().Where(x => x.Field<string>("旅行社名稱") == additionalInfo).CopyToDataTable();
                TravelCaseDataGridView.Rows.Add(ppapa.Rows[0][0], ppapa.Rows[0][1], ppapa.Rows[0][2], ppapa.Rows[0][3], ppapa.Rows[0][4], ppapa.Rows[0][5], ppapa.Rows[0][6], ppapa.Rows[0][7]);
            }
            else
            {
                TravelCaseDataGridView.Rows.Clear();
                for (int i = 0; i < caseDataTable.Rows.Count; i++)
                    TravelCaseDataGridView.Rows.Add(caseDataTable.Rows[i][0], caseDataTable.Rows[i][1], caseDataTable.Rows[i][2], caseDataTable.Rows[i][3], caseDataTable.Rows[i][4], caseDataTable.Rows[i][5], caseDataTable.Rows[i][6], caseDataTable.Rows[i][7]);
            }
        }
        private void InfoCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (InfoCheckbox.Checked == false)
                LoadGroupRegistrations();
            else
            {
                filteredResults= filteredResults.AsEnumerable().Where(x => x.Field<string>("狀態") == "銷售中").CopyToDataTable();
                caseshow();
            }
        }
        private void TravelCaseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == CaseDatagridview.Columns[7].Index && e.RowIndex >= 0)
            {
                string textInRow = TravelCaseDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                int textInRow1 = TravelCaseDataGridView.SelectedRows[0].Index;
                var aall = entities.GroupRegistrationVisitors.ToList().Where(x => x.GroupRegistrationID.ToString() == groupid[textInRow1].ToString()).Select(x => new
                {
                    序號 = x.No,
                    參觀者號碼 = x.VisitorID,
                    姓名 = x.VisitorName,
                    性別 = x.Gender,
                    生日 = x.Birthdate,
                    Email = x.EMail,
                    免費資格項目 = x.FreeQualification == null ? "" : x.FreeQualification.FreeItem
                }).ToList();
                using (StreamWriter sw = new StreamWriter(@"C:\Users\USER\Desktop\write.csv")) 
                {
                    sw.WriteLine("序號,參觀者密碼,姓名,性別,生日,Email,免費資格項目");
                    foreach (var item in aall)
                        sw.WriteLine($"{item.序號},{item.參觀者號碼},{item.姓名},{item.性別},{item.生日},{item.Email},{item.免費資格項目}");
                }
                MessageBox.Show("匯出成功");
            }
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            CaseDatagridview.Rows.Clear();
            if (CaseTextbox.Text != "")
                try
                {
                    filteredResults = filteredResults.AsEnumerable().Where(x => x.Field<string>("套裝名稱").Contains(CaseTextbox.Text)).CopyToDataTable();
                    caseshow();
                }
                catch
                {
                    MessageBox.Show("找不到");
                }
            else
                LoadGroupRegistrations();
        }
    }
}