namespace LouvreGRS
{
    partial class AccountViewAndFilter
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
            this.AccountViewAndFilterDataGridView = new System.Windows.Forms.DataGridView();
            this.FilterButton = new System.Windows.Forms.Button();
            this.AccountFilterLabel = new System.Windows.Forms.Label();
            this.AccountFilterTextbox = new System.Windows.Forms.TextBox();
            this.SurnameTextbox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.IsstaffLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.IsstaffComobox = new System.Windows.Forms.ComboBox();
            this.StatusComobox = new System.Windows.Forms.ComboBox();
            this.WaitLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AccountViewAndFilterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountViewAndFilterDataGridView
            // 
            this.AccountViewAndFilterDataGridView.AllowUserToAddRows = false;
            this.AccountViewAndFilterDataGridView.AllowUserToDeleteRows = false;
            this.AccountViewAndFilterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountViewAndFilterDataGridView.Location = new System.Drawing.Point(1, 80);
            this.AccountViewAndFilterDataGridView.Name = "AccountViewAndFilterDataGridView";
            this.AccountViewAndFilterDataGridView.ReadOnly = true;
            this.AccountViewAndFilterDataGridView.RowHeadersWidth = 51;
            this.AccountViewAndFilterDataGridView.RowTemplate.Height = 27;
            this.AccountViewAndFilterDataGridView.Size = new System.Drawing.Size(1151, 354);
            this.AccountViewAndFilterDataGridView.TabIndex = 0;
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.FilterButton.Location = new System.Drawing.Point(912, 13);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(240, 61);
            this.FilterButton.TabIndex = 1;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // AccountFilterLabel
            // 
            this.AccountFilterLabel.AutoSize = true;
            this.AccountFilterLabel.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.AccountFilterLabel.Location = new System.Drawing.Point(22, 14);
            this.AccountFilterLabel.Name = "AccountFilterLabel";
            this.AccountFilterLabel.Size = new System.Drawing.Size(112, 25);
            this.AccountFilterLabel.TabIndex = 2;
            this.AccountFilterLabel.Text = "帳號篩選";
            // 
            // AccountFilterTextbox
            // 
            this.AccountFilterTextbox.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.AccountFilterTextbox.Location = new System.Drawing.Point(17, 42);
            this.AccountFilterTextbox.Name = "AccountFilterTextbox";
            this.AccountFilterTextbox.Size = new System.Drawing.Size(156, 37);
            this.AccountFilterTextbox.TabIndex = 3;
            this.AccountFilterTextbox.TextChanged += new System.EventHandler(this.AccountFilterTextbox_TextChanged);
            // 
            // SurnameTextbox
            // 
            this.SurnameTextbox.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.SurnameTextbox.Location = new System.Drawing.Point(193, 42);
            this.SurnameTextbox.Name = "SurnameTextbox";
            this.SurnameTextbox.Size = new System.Drawing.Size(156, 37);
            this.SurnameTextbox.TabIndex = 5;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.SurnameLabel.Location = new System.Drawing.Point(198, 14);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(112, 25);
            this.SurnameLabel.TabIndex = 4;
            this.SurnameLabel.Text = "部分姓名";
            // 
            // IsstaffLabel
            // 
            this.IsstaffLabel.AutoSize = true;
            this.IsstaffLabel.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.IsstaffLabel.Location = new System.Drawing.Point(606, 9);
            this.IsstaffLabel.Name = "IsstaffLabel";
            this.IsstaffLabel.Size = new System.Drawing.Size(112, 25);
            this.IsstaffLabel.TabIndex = 8;
            this.IsstaffLabel.Text = "人員別：";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.StatusLabel.Location = new System.Drawing.Point(769, 13);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(137, 25);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.Text = "帳號狀態：";
            // 
            // IsstaffComobox
            // 
            this.IsstaffComobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsstaffComobox.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.IsstaffComobox.FormattingEnabled = true;
            this.IsstaffComobox.Items.AddRange(new object[] {
            "全部",
            "館內人員",
            "旅行社人員"});
            this.IsstaffComobox.Location = new System.Drawing.Point(600, 41);
            this.IsstaffComobox.Name = "IsstaffComobox";
            this.IsstaffComobox.Size = new System.Drawing.Size(150, 33);
            this.IsstaffComobox.TabIndex = 10;
            // 
            // StatusComobox
            // 
            this.StatusComobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComobox.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.StatusComobox.FormattingEnabled = true;
            this.StatusComobox.Items.AddRange(new object[] {
            "全部",
            "正常",
            "關閉"});
            this.StatusComobox.Location = new System.Drawing.Point(756, 41);
            this.StatusComobox.Name = "StatusComobox";
            this.StatusComobox.Size = new System.Drawing.Size(150, 33);
            this.StatusComobox.TabIndex = 11;
            // 
            // WaitLable
            // 
            this.WaitLable.AutoSize = true;
            this.WaitLable.BackColor = System.Drawing.Color.Transparent;
            this.WaitLable.Font = new System.Drawing.Font("PMingLiU", 70F);
            this.WaitLable.ForeColor = System.Drawing.Color.Red;
            this.WaitLable.Location = new System.Drawing.Point(391, 187);
            this.WaitLable.Name = "WaitLable";
            this.WaitLable.Size = new System.Drawing.Size(401, 117);
            this.WaitLable.TabIndex = 12;
            this.WaitLable.Text = "請稍等";
            // 
            // AccountViewAndFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 433);
            this.Controls.Add(this.WaitLable);
            this.Controls.Add(this.StatusComobox);
            this.Controls.Add(this.IsstaffComobox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.IsstaffLabel);
            this.Controls.Add(this.SurnameTextbox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.AccountFilterTextbox);
            this.Controls.Add(this.AccountFilterLabel);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.AccountViewAndFilterDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountViewAndFilter";
            this.Text = "AccountViewAndFilter";
            this.Load += new System.EventHandler(this.AccountViewAndFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountViewAndFilterDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AccountViewAndFilterDataGridView;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Label AccountFilterLabel;
        private System.Windows.Forms.TextBox AccountFilterTextbox;
        private System.Windows.Forms.TextBox SurnameTextbox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label IsstaffLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox IsstaffComobox;
        private System.Windows.Forms.ComboBox StatusComobox;
        private System.Windows.Forms.Label WaitLable;
    }
}