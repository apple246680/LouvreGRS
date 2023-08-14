namespace LouvreGRS
{
    partial class GroupRegistrationManagement
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
            this.Model1 = new System.Windows.Forms.Panel();
            this.InfoCheckbox = new System.Windows.Forms.CheckBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.CaseTextbox = new System.Windows.Forms.TextBox();
            this.CaseDatagridview = new System.Windows.Forms.DataGridView();
            this.casename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Model2 = new System.Windows.Forms.Panel();
            this.TravelCaseDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ExhibitionLabel = new System.Windows.Forms.Label();
            this.ActivitiesLabel = new System.Windows.Forms.Label();
            this.FeaturesLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CaseLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Model1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaseDatagridview)).BeginInit();
            this.Model2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TravelCaseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Model1
            // 
            this.Model1.Controls.Add(this.InfoCheckbox);
            this.Model1.Controls.Add(this.InfoLabel);
            this.Model1.Controls.Add(this.SearchBtn);
            this.Model1.Controls.Add(this.CaseTextbox);
            this.Model1.Controls.Add(this.CaseDatagridview);
            this.Model1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Model1.Location = new System.Drawing.Point(0, 0);
            this.Model1.Name = "Model1";
            this.Model1.Size = new System.Drawing.Size(1200, 325);
            this.Model1.TabIndex = 0;
            // 
            // InfoCheckbox
            // 
            this.InfoCheckbox.AutoSize = true;
            this.InfoCheckbox.Font = new System.Drawing.Font("Arial", 15F);
            this.InfoCheckbox.Location = new System.Drawing.Point(28, 4);
            this.InfoCheckbox.Name = "InfoCheckbox";
            this.InfoCheckbox.Size = new System.Drawing.Size(320, 32);
            this.InfoCheckbox.TabIndex = 5;
            this.InfoCheckbox.Text = "僅列出販售中的套裝資料";
            this.InfoCheckbox.UseVisualStyleBackColor = true;
            this.InfoCheckbox.CheckedChanged += new System.EventHandler(this.InfoCheckbox_CheckedChanged);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.InfoLabel.Location = new System.Drawing.Point(459, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(123, 28);
            this.InfoLabel.TabIndex = 4;
            this.InfoLabel.Text = "套裝名稱:";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Black;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Arial", 15F);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(869, 0);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(195, 36);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "搜尋";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CaseTextbox
            // 
            this.CaseTextbox.Font = new System.Drawing.Font("Arial", 15F);
            this.CaseTextbox.Location = new System.Drawing.Point(611, 0);
            this.CaseTextbox.Name = "CaseTextbox";
            this.CaseTextbox.Size = new System.Drawing.Size(252, 36);
            this.CaseTextbox.TabIndex = 2;
            // 
            // CaseDatagridview
            // 
            this.CaseDatagridview.AllowUserToAddRows = false;
            this.CaseDatagridview.AllowUserToDeleteRows = false;
            this.CaseDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CaseDatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.casename,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.CaseDatagridview.Location = new System.Drawing.Point(0, 42);
            this.CaseDatagridview.MultiSelect = false;
            this.CaseDatagridview.Name = "CaseDatagridview";
            this.CaseDatagridview.ReadOnly = true;
            this.CaseDatagridview.RowHeadersWidth = 51;
            this.CaseDatagridview.RowTemplate.Height = 27;
            this.CaseDatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CaseDatagridview.Size = new System.Drawing.Size(1200, 283);
            this.CaseDatagridview.TabIndex = 0;
            this.CaseDatagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CaseDatagridview_CellClick);
            // 
            // casename
            // 
            this.casename.HeaderText = "套裝名稱";
            this.casename.MinimumWidth = 6;
            this.casename.Name = "casename";
            this.casename.ReadOnly = true;
            this.casename.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "參觀時段";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "建議參觀時數";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "售價(人)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "最大可報名人數";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "剩餘可報名人數";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "狀態";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "操作";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Model2
            // 
            this.Model2.Controls.Add(this.TravelCaseDataGridView);
            this.Model2.Controls.Add(this.ExhibitionLabel);
            this.Model2.Controls.Add(this.ActivitiesLabel);
            this.Model2.Controls.Add(this.FeaturesLabel);
            this.Model2.Controls.Add(this.panel2);
            this.Model2.Controls.Add(this.CaseLabel);
            this.Model2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Model2.Location = new System.Drawing.Point(0, 295);
            this.Model2.Name = "Model2";
            this.Model2.Size = new System.Drawing.Size(1200, 760);
            this.Model2.TabIndex = 1;
            this.Model2.Visible = false;
            // 
            // TravelCaseDataGridView
            // 
            this.TravelCaseDataGridView.AllowUserToAddRows = false;
            this.TravelCaseDataGridView.AllowUserToDeleteRows = false;
            this.TravelCaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TravelCaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.TravelCaseDataGridView.Location = new System.Drawing.Point(0, 277);
            this.TravelCaseDataGridView.Name = "TravelCaseDataGridView";
            this.TravelCaseDataGridView.ReadOnly = true;
            this.TravelCaseDataGridView.RowHeadersWidth = 51;
            this.TravelCaseDataGridView.RowTemplate.Height = 27;
            this.TravelCaseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TravelCaseDataGridView.Size = new System.Drawing.Size(1200, 480);
            this.TravelCaseDataGridView.TabIndex = 7;
            this.TravelCaseDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TravelCaseDataGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "旅行社名稱";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "旅行社人員";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "狀態";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "付款時間";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "慣用語言";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "參觀日期";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "訂單總額";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 125;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "匯出名單";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Text = "另存CSV";
            this.Column15.Width = 125;
            // 
            // ExhibitionLabel
            // 
            this.ExhibitionLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.ExhibitionLabel.Location = new System.Drawing.Point(3, 159);
            this.ExhibitionLabel.Name = "ExhibitionLabel";
            this.ExhibitionLabel.Size = new System.Drawing.Size(1194, 115);
            this.ExhibitionLabel.TabIndex = 6;
            this.ExhibitionLabel.Text = "關聯展館:\r\n";
            // 
            // ActivitiesLabel
            // 
            this.ActivitiesLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.ActivitiesLabel.Location = new System.Drawing.Point(3, 93);
            this.ActivitiesLabel.Name = "ActivitiesLabel";
            this.ActivitiesLabel.Size = new System.Drawing.Size(1194, 66);
            this.ActivitiesLabel.TabIndex = 5;
            this.ActivitiesLabel.Text = "關聯活動:";
            // 
            // FeaturesLabel
            // 
            this.FeaturesLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.FeaturesLabel.Location = new System.Drawing.Point(4, 54);
            this.FeaturesLabel.Name = "FeaturesLabel";
            this.FeaturesLabel.Size = new System.Drawing.Size(1193, 39);
            this.FeaturesLabel.TabIndex = 4;
            this.FeaturesLabel.Text = "特色:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Location = new System.Drawing.Point(51, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 5);
            this.panel2.TabIndex = 3;
            // 
            // CaseLabel
            // 
            this.CaseLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.CaseLabel.Location = new System.Drawing.Point(4, 4);
            this.CaseLabel.Name = "CaseLabel";
            this.CaseLabel.Size = new System.Drawing.Size(1184, 40);
            this.CaseLabel.TabIndex = 0;
            this.CaseLabel.Text = "套裝:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(0, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 5);
            this.panel1.TabIndex = 2;
            // 
            // GroupRegistrationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Model2);
            this.Controls.Add(this.Model1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupRegistrationManagement";
            this.Text = "GroupRegistrationManagement";
            this.Model1.ResumeLayout(false);
            this.Model1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaseDatagridview)).EndInit();
            this.Model2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TravelCaseDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Model1;
        private System.Windows.Forms.Panel Model2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox CaseTextbox;
        private System.Windows.Forms.DataGridView CaseDatagridview;
        private System.Windows.Forms.Label FeaturesLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CaseLabel;
        private System.Windows.Forms.DataGridView TravelCaseDataGridView;
        private System.Windows.Forms.Label ExhibitionLabel;
        private System.Windows.Forms.Label ActivitiesLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn casename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewButtonColumn Column15;
        private System.Windows.Forms.CheckBox InfoCheckbox;
    }
}