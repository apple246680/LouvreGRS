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
            this.LastNameTextbox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.IsstaffLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.IsstaffComobox = new System.Windows.Forms.ComboBox();
            this.StatusComobox = new System.Windows.Forms.ComboBox();
            this.WaitLable = new System.Windows.Forms.Label();
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AccountViewAndFilterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountViewAndFilterDataGridView
            // 
            this.AccountViewAndFilterDataGridView.AllowUserToAddRows = false;
            this.AccountViewAndFilterDataGridView.AllowUserToDeleteRows = false;
            this.AccountViewAndFilterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountViewAndFilterDataGridView.Location = new System.Drawing.Point(1, 91);
            this.AccountViewAndFilterDataGridView.Name = "AccountViewAndFilterDataGridView";
            this.AccountViewAndFilterDataGridView.ReadOnly = true;
            this.AccountViewAndFilterDataGridView.RowHeadersWidth = 51;
            this.AccountViewAndFilterDataGridView.RowTemplate.Height = 27;
            this.AccountViewAndFilterDataGridView.Size = new System.Drawing.Size(1191, 897);
            this.AccountViewAndFilterDataGridView.TabIndex = 0;
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Arial", 16F);
            this.FilterButton.Location = new System.Drawing.Point(929, 10);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(240, 69);
            this.FilterButton.TabIndex = 1;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // AccountFilterLabel
            // 
            this.AccountFilterLabel.AutoSize = true;
            this.AccountFilterLabel.Font = new System.Drawing.Font("Arial", 16F);
            this.AccountFilterLabel.Location = new System.Drawing.Point(22, 16);
            this.AccountFilterLabel.Name = "AccountFilterLabel";
            this.AccountFilterLabel.Size = new System.Drawing.Size(126, 32);
            this.AccountFilterLabel.TabIndex = 2;
            this.AccountFilterLabel.Text = "帳號篩選";
            // 
            // AccountFilterTextbox
            // 
            this.AccountFilterTextbox.Font = new System.Drawing.Font("Arial", 16F);
            this.AccountFilterTextbox.Location = new System.Drawing.Point(17, 48);
            this.AccountFilterTextbox.Name = "AccountFilterTextbox";
            this.AccountFilterTextbox.Size = new System.Drawing.Size(156, 38);
            this.AccountFilterTextbox.TabIndex = 3;
            this.AccountFilterTextbox.TextChanged += new System.EventHandler(this.AccountFilterTextbox_TextChanged);
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.Font = new System.Drawing.Font("Arial", 16F);
            this.LastNameTextbox.Location = new System.Drawing.Point(193, 48);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.Size = new System.Drawing.Size(156, 38);
            this.LastNameTextbox.TabIndex = 5;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Arial", 16F);
            this.LastNameLabel.Location = new System.Drawing.Point(198, 16);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(126, 32);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "部分姓氏";
            // 
            // IsstaffLabel
            // 
            this.IsstaffLabel.AutoSize = true;
            this.IsstaffLabel.Font = new System.Drawing.Font("Arial", 16F);
            this.IsstaffLabel.Location = new System.Drawing.Point(606, 10);
            this.IsstaffLabel.Name = "IsstaffLabel";
            this.IsstaffLabel.Size = new System.Drawing.Size(126, 32);
            this.IsstaffLabel.TabIndex = 8;
            this.IsstaffLabel.Text = "人員別：";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Arial", 16F);
            this.StatusLabel.Location = new System.Drawing.Point(769, 14);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(154, 32);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.Text = "帳號狀態：";
            // 
            // IsstaffComobox
            // 
            this.IsstaffComobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsstaffComobox.Font = new System.Drawing.Font("Arial", 16F);
            this.IsstaffComobox.FormattingEnabled = true;
            this.IsstaffComobox.Items.AddRange(new object[] {
            "全部",
            "館內人員",
            "旅行社人員"});
            this.IsstaffComobox.Location = new System.Drawing.Point(600, 47);
            this.IsstaffComobox.Name = "IsstaffComobox";
            this.IsstaffComobox.Size = new System.Drawing.Size(150, 40);
            this.IsstaffComobox.TabIndex = 10;
            // 
            // StatusComobox
            // 
            this.StatusComobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComobox.Font = new System.Drawing.Font("Arial", 16F);
            this.StatusComobox.FormattingEnabled = true;
            this.StatusComobox.Items.AddRange(new object[] {
            "全部",
            "正常",
            "關閉"});
            this.StatusComobox.Location = new System.Drawing.Point(773, 45);
            this.StatusComobox.Name = "StatusComobox";
            this.StatusComobox.Size = new System.Drawing.Size(150, 40);
            this.StatusComobox.TabIndex = 11;
            // 
            // WaitLable
            // 
            this.WaitLable.AutoSize = true;
            this.WaitLable.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.WaitLable.Font = new System.Drawing.Font("Arial", 80F);
            this.WaitLable.ForeColor = System.Drawing.Color.Red;
            this.WaitLable.Location = new System.Drawing.Point(365, 312);
            this.WaitLable.Name = "WaitLable";
            this.WaitLable.Size = new System.Drawing.Size(465, 150);
            this.WaitLable.TabIndex = 12;
            this.WaitLable.Text = "請稍等";
            this.WaitLable.Visible = false;
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Font = new System.Drawing.Font("Arial", 16F);
            this.FirstNameTextbox.Location = new System.Drawing.Point(358, 46);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(156, 38);
            this.FirstNameTextbox.TabIndex = 14;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Arial", 16F);
            this.FirstNameLabel.Location = new System.Drawing.Point(363, 14);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(126, 32);
            this.FirstNameLabel.TabIndex = 13;
            this.FirstNameLabel.Text = "部分姓名";
            // 
            // AccountViewAndFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1000);
            this.Controls.Add(this.FirstNameTextbox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.WaitLable);
            this.Controls.Add(this.StatusComobox);
            this.Controls.Add(this.IsstaffComobox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.IsstaffLabel);
            this.Controls.Add(this.LastNameTextbox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.AccountFilterTextbox);
            this.Controls.Add(this.AccountFilterLabel);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.AccountViewAndFilterDataGridView);
            this.Font = new System.Drawing.Font("Arial", 9F);
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
        private System.Windows.Forms.TextBox LastNameTextbox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label IsstaffLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox IsstaffComobox;
        private System.Windows.Forms.ComboBox StatusComobox;
        private System.Windows.Forms.Label WaitLable;
        private System.Windows.Forms.TextBox FirstNameTextbox;
        private System.Windows.Forms.Label FirstNameLabel;
    }
}