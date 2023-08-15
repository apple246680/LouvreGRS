namespace LouvreGRS
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TopBard = new System.Windows.Forms.Panel();
            this.RegistrationManagementBtn = new System.Windows.Forms.Button();
            this.AccountViewBtn = new System.Windows.Forms.Button();
            this.DownBard = new System.Windows.Forms.Panel();
            this.JobLable = new System.Windows.Forms.Label();
            this.LoginLogoutBtn = new System.Windows.Forms.Button();
            this.Pict1 = new System.Windows.Forms.PictureBox();
            this.Pict2 = new System.Windows.Forms.PictureBox();
            this.Feedback_btn = new System.Windows.Forms.Button();
            this.form_shower = new System.Windows.Forms.Panel();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.TopBard.SuspendLayout();
            this.DownBard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pict1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pict2)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBard
            // 
            this.TopBard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopBard.Controls.Add(this.RegistrationManagementBtn);
            this.TopBard.Controls.Add(this.AccountViewBtn);
            this.TopBard.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBard.Location = new System.Drawing.Point(0, 0);
            this.TopBard.Name = "TopBard";
            this.TopBard.Size = new System.Drawing.Size(1200, 50);
            this.TopBard.TabIndex = 1;
            this.TopBard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBard_MouseDown);
            this.TopBard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBard_MouseMove);
            // 
            // RegistrationManagementBtn
            // 
            this.RegistrationManagementBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.RegistrationManagementBtn.FlatAppearance.BorderSize = 0;
            this.RegistrationManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationManagementBtn.Font = new System.Drawing.Font("Arial", 15F);
            this.RegistrationManagementBtn.Location = new System.Drawing.Point(761, 0);
            this.RegistrationManagementBtn.Name = "RegistrationManagementBtn";
            this.RegistrationManagementBtn.Size = new System.Drawing.Size(230, 48);
            this.RegistrationManagementBtn.TabIndex = 4;
            this.RegistrationManagementBtn.TabStop = false;
            this.RegistrationManagementBtn.Text = "團體報名資料管理";
            this.RegistrationManagementBtn.UseVisualStyleBackColor = true;
            this.RegistrationManagementBtn.Click += new System.EventHandler(this.RegistrationManagement_Click);
            // 
            // AccountViewBtn
            // 
            this.AccountViewBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.AccountViewBtn.FlatAppearance.BorderSize = 0;
            this.AccountViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountViewBtn.Font = new System.Drawing.Font("Arial", 15F);
            this.AccountViewBtn.Location = new System.Drawing.Point(991, 0);
            this.AccountViewBtn.Name = "AccountViewBtn";
            this.AccountViewBtn.Size = new System.Drawing.Size(207, 48);
            this.AccountViewBtn.TabIndex = 3;
            this.AccountViewBtn.TabStop = false;
            this.AccountViewBtn.Text = "帳號檢視及篩選";
            this.AccountViewBtn.UseVisualStyleBackColor = true;
            this.AccountViewBtn.Click += new System.EventHandler(this.AccountViewBtn_Click);
            // 
            // DownBard
            // 
            this.DownBard.BackColor = System.Drawing.Color.Black;
            this.DownBard.Controls.Add(this.JobLable);
            this.DownBard.Controls.Add(this.LoginLogoutBtn);
            this.DownBard.Controls.Add(this.Pict1);
            this.DownBard.Controls.Add(this.Pict2);
            this.DownBard.Controls.Add(this.Feedback_btn);
            this.DownBard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownBard.Location = new System.Drawing.Point(0, 880);
            this.DownBard.Name = "DownBard";
            this.DownBard.Size = new System.Drawing.Size(1200, 120);
            this.DownBard.TabIndex = 2;
            // 
            // JobLable
            // 
            this.JobLable.AutoSize = true;
            this.JobLable.Font = new System.Drawing.Font("Arial", 14F);
            this.JobLable.ForeColor = System.Drawing.Color.White;
            this.JobLable.Location = new System.Drawing.Point(731, 72);
            this.JobLable.Name = "JobLable";
            this.JobLable.Size = new System.Drawing.Size(228, 27);
            this.JobLable.TabIndex = 4;
            this.JobLable.Text = "目前使用人員：訪客";
            // 
            // LoginLogoutBtn
            // 
            this.LoginLogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LoginLogoutBtn.FlatAppearance.BorderSize = 0;
            this.LoginLogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginLogoutBtn.Font = new System.Drawing.Font("Arial", 12F);
            this.LoginLogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LoginLogoutBtn.Location = new System.Drawing.Point(731, 3);
            this.LoginLogoutBtn.Name = "LoginLogoutBtn";
            this.LoginLogoutBtn.Size = new System.Drawing.Size(466, 66);
            this.LoginLogoutBtn.TabIndex = 3;
            this.LoginLogoutBtn.TabStop = false;
            this.LoginLogoutBtn.Text = "登入";
            this.LoginLogoutBtn.UseVisualStyleBackColor = false;
            this.LoginLogoutBtn.Click += new System.EventHandler(this.LoginLogout_Click);
            // 
            // Pict1
            // 
            this.Pict1.Image = ((System.Drawing.Image)(resources.GetObject("Pict1.Image")));
            this.Pict1.Location = new System.Drawing.Point(365, 3);
            this.Pict1.Name = "Pict1";
            this.Pict1.Size = new System.Drawing.Size(360, 120);
            this.Pict1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pict1.TabIndex = 2;
            this.Pict1.TabStop = false;
            // 
            // Pict2
            // 
            this.Pict2.Image = ((System.Drawing.Image)(resources.GetObject("Pict2.Image")));
            this.Pict2.Location = new System.Drawing.Point(254, -3);
            this.Pict2.Name = "Pict2";
            this.Pict2.Size = new System.Drawing.Size(120, 120);
            this.Pict2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pict2.TabIndex = 1;
            this.Pict2.TabStop = false;
            // 
            // Feedback_btn
            // 
            this.Feedback_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Feedback_btn.FlatAppearance.BorderSize = 0;
            this.Feedback_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Feedback_btn.Font = new System.Drawing.Font("Arial", 15F);
            this.Feedback_btn.ForeColor = System.Drawing.Color.White;
            this.Feedback_btn.Location = new System.Drawing.Point(0, 0);
            this.Feedback_btn.Name = "Feedback_btn";
            this.Feedback_btn.Size = new System.Drawing.Size(181, 120);
            this.Feedback_btn.TabIndex = 0;
            this.Feedback_btn.TabStop = false;
            this.Feedback_btn.Text = "回饋意見😀";
            this.Feedback_btn.UseVisualStyleBackColor = true;
            this.Feedback_btn.Click += new System.EventHandler(this.FeedbackBtn_Click);
            // 
            // form_shower
            // 
            this.form_shower.AutoScroll = true;
            this.form_shower.BackColor = System.Drawing.Color.Gray;
            this.form_shower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_shower.Location = new System.Drawing.Point(0, 50);
            this.form_shower.Name = "form_shower";
            this.form_shower.Size = new System.Drawing.Size(1200, 830);
            this.form_shower.TabIndex = 3;
            // 
            // TimeNow
            // 
            this.TimeNow.Interval = 1;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1000);
            this.Controls.Add(this.form_shower);
            this.Controls.Add(this.DownBard);
            this.Controls.Add(this.TopBard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Louvre GRS-";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TopBard.ResumeLayout(false);
            this.DownBard.ResumeLayout(false);
            this.DownBard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pict1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pict2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopBard;
        private System.Windows.Forms.Panel DownBard;
        private System.Windows.Forms.PictureBox Pict2;
        private System.Windows.Forms.Button Feedback_btn;
        private System.Windows.Forms.PictureBox Pict1;
        private System.Windows.Forms.Label JobLable;
        private System.Windows.Forms.Button LoginLogoutBtn;
        private System.Windows.Forms.Panel form_shower;
        private System.Windows.Forms.Timer TimeNow;
        private System.Windows.Forms.Button AccountViewBtn;
        private System.Windows.Forms.Button RegistrationManagementBtn;
    }
}

