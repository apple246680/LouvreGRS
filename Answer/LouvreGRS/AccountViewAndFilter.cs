using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LouvreGRS
{
    public partial class AccountViewAndFilter : Form
    {
        public AccountViewAndFilter()
        {
            InitializeComponent();
        }
        LouvreGRS_ANMEntities entities = new LouvreGRS_ANMEntities();
        DataTable datatable = new DataTable
        {
            Columns =
            {
                new DataColumn("登入帳號"),
                new DataColumn("姓名"),
                new DataColumn("是否為館內人員"),
                new DataColumn("所屬旅行社"),
                new DataColumn("角色"),
                new DataColumn("帳號狀態")
            }
        };
        public async Task Showdata()
        {
            var accountDatas = await entities.AccountDatas.ToListAsync();
            foreach (var item in accountDatas)
            {
                string isstaff = "";
                string travel = "";
                string job = "";
                string Status = "";
                var a = await entities.TravelAgencyUserDatas.FirstOrDefaultAsync(x => x.AccountID == item.ID);
                if (a == null)
                {
                    isstaff = "是";
                    travel = "N/A";
                    job = item.StaffData?.JobTitle ?? "";
                }
                else
                {
                    isstaff = "否";
                    travel = a.TravelAgencyData?.Name ?? "";
                    if (a.Type == 1)
                        job = "管理員";
                    else
                        job = "導遊";
                }
                if (item.Status == 1)
                    Status = "正常";
                else
                    Status = "關閉";
                datatable.Rows.Add(item.LoginAccount, $"{item.FirstName} {item.LastName}", isstaff, travel, job, Status);
            }
            AccountViewAndFilterDataGridView.Invoke(new Action(() => { AccountViewAndFilterDataGridView.DataSource = datatable; }));
        }
        private async void AccountViewAndFilter_Load(object sender, EventArgs e)
        {
            WaitLable.Visible = true;
            await Showdata();
            WaitLable.Visible = false;
            IsstaffComobox.SelectedIndex = 0;
            StatusComobox.SelectedIndex = 0;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
                DataTable filteredDataTable = datatable;
            if (!string.IsNullOrWhiteSpace(AccountFilterTextbox.Text))
                filteredDataTable = filteredDataTable.Select($"登入帳號 = '{AccountFilterTextbox.Text}'").CopyToDataTable();
            else
            {
                if (IsstaffComobox.SelectedIndex!=-1&& IsstaffComobox.SelectedIndex !=0)
                {
                    string a = IsstaffComobox.Text == "館內人員" ? "是" : "否";
                    filteredDataTable = filteredDataTable.Select($"是否為館內人員 = '{a}'").CopyToDataTable();
                }
                if (StatusComobox.SelectedIndex!=-1&&StatusComobox.SelectedIndex!=0)
                    filteredDataTable = filteredDataTable.Select($"帳號狀態 = '{StatusComobox.Text}'").CopyToDataTable();
                if(SurnameTextbox.Text!="")
                   filteredDataTable = filteredDataTable.Select($"姓名 LIKE '*{SurnameTextbox.Text}*'").CopyToDataTable();

            }
            AccountViewAndFilterDataGridView.DataSource = filteredDataTable;
        }
        private void AccountFilterTextbox_TextChanged(object sender, EventArgs e)
        {
            SurnameTextbox.Enabled = AccountFilterTextbox.Text == "";
            IsstaffComobox.Enabled = AccountFilterTextbox.Text == "";
            StatusComobox.Enabled = AccountFilterTextbox.Text == "";
            if (AccountFilterTextbox.Text != "") {
                SurnameTextbox.Text = string.Empty;
                IsstaffComobox.SelectedIndex = -1;
                StatusComobox.SelectedIndex = -1;
            }
            else
            {
                IsstaffComobox.SelectedIndex = 0;
                StatusComobox.SelectedIndex = 0;
            }
            
        }
    }
}

