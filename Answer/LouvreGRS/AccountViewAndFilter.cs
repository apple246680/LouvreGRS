using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public void Showdata()
        {
            var datatable=new DataTable();
            datatable.Columns.Add("登入帳號");
            datatable.Columns.Add("姓名");
            datatable.Columns.Add("是否為館內人員");
            datatable.Columns.Add("所屬旅行社");
            datatable.Columns.Add("角色");
            datatable.Columns.Add("帳號狀態");
            foreach (var item in entities.AccountDatas)
            {
                string isstaff = "";
                string travel = "";
                string job = "";
                string Status = "";
                var a = entities.TravelAgencyUserDatas.FirstOrDefault(x => x.AccountID == item.ID);
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
            AccountViewAndFilterDataGridView.DataSource = datatable;
        }
        private void AccountViewAndFilter_Load(object sender, EventArgs e)
        {
            Showdata();
        }
    }
}
