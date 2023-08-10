namespace LouvreGRS
{
    partial class Login
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.AccountPanel = new System.Windows.Forms.Panel();
            this.AccountTextbox = new System.Windows.Forms.TextBox();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.NumberPanel = new System.Windows.Forms.Panel();
            this.NumberTextbox = new System.Windows.Forms.TextBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2.SuspendLayout();
            this.AccountPanel.SuspendLayout();
            this.NumberPanel.SuspendLayout();
            this.PasswordPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.ErrorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.AccountPanel);
            this.flowLayoutPanel2.Controls.Add(this.NumberPanel);
            this.flowLayoutPanel2.Controls.Add(this.PasswordPanel);
            this.flowLayoutPanel2.Controls.Add(this.LoginPanel);
            this.flowLayoutPanel2.Controls.Add(this.ErrorPanel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(184, 50);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(908, 555);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // AccountPanel
            // 
            this.AccountPanel.Controls.Add(this.AccountTextbox);
            this.AccountPanel.Controls.Add(this.AccountLabel);
            this.AccountPanel.Location = new System.Drawing.Point(3, 3);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Size = new System.Drawing.Size(905, 52);
            this.AccountPanel.TabIndex = 14;
            // 
            // AccountTextbox
            // 
            this.AccountTextbox.Font = new System.Drawing.Font("Arial", 20F);
            this.AccountTextbox.Location = new System.Drawing.Point(308, 3);
            this.AccountTextbox.Name = "AccountTextbox";
            this.AccountTextbox.Size = new System.Drawing.Size(320, 46);
            this.AccountTextbox.TabIndex = 1;
            this.AccountTextbox.TextChanged += new System.EventHandler(this.AccountTextbox_TextChanged);
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Font = new System.Drawing.Font("Arial", 22F);
            this.AccountLabel.Location = new System.Drawing.Point(8, 3);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(294, 42);
            this.AccountLabel.TabIndex = 0;
            this.AccountLabel.Text = "帳號/員工編號：";
            // 
            // NumberPanel
            // 
            this.NumberPanel.Controls.Add(this.NumberTextbox);
            this.NumberPanel.Controls.Add(this.NumberLabel);
            this.NumberPanel.Location = new System.Drawing.Point(3, 61);
            this.NumberPanel.Name = "NumberPanel";
            this.NumberPanel.Size = new System.Drawing.Size(905, 52);
            this.NumberPanel.TabIndex = 15;
            // 
            // NumberTextbox
            // 
            this.NumberTextbox.Font = new System.Drawing.Font("Arial", 20F);
            this.NumberTextbox.Location = new System.Drawing.Point(308, 3);
            this.NumberTextbox.Name = "NumberTextbox";
            this.NumberTextbox.Size = new System.Drawing.Size(320, 46);
            this.NumberTextbox.TabIndex = 1;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Arial", 22F);
            this.NumberLabel.Location = new System.Drawing.Point(18, 3);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(284, 42);
            this.NumberLabel.TabIndex = 0;
            this.NumberLabel.Text = "政府立案編號：";
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.Controls.Add(this.PasswordTextbox);
            this.PasswordPanel.Controls.Add(this.PasswordLabel);
            this.PasswordPanel.Location = new System.Drawing.Point(3, 119);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(905, 52);
            this.PasswordPanel.TabIndex = 16;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Font = new System.Drawing.Font("Arial", 20F);
            this.PasswordTextbox.Location = new System.Drawing.Point(308, 3);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(320, 46);
            this.PasswordTextbox.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial", 22F);
            this.PasswordLabel.Location = new System.Drawing.Point(170, 3);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(132, 42);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "密碼：";
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.LoginBtn);
            this.LoginPanel.Location = new System.Drawing.Point(3, 177);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(905, 127);
            this.LoginPanel.TabIndex = 17;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Arial", 20F);
            this.LoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.LoginBtn.Location = new System.Drawing.Point(308, 3);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(320, 104);
            this.LoginBtn.TabIndex = 11;
            this.LoginBtn.Text = "確認登入";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.Controls.Add(this.ErrorLabel);
            this.ErrorPanel.Location = new System.Drawing.Point(3, 310);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Size = new System.Drawing.Size(905, 156);
            this.ErrorPanel.TabIndex = 18;
            this.ErrorPanel.Visible = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Arial", 20F);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(3, 57);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(187, 39);
            this.ErrorLabel.TabIndex = 0;
            this.ErrorLabel.Text = "查無此帳號";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 830);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.AccountPanel.ResumeLayout(false);
            this.AccountPanel.PerformLayout();
            this.NumberPanel.ResumeLayout(false);
            this.NumberPanel.PerformLayout();
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.ErrorPanel.ResumeLayout(false);
            this.ErrorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel AccountPanel;
        private System.Windows.Forms.TextBox AccountTextbox;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.Panel NumberPanel;
        private System.Windows.Forms.TextBox NumberTextbox;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Panel ErrorPanel;
        private System.Windows.Forms.Label ErrorLabel;
    }
}