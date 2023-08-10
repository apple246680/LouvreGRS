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
            this.Model2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CaseDatagridview = new System.Windows.Forms.DataGridView();
            this.InfoLabel1 = new System.Windows.Forms.Label();
            this.CaseTextbox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.CaseLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FeaturesLabel = new System.Windows.Forms.Label();
            this.ActivitiesLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Model1.SuspendLayout();
            this.Model2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaseDatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Model1
            // 
            this.Model1.Controls.Add(this.InfoLabel);
            this.Model1.Controls.Add(this.SearchBtn);
            this.Model1.Controls.Add(this.CaseTextbox);
            this.Model1.Controls.Add(this.InfoLabel1);
            this.Model1.Controls.Add(this.CaseDatagridview);
            this.Model1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Model1.Location = new System.Drawing.Point(0, 0);
            this.Model1.Name = "Model1";
            this.Model1.Size = new System.Drawing.Size(1200, 380);
            this.Model1.TabIndex = 0;
            // 
            // Model2
            // 
            this.Model2.Controls.Add(this.dataGridView1);
            this.Model2.Controls.Add(this.label4);
            this.Model2.Controls.Add(this.ActivitiesLabel);
            this.Model2.Controls.Add(this.FeaturesLabel);
            this.Model2.Controls.Add(this.panel2);
            this.Model2.Controls.Add(this.CaseLabel);
            this.Model2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Model2.Location = new System.Drawing.Point(0, 400);
            this.Model2.Name = "Model2";
            this.Model2.Size = new System.Drawing.Size(1200, 600);
            this.Model2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(0, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 5);
            this.panel1.TabIndex = 2;
            // 
            // CaseDatagridview
            // 
            this.CaseDatagridview.AllowUserToAddRows = false;
            this.CaseDatagridview.AllowUserToDeleteRows = false;
            this.CaseDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CaseDatagridview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CaseDatagridview.Location = new System.Drawing.Point(0, 64);
            this.CaseDatagridview.MultiSelect = false;
            this.CaseDatagridview.Name = "CaseDatagridview";
            this.CaseDatagridview.ReadOnly = true;
            this.CaseDatagridview.RowHeadersWidth = 51;
            this.CaseDatagridview.RowTemplate.Height = 27;
            this.CaseDatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CaseDatagridview.Size = new System.Drawing.Size(1200, 316);
            this.CaseDatagridview.TabIndex = 0;
            this.CaseDatagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CaseDatagridview_CellClick);
            // 
            // InfoLabel1
            // 
            this.InfoLabel1.AutoSize = true;
            this.InfoLabel1.Font = new System.Drawing.Font("Arial", 20F);
            this.InfoLabel1.Location = new System.Drawing.Point(3, 9);
            this.InfoLabel1.Name = "InfoLabel1";
            this.InfoLabel1.Size = new System.Drawing.Size(391, 39);
            this.InfoLabel1.TabIndex = 1;
            this.InfoLabel1.Text = "僅列出販售中的套裝資料";
            // 
            // CaseTextbox
            // 
            this.CaseTextbox.Font = new System.Drawing.Font("Arial", 20F);
            this.CaseTextbox.Location = new System.Drawing.Point(620, 12);
            this.CaseTextbox.Name = "CaseTextbox";
            this.CaseTextbox.Size = new System.Drawing.Size(218, 46);
            this.CaseTextbox.TabIndex = 2;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Black;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Arial", 15F);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(844, 9);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(195, 49);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "搜尋";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Arial", 20F);
            this.InfoLabel.Location = new System.Drawing.Point(452, 9);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(162, 39);
            this.InfoLabel.TabIndex = 4;
            this.InfoLabel.Text = "套裝名稱:";
            // 
            // CaseLabel
            // 
            this.CaseLabel.AutoSize = true;
            this.CaseLabel.Font = new System.Drawing.Font("Arial", 20F);
            this.CaseLabel.Location = new System.Drawing.Point(4, 4);
            this.CaseLabel.Name = "CaseLabel";
            this.CaseLabel.Size = new System.Drawing.Size(94, 39);
            this.CaseLabel.TabIndex = 0;
            this.CaseLabel.Text = "套裝:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Location = new System.Drawing.Point(51, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 5);
            this.panel2.TabIndex = 3;
            // 
            // FeaturesLabel
            // 
            this.FeaturesLabel.AutoSize = true;
            this.FeaturesLabel.Font = new System.Drawing.Font("Arial", 20F);
            this.FeaturesLabel.Location = new System.Drawing.Point(4, 54);
            this.FeaturesLabel.Name = "FeaturesLabel";
            this.FeaturesLabel.Size = new System.Drawing.Size(94, 39);
            this.FeaturesLabel.TabIndex = 4;
            this.FeaturesLabel.Text = "特色:";
            // 
            // ActivitiesLabel
            // 
            this.ActivitiesLabel.AutoSize = true;
            this.ActivitiesLabel.Font = new System.Drawing.Font("Arial", 20F);
            this.ActivitiesLabel.Location = new System.Drawing.Point(3, 93);
            this.ActivitiesLabel.Name = "ActivitiesLabel";
            this.ActivitiesLabel.Size = new System.Drawing.Size(162, 39);
            this.ActivitiesLabel.TabIndex = 5;
            this.ActivitiesLabel.Text = "關聯活動:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20F);
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "關聯展館:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 387);
            this.dataGridView1.TabIndex = 7;
            // 
            // GroupRegistrationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1000);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Model2);
            this.Controls.Add(this.Model1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupRegistrationManagement";
            this.Text = "GroupRegistrationManagement";
            this.Load += new System.EventHandler(this.GroupRegistrationManagement_Load);
            this.Model1.ResumeLayout(false);
            this.Model1.PerformLayout();
            this.Model2.ResumeLayout(false);
            this.Model2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaseDatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Model1;
        private System.Windows.Forms.Panel Model2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox CaseTextbox;
        private System.Windows.Forms.Label InfoLabel1;
        private System.Windows.Forms.DataGridView CaseDatagridview;
        private System.Windows.Forms.Label FeaturesLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CaseLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ActivitiesLabel;
    }
}