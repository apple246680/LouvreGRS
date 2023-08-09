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
        public void back()
        {
            this.form_shower.Controls.Clear();
        }
        static public void backstatic() 
        {
            ins.back();
        }
        public void job(string jobtitle) 
        {
            joblable.Text = $"目前使用人員：{jobtitle}";
            login_logout.Text = "登出";
        }
        static public void jobstatic(string jobtitle)
        {
            ins.job(jobtitle);
        }
        private Point mouseDownLocation;
        Feedback feedbackform = new Feedback();
        Login loginform=new Login();
        private void login_logout_Click(object sender, EventArgs e)
        {
            if (login_logout.Text == "登入")
            {
                form_shower.Controls.Clear();
                loginform.TopLevel = false;
                this.form_shower.Controls.Add(loginform);
                loginform.reset();
                loginform.Show();
            }
            else
            {
                joblable.Text = "目前使用人員：訪客";
                login_logout.Text = "登入";
            }
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void top_bard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mouseDownLocation.X;
                int dy = e.Y - mouseDownLocation.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }
        private void top_bard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mouseDownLocation = e.Location;
        }

        private void feedback_btn_Click(object sender, EventArgs e)
        {
            form_shower.Controls.Clear();
            feedbackform.TopLevel = false;
            this.form_shower.Controls.Add(feedbackform);
            feedbackform.reload();
            feedbackform.Show();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            timenow.Start();
        }
        private void timenow_Tick(object sender, EventArgs e)
        {
            title_lab.Text = $"Louvre GRS-{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}";
            AccountViewBtn.Visible = joblable.Text == "目前使用人員：System Administrator";
        }
        AccountViewAndFilter accountViewAndFilter=new AccountViewAndFilter();
        private void AccountViewBtn_Click(object sender, EventArgs e)
        {
            form_shower.Controls.Clear();
            accountViewAndFilter.TopLevel = false;
            this.form_shower.Controls.Add(accountViewAndFilter);
            accountViewAndFilter.Show();
        }
    }
}
