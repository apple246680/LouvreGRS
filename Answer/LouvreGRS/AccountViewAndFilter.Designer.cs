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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AccountViewAndFilterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountViewAndFilterDataGridView
            // 
            this.AccountViewAndFilterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountViewAndFilterDataGridView.Location = new System.Drawing.Point(1, 80);
            this.AccountViewAndFilterDataGridView.Name = "AccountViewAndFilterDataGridView";
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.textBox1.Location = new System.Drawing.Point(17, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 37);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.textBox2.Location = new System.Drawing.Point(193, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 37);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.label1.Location = new System.Drawing.Point(198, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "部分姓氏";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.textBox3.Location = new System.Drawing.Point(370, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 37);
            this.textBox3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.label2.Location = new System.Drawing.Point(375, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "部分名字";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.label3.Location = new System.Drawing.Point(606, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "人員別：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.label4.Location = new System.Drawing.Point(769, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "帳號狀態：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "全部",
            "館內人員",
            "旅行社人員"});
            this.comboBox1.Location = new System.Drawing.Point(600, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 33);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "全部",
            "正常",
            "關閉"});
            this.comboBox2.Location = new System.Drawing.Point(756, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 33);
            this.comboBox2.TabIndex = 11;
            // 
            // AccountViewAndFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 433);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}