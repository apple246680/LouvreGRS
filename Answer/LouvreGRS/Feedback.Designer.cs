namespace LouvreGRS
{
    partial class Feedback
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
            this.EnterBtn = new System.Windows.Forms.Button();
            this.star5 = new System.Windows.Forms.Label();
            this.star4 = new System.Windows.Forms.Label();
            this.star3 = new System.Windows.Forms.Label();
            this.star2 = new System.Windows.Forms.Label();
            this.star1 = new System.Windows.Forms.Label();
            this.Text3 = new System.Windows.Forms.Label();
            this.Entertextbox = new System.Windows.Forms.TextBox();
            this.Text2 = new System.Windows.Forms.Label();
            this.Text1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.EnterBtn.FlatAppearance.BorderSize = 0;
            this.EnterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterBtn.Font = new System.Drawing.Font("Arial", 20F);
            this.EnterBtn.ForeColor = System.Drawing.Color.White;
            this.EnterBtn.Location = new System.Drawing.Point(855, 752);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(344, 75);
            this.EnterBtn.TabIndex = 29;
            this.EnterBtn.Text = "提交資料";
            this.EnterBtn.UseVisualStyleBackColor = false;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // star5
            // 
            this.star5.AutoSize = true;
            this.star5.Font = new System.Drawing.Font("Arial", 40F);
            this.star5.Location = new System.Drawing.Point(468, 754);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(78, 75);
            this.star5.TabIndex = 28;
            this.star5.Tag = "5";
            this.star5.Text = "☆";
            this.star5.Click += new System.EventHandler(this.Star1_Click);
            // 
            // star4
            // 
            this.star4.AutoSize = true;
            this.star4.Font = new System.Drawing.Font("Arial", 40F);
            this.star4.Location = new System.Drawing.Point(390, 754);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(78, 75);
            this.star4.TabIndex = 27;
            this.star4.Tag = "4";
            this.star4.Text = "☆";
            this.star4.Click += new System.EventHandler(this.Star1_Click);
            // 
            // star3
            // 
            this.star3.AutoSize = true;
            this.star3.Font = new System.Drawing.Font("Arial", 40F);
            this.star3.Location = new System.Drawing.Point(312, 754);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(78, 75);
            this.star3.TabIndex = 26;
            this.star3.Tag = "3";
            this.star3.Text = "☆";
            this.star3.Click += new System.EventHandler(this.Star1_Click);
            // 
            // star2
            // 
            this.star2.AutoSize = true;
            this.star2.Font = new System.Drawing.Font("Arial", 40F);
            this.star2.Location = new System.Drawing.Point(234, 754);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(78, 75);
            this.star2.TabIndex = 25;
            this.star2.Tag = "2";
            this.star2.Text = "☆";
            this.star2.Click += new System.EventHandler(this.Star1_Click);
            // 
            // star1
            // 
            this.star1.AutoSize = true;
            this.star1.Font = new System.Drawing.Font("Arial", 40F);
            this.star1.Location = new System.Drawing.Point(156, 754);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(78, 75);
            this.star1.TabIndex = 24;
            this.star1.Tag = "1";
            this.star1.Text = "☆";
            this.star1.Click += new System.EventHandler(this.Star1_Click);
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.Font = new System.Drawing.Font("Arial", 20F);
            this.Text3.Location = new System.Drawing.Point(12, 770);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(153, 39);
            this.Text3.TabIndex = 23;
            this.Text3.Text = "滿意度：";
            // 
            // Entertextbox
            // 
            this.Entertextbox.Location = new System.Drawing.Point(3, 85);
            this.Entertextbox.MaxLength = 300;
            this.Entertextbox.Multiline = true;
            this.Entertextbox.Name = "Entertextbox";
            this.Entertextbox.Size = new System.Drawing.Size(1196, 666);
            this.Entertextbox.TabIndex = 22;
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Font = new System.Drawing.Font("Arial", 20F);
            this.Text2.Location = new System.Drawing.Point(23, 43);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(364, 39);
            this.Text2.TabIndex = 21;
            this.Text2.Text = "（字數上限 300 字元）";
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Font = new System.Drawing.Font("Arial", 20F);
            this.Text1.Location = new System.Drawing.Point(23, 4);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(1003, 39);
            this.Text1.TabIndex = 20;
            this.Text1.Text = "我們非常重視您的意見，所有的資料皆為匿名收集，請安心填寫。";
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 830);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Entertextbox);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Feedback";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Feedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Label star5;
        private System.Windows.Forms.Label star4;
        private System.Windows.Forms.Label star3;
        private System.Windows.Forms.Label star2;
        private System.Windows.Forms.Label star1;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.TextBox Entertextbox;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label Text1;
    }
}