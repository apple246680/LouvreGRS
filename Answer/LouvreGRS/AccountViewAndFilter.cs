using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        LouvreGRS_ANMEntities Entities = new LouvreGRS_ANMEntities();
        public void Reload()
        {
            IsstaffComobox.SelectedIndex = 0;
            StatusComobox.SelectedIndex = 0;
            FilterButton_Click(null, null);
        }
        private void FilterButton_Click(object sender, EventArgs e)
        {
            var match = Entities.AccountDatas.Select(x => new {
                登入帳號 = x.LoginAccount,
                姓名 = x.LastName + " " + x.FirstName,
                是否為館內人員 = x.TravelAgencyUserDatas.Any() ? "否" : "是",
                所屬旅行社 = x.TravelAgencyUserDatas.Any() ? x.TravelAgencyUserDatas.Select(y => y.TravelAgencyData.Name).FirstOrDefault() : "N/A",
                角色 = x.TravelAgencyUserDatas.Any() ? x.TravelAgencyUserDatas.Select(y=>y.Type).FirstOrDefault()==1?"旅行社管理員":"導遊":x.StaffData.JobTitle,
                帳號狀態 = x.Status == 0 ? "關閉" : "正常"
            }).ToList();
            if (!string.IsNullOrEmpty(AccountFilterTextbox.Text))
               match= match.Where(x=>x.登入帳號==AccountFilterTextbox.Text).ToList();
            else
            {
                if (!string.IsNullOrEmpty(LastNameTextbox.Text))
                   match= match.Where(x => x.姓名.Split(' ')[0].Contains(LastNameTextbox.Text)).ToList();
                if (!string.IsNullOrEmpty(FirstNameTextbox.Text))
                   match= match.Where(x => x.姓名.Split(' ')[1].Contains(FirstNameTextbox.Text)).ToList();
                if(IsstaffComobox.SelectedIndex==1)
                    match=match.Where(x=>x.是否為館內人員=="是").ToList();
                else if (IsstaffComobox.SelectedIndex==2)
                    match = match.Where(x => x.是否為館內人員 == "否").ToList();
                if(StatusComobox.SelectedIndex>0)
                    match = match.Where(x => x.帳號狀態 == StatusComobox.Text).ToList();
            }
            AccountViewAndFilterDataGridView.DataSource = match;
        }
        private void AccountFilterTextbox_TextChanged(object sender, EventArgs e)
        {
            LastNameTextbox.Enabled = AccountFilterTextbox.Text == "";
            FirstNameTextbox.Enabled = AccountFilterTextbox.Text == "";
            IsstaffComobox.Enabled = AccountFilterTextbox.Text == "";
            StatusComobox.Enabled = AccountFilterTextbox.Text == "";
            if (AccountFilterTextbox.Text != "")
            {
                LastNameTextbox.Text = string.Empty;
                FirstNameTextbox.Text = string.Empty;
                IsstaffComobox.SelectedIndex = -1;
                StatusComobox.SelectedIndex = -1;
            }
            else
            {
                IsstaffComobox.SelectedIndex = 0;
                StatusComobox.SelectedIndex = 0;
            }

        }

        private async void AccountViewAndFilter_Load(object sender, EventArgs e)
        {
            IsstaffComobox.SelectedIndex = 0;
            StatusComobox.SelectedIndex = 0;
        }
    }
}