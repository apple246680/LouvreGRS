using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LouvreGRS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            AccountTextbox.Text = string.Empty;
            NumberTextbox.Text = string.Empty;
            PasswordTextbox.Text = string.Empty;
        }
        LouvreGRS_ANMEntities entities = new LouvreGRS_ANMEntities();
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var match = entities.AccountDatas.FirstOrDefault(x => x.LoginAccount == AccountTextbox.Text);
            var matchnum = entities.StaffDatas.FirstOrDefault(x => x.EmployeeNumber == AccountTextbox.Text);
            if (match != null || matchnum != null)
            {
                ErrorPanel.Visible = false;
                if (NumberPanel.Visible == true)//旅行社管理員
                {
                    if (match.Password != PasswordTextbox.Text)
                    {
                        ErrorLabel.Text = "請輸入正確的管理密碼！！";
                        ErrorPanel.Visible = true;
                    }
                    var checkacc = entities.TravelAgencyUserDatas.FirstOrDefault(x => x.AccountID == match.ID);
                    if (checkacc != null)
                    {
                        var checktrave = entities.TravelAgencyDatas.FirstOrDefault(x => x.ID == checkacc.TravelAgencyID);
                        if (checktrave.GovRegistrationCode == NumberTextbox.Text)
                        {
                            Main.Jobstatic("旅行社管理員");
                            MessageBox.Show($"您好，{match.FirstName} {match.LastName}，歡迎使用羅浮宮團報管理系統，您所代表的旅行社為 {checktrave.Name}。", "登入成功");
                            Main.StaticIsJob();
                            Main.Backstatic(checkacc.TravelAgencyData.Name);
                        }
                        else
                        {
                            ErrorLabel.Text = "您輸入的資料有誤或該帳號無法使用本管理系統！";
                            ErrorPanel.Visible = true;
                        }
                    }
                }
                else
                {
                    if (match != null)//館內員工acc
                    {
                        if (match.Password == PasswordTextbox.Text)
                        {
                            var staffData = entities.StaffDatas.FirstOrDefault(x => x.AccountID == match.ID);
                            if (entities.HallWithStaffs.Any(x => x.AccountID == match.ID))
                            {
                                var duplicateHalls = entities.HallWithStaffs
                                    .Where(x => x.AccountID == match.ID)
                                    .Select(x => x.HallID);
                                var halls = entities.HallDatas
                                    .Where(x => duplicateHalls.Contains(x.ID))
                                    .Select(x => x.KnownName);
                                string home = string.Join("、", halls);
                                if (staffData != null)
                                {
                                    Main.Jobstatic(staffData.JobTitle);
                                    MessageBox.Show($"您好，{match.FirstName} {match.LastName}，歡迎使用館內員工專用系統，您的身分別為 {staffData.JobTitle} ，所負責的展館為 {home} 。", "登入成功");
                                    Main.StaticIsJob();
                                    Main.Backstatic(home);
                                }
                            }
                            else
                            {
                                if (staffData != null)
                                {
                                    Main.Jobstatic(staffData.JobTitle);
                                    MessageBox.Show($"您好，{match.FirstName} {match.LastName}，歡迎使用館內員工專用系統，您的身分別為 {staffData.JobTitle} 。", "登入成功");
                                    Main.StaticIsJob();
                                    Main.Backstatic(null);
                                }
                            }
                        }
                        else
                        {
                            ErrorLabel.Text = "請輸入正確的員工密碼！";
                            ErrorPanel.Visible = true;
                        }
                    }
                    else if (matchnum != null)//館內員工emp
                    {
                        var aaaa = entities.AccountDatas.FirstOrDefault(x => x.ID == matchnum.AccountID);
                        if (aaaa.Password == PasswordTextbox.Text)
                        {
                            if (entities.HallWithStaffs.Any(x => x.AccountID == matchnum.AccountID))
                            {
                                var duplicateHalls = entities.HallWithStaffs
                                   .Where(x => x.AccountID == matchnum.AccountID)
                                   .Select(x => x.HallID);
                                var halls = entities.HallDatas
                                    .Where(x => duplicateHalls.Contains(x.ID))
                                    .Select(x => x.KnownName);
                                string home = string.Join("、", halls);
                                Main.Jobstatic(matchnum.JobTitle);
                                MessageBox.Show($"您好，{aaaa.FirstName} {aaaa.LastName}，歡迎使用館內員工專用系統，您的身分別為 {matchnum.JobTitle}  ，所負責的展館為 {home} 。", "登入成功");
                                Main.StaticIsJob();
                                Main.Backstatic(home);
                            }
                            else
                            {
                                Main.Jobstatic(matchnum.JobTitle);
                                MessageBox.Show($"您好，{aaaa.FirstName} {aaaa.LastName}，歡迎使用館內員工專用系統，您的身分別為 {matchnum.JobTitle}。", "登入成功");
                                Main.StaticIsJob();
                                Main.Backstatic(null);
                            }
                        }
                        else
                        {
                            ErrorLabel.Text = "請輸入正確的員工密碼！";
                            ErrorPanel.Visible = true;
                        }
                    }
                    else//旅行社非管理帳號
                    {
                        ErrorLabel.Text = "您輸入的資料有誤或該帳號無法使用本管理系統！";
                        ErrorPanel.Visible = true;
                        return;
                    }
                }
            }
            else
            {
                ErrorLabel.Text = "查無此帳號";
                ErrorPanel.Visible = true;
                return;
            }
        }
        private void AccountTextbox_TextChanged(object sender, EventArgs e)
        {
            var accountData = entities.AccountDatas.FirstOrDefault(x => x.LoginAccount == AccountTextbox.Text);
            LouvreGRS.TravelAgencyUserData travelAgencyUserData = null;
            if (accountData != null)
                travelAgencyUserData = entities.TravelAgencyUserDatas.FirstOrDefault(x => x.AccountID == accountData.ID && x.Type == 1);
            NumberPanel.Visible = travelAgencyUserData != null;
            if (NumberPanel.Visible == false)
                NumberTextbox.Text = string.Empty;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            NumberPanel.Visible = false;
        }
    }
}
