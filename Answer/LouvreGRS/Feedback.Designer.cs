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
            this.enter_btn = new System.Windows.Forms.Button();
            this.star5 = new System.Windows.Forms.Label();
            this.star4 = new System.Windows.Forms.Label();
            this.star3 = new System.Windows.Forms.Label();
            this.star2 = new System.Windows.Forms.Label();
            this.star1 = new System.Windows.Forms.Label();
            this.text_3 = new System.Windows.Forms.Label();
            this.enter_textbox = new System.Windows.Forms.TextBox();
            this.text_2 = new System.Windows.Forms.Label();
            this.text_1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enter_btn
            // 
            this.enter_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.enter_btn.FlatAppearance.BorderSize = 0;
            this.enter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter_btn.Font = new System.Drawing.Font("Arial", 20F);
            this.enter_btn.ForeColor = System.Drawing.Color.White;
            this.enter_btn.Location = new System.Drawing.Point(808, 353);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(344, 75);
            this.enter_btn.TabIndex = 29;
            this.enter_btn.Text = "提交資料";
            this.enter_btn.UseVisualStyleBackColor = false;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // star5
            // 
            this.star5.AutoSize = true;
            this.star5.Font = new System.Drawing.Font("Arial", 40F);
            this.star5.Location = new System.Drawing.Point(470, 353);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(78, 75);
            this.star5.TabIndex = 28;
            this.star5.Tag = "5";
            this.star5.Text = "☆";
            // 
            // star4
            // 
            this.star4.AutoSize = true;
            this.star4.Font = new System.Drawing.Font("Arial", 40F);
            this.star4.Location = new System.Drawing.Point(392, 353);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(78, 75);
            this.star4.TabIndex = 27;
            this.star4.Tag = "4";
            this.star4.Text = "☆";
            // 
            // star3
            // 
            this.star3.AutoSize = true;
            this.star3.Font = new System.Drawing.Font("Arial", 40F);
            this.star3.Location = new System.Drawing.Point(314, 353);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(78, 75);
            this.star3.TabIndex = 26;
            this.star3.Tag = "3";
            this.star3.Text = "☆";
            // 
            // star2
            // 
            this.star2.AutoSize = true;
            this.star2.Font = new System.Drawing.Font("Arial", 40F);
            this.star2.Location = new System.Drawing.Point(236, 353);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(78, 75);
            this.star2.TabIndex = 25;
            this.star2.Tag = "2";
            this.star2.Text = "☆";
            // 
            // star1
            // 
            this.star1.AutoSize = true;
            this.star1.Font = new System.Drawing.Font("Arial", 40F);
            this.star1.Location = new System.Drawing.Point(158, 353);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(78, 75);
            this.star1.TabIndex = 24;
            this.star1.Tag = "1";
            this.star1.Text = "☆";
            this.star1.Click += new System.EventHandler(this.star1_Click);
            // 
            // text_3
            // 
            this.text_3.AutoSize = true;
            this.text_3.Font = new System.Drawing.Font("Arial", 20F);
            this.text_3.Location = new System.Drawing.Point(14, 369);
            this.text_3.Name = "text_3";
            this.text_3.Size = new System.Drawing.Size(153, 39);
            this.text_3.TabIndex = 23;
            this.text_3.Text = "滿意度：";
            // 
            // enter_textbox
            // 
            this.enter_textbox.Location = new System.Drawing.Point(3, 85);
            this.enter_textbox.MaxLength = 300;
            this.enter_textbox.Multiline = true;
            this.enter_textbox.Name = "enter_textbox";
            this.enter_textbox.Size = new System.Drawing.Size(1149, 264);
            this.enter_textbox.TabIndex = 22;
            // 
            // text_2
            // 
            this.text_2.AutoSize = true;
            this.text_2.Font = new System.Drawing.Font("Arial", 20F);
            this.text_2.Location = new System.Drawing.Point(23, 43);
            this.text_2.Name = "text_2";
            this.text_2.Size = new System.Drawing.Size(364, 39);
            this.text_2.TabIndex = 21;
            this.text_2.Text = "（字數上限 300 字元）";
            // 
            // text_1
            // 
            this.text_1.AutoSize = true;
            this.text_1.Font = new System.Drawing.Font("Arial", 20F);
            this.text_1.Location = new System.Drawing.Point(23, 4);
            this.text_1.Name = "text_1";
            this.text_1.Size = new System.Drawing.Size(1003, 39);
            this.text_1.TabIndex = 20;
            this.text_1.Text = "我們非常重視您的意見，所有的資料皆為匿名收集，請安心填寫。";
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 433);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.text_3);
            this.Controls.Add(this.enter_textbox);
            this.Controls.Add(this.text_2);
            this.Controls.Add(this.text_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Feedback";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Feedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.Label star5;
        private System.Windows.Forms.Label star4;
        private System.Windows.Forms.Label star3;
        private System.Windows.Forms.Label star2;
        private System.Windows.Forms.Label star1;
        private System.Windows.Forms.Label text_3;
        private System.Windows.Forms.TextBox enter_textbox;
        private System.Windows.Forms.Label text_2;
        private System.Windows.Forms.Label text_1;
    }
}