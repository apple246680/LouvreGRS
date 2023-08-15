using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LouvreGRS
{
    public partial class Main : Form
    {
        static Main ins;
        public Main()
        {
            ins= this;
            InitializeComponent();
        }
        string value = "";
        public void Back(string retrunvalue)
        {
            this.form_shower.Controls.Clear();
            value = retrunvalue;
        }
        static public void Backstatic(string aa) 
        {
            ins.Back(aa);
        }
        public void Job(string jobtitle) 
        {
            JobLable.Text = $"目前使用人員：{jobtitle}";
            LoginLogoutBtn.Text = "登出";
        }
        static public void Jobstatic(string jobtitle)
        {
            ins.Job(jobtitle);
        }
        private Point mouseDownLocation;
        Feedback feedbackform = new Feedback();
        Login loginform=new Login();
        private void Main_Load(object sender, EventArgs e)
        {
            TimeNow.Start();
            IsJob();
            LoginLogout_Click(null,null);
        }
        AccountViewAndFilter accountViewAndFilter=new AccountViewAndFilter();
        int i = 0;
        private async void AccountViewBtn_Click(object sender, EventArgs e)
        {
            form_shower.Controls.Clear();
            accountViewAndFilter.TopLevel = false;
            this.form_shower.Controls.Add(accountViewAndFilter);
            i++;
            if (i > 1) {
                accountViewAndFilter.Reload();
                i = 1;
            }
            accountViewAndFilter.Show();
        }
        GroupRegistrationManagement GroupRegistrationManagement = new GroupRegistrationManagement();
        private void RegistrationManagement_Click(object sender, EventArgs e)
        {
            form_shower.Controls.Clear();
            GroupRegistrationManagement.TopLevel = false;
            this.form_shower.Controls.Add(GroupRegistrationManagement);
            GroupRegistrationManagement.Show();
            GroupRegistrationManagement.CheckJobTitleAndSaveData(JobLable.Text,value);
        }
        private void LoginLogout_Click(object sender, EventArgs e)
        {
            if (LoginLogoutBtn.Text == "登入")
            {
                form_shower.Controls.Clear();
                loginform.TopLevel = false;
                this.form_shower.Controls.Add(loginform);
                loginform.Reset();
                loginform.Show();
            }
            else
            {
                JobLable.Text = "目前使用人員：訪客";
                LoginLogoutBtn.Text = "登入";
                form_shower.Controls.Clear();
                IsJob();
            }
        }

        private void FeedbackBtn_Click(object sender, EventArgs e)
        {
            form_shower.Controls.Clear();
            feedbackform.TopLevel = false;
            this.form_shower.Controls.Add(feedbackform);
            feedbackform.Reload();
            feedbackform.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TopBard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mouseDownLocation.X;
                int dy = e.Y - mouseDownLocation.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }
        private void TopBard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mouseDownLocation = e.Location;
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            this.Text = $"Louvre GRS-{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}";
        }
        public void IsJob() {
            AccountViewBtn.Visible = JobLable.Text == "目前使用人員：System Administrator";
            RegistrationManagementBtn.Visible = JobLable.Text == "目前使用人員：System Administrator" || JobLable.Text == "目前使用人員：Guide" || JobLable.Text == "目前使用人員：旅行社管理員";
        }
        static public void StaticIsJob() {
            ins.IsJob();
        }
    }
}
