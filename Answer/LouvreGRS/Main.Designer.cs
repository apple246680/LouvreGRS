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
            this.icon = new System.Windows.Forms.PictureBox();
            this.top_bard = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.title_lab = new System.Windows.Forms.Label();
            this.down_bard = new System.Windows.Forms.Panel();
            this.joblable = new System.Windows.Forms.Label();
            this.login_logout = new System.Windows.Forms.Button();
            this.pict1 = new System.Windows.Forms.PictureBox();
            this.pict2 = new System.Windows.Forms.PictureBox();
            this.feedback_btn = new System.Windows.Forms.Button();
            this.form_shower = new System.Windows.Forms.Panel();
            this.timenow = new System.Windows.Forms.Timer(this.components);
            this.AccountViewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.top_bard.SuspendLayout();
            this.down_bard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict2)).BeginInit();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(3, 0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(40, 40);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // top_bard
            // 
            this.top_bard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.top_bard.Controls.Add(this.AccountViewBtn);
            this.top_bard.Controls.Add(this.exit_btn);
            this.top_bard.Controls.Add(this.title_lab);
            this.top_bard.Controls.Add(this.icon);
            this.top_bard.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_bard.Location = new System.Drawing.Point(0, 0);
            this.top_bard.Name = "top_bard";
            this.top_bard.Size = new System.Drawing.Size(1154, 52);
            this.top_bard.TabIndex = 1;
            this.top_bard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_bard_MouseDown);
            this.top_bard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_bard_MouseMove);
            // 
            // exit_btn
            // 
            this.exit_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Arial", 15F);
            this.exit_btn.Location = new System.Drawing.Point(1077, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 50);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.TabStop = false;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // title_lab
            // 
            this.title_lab.AutoSize = true;
            this.title_lab.Font = new System.Drawing.Font("Arial", 20F);
            this.title_lab.Location = new System.Drawing.Point(49, 0);
            this.title_lab.Name = "title_lab";
            this.title_lab.Size = new System.Drawing.Size(213, 39);
            this.title_lab.TabIndex = 1;
            this.title_lab.Text = "Louvre GRS-";
            // 
            // down_bard
            // 
            this.down_bard.BackColor = System.Drawing.Color.Black;
            this.down_bard.Controls.Add(this.joblable);
            this.down_bard.Controls.Add(this.login_logout);
            this.down_bard.Controls.Add(this.pict1);
            this.down_bard.Controls.Add(this.pict2);
            this.down_bard.Controls.Add(this.feedback_btn);
            this.down_bard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.down_bard.Location = new System.Drawing.Point(0, 485);
            this.down_bard.Name = "down_bard";
            this.down_bard.Size = new System.Drawing.Size(1154, 120);
            this.down_bard.TabIndex = 2;
            // 
            // joblable
            // 
            this.joblable.AutoSize = true;
            this.joblable.Font = new System.Drawing.Font("Arial", 14F);
            this.joblable.ForeColor = System.Drawing.Color.White;
            this.joblable.Location = new System.Drawing.Point(726, 69);
            this.joblable.Name = "joblable";
            this.joblable.Size = new System.Drawing.Size(228, 27);
            this.joblable.TabIndex = 4;
            this.joblable.Text = "目前使用人員：訪客";
            // 
            // login_logout
            // 
            this.login_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.login_logout.FlatAppearance.BorderSize = 0;
            this.login_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_logout.Font = new System.Drawing.Font("Arial", 12F);
            this.login_logout.ForeColor = System.Drawing.Color.White;
            this.login_logout.Location = new System.Drawing.Point(731, 0);
            this.login_logout.Name = "login_logout";
            this.login_logout.Size = new System.Drawing.Size(423, 66);
            this.login_logout.TabIndex = 3;
            this.login_logout.TabStop = false;
            this.login_logout.Text = "登入";
            this.login_logout.UseVisualStyleBackColor = false;
            this.login_logout.Click += new System.EventHandler(this.login_logout_Click);
            // 
            // pict1
            // 
            this.pict1.Image = ((System.Drawing.Image)(resources.GetObject("pict1.Image")));
            this.pict1.Location = new System.Drawing.Point(365, 3);
            this.pict1.Name = "pict1";
            this.pict1.Size = new System.Drawing.Size(360, 120);
            this.pict1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict1.TabIndex = 2;
            this.pict1.TabStop = false;
            // 
            // pict2
            // 
            this.pict2.Image = ((System.Drawing.Image)(resources.GetObject("pict2.Image")));
            this.pict2.Location = new System.Drawing.Point(254, -3);
            this.pict2.Name = "pict2";
            this.pict2.Size = new System.Drawing.Size(120, 120);
            this.pict2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict2.TabIndex = 1;
            this.pict2.TabStop = false;
            // 
            // feedback_btn
            // 
            this.feedback_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.feedback_btn.FlatAppearance.BorderSize = 0;
            this.feedback_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedback_btn.Font = new System.Drawing.Font("Arial", 15F);
            this.feedback_btn.ForeColor = System.Drawing.Color.White;
            this.feedback_btn.Location = new System.Drawing.Point(0, 0);
            this.feedback_btn.Name = "feedback_btn";
            this.feedback_btn.Size = new System.Drawing.Size(181, 120);
            this.feedback_btn.TabIndex = 0;
            this.feedback_btn.TabStop = false;
            this.feedback_btn.Text = "回饋意見😀";
            this.feedback_btn.UseVisualStyleBackColor = true;
            this.feedback_btn.Click += new System.EventHandler(this.feedback_btn_Click);
            // 
            // form_shower
            // 
            this.form_shower.BackColor = System.Drawing.Color.Gray;
            this.form_shower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_shower.Location = new System.Drawing.Point(0, 52);
            this.form_shower.Name = "form_shower";
            this.form_shower.Size = new System.Drawing.Size(1154, 433);
            this.form_shower.TabIndex = 3;
            // 
            // timenow
            // 
            this.timenow.Interval = 1;
            this.timenow.Tick += new System.EventHandler(this.timenow_Tick);
            // 
            // AccountViewBtn
            // 
            this.AccountViewBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.AccountViewBtn.FlatAppearance.BorderSize = 0;
            this.AccountViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountViewBtn.Font = new System.Drawing.Font("Arial", 15F);
            this.AccountViewBtn.Location = new System.Drawing.Point(870, 0);
            this.AccountViewBtn.Name = "AccountViewBtn";
            this.AccountViewBtn.Size = new System.Drawing.Size(207, 50);
            this.AccountViewBtn.TabIndex = 3;
            this.AccountViewBtn.TabStop = false;
            this.AccountViewBtn.Text = "帳號檢視及篩選";
            this.AccountViewBtn.UseVisualStyleBackColor = true;
            this.AccountViewBtn.Click += new System.EventHandler(this.AccountViewBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 605);
            this.Controls.Add(this.form_shower);
            this.Controls.Add(this.down_bard);
            this.Controls.Add(this.top_bard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.top_bard.ResumeLayout(false);
            this.top_bard.PerformLayout();
            this.down_bard.ResumeLayout(false);
            this.down_bard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Panel top_bard;
        private System.Windows.Forms.Label title_lab;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel down_bard;
        private System.Windows.Forms.PictureBox pict2;
        private System.Windows.Forms.Button feedback_btn;
        private System.Windows.Forms.PictureBox pict1;
        private System.Windows.Forms.Label joblable;
        private System.Windows.Forms.Button login_logout;
        private System.Windows.Forms.Panel form_shower;
        private System.Windows.Forms.Timer timenow;
        private System.Windows.Forms.Button AccountViewBtn;
    }
}

