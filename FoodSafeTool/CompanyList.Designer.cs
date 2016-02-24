namespace JinZhan
{
    partial class CompanyList
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.companySettleNumtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.companyCheckedNumtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.companySumTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "收录企业总数";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.companySettleNumtextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.companyCheckedNumtextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.companySumTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 452);
            this.panel1.TabIndex = 3;
            // 
            // companySettleNumtextBox
            // 
            this.companySettleNumtextBox.Location = new System.Drawing.Point(550, 12);
            this.companySettleNumtextBox.Name = "companySettleNumtextBox";
            this.companySettleNumtextBox.ReadOnly = true;
            this.companySettleNumtextBox.Size = new System.Drawing.Size(52, 21);
            this.companySettleNumtextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(441, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "出租房屋数";
            // 
            // companyCheckedNumtextBox
            // 
            this.companyCheckedNumtextBox.Location = new System.Drawing.Point(335, 12);
            this.companyCheckedNumtextBox.Name = "companyCheckedNumtextBox";
            this.companyCheckedNumtextBox.ReadOnly = true;
            this.companyCheckedNumtextBox.Size = new System.Drawing.Size(56, 21);
            this.companyCheckedNumtextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(223, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "隐患数";
            // 
            // companySumTextBox
            // 
            this.companySumTextBox.Location = new System.Drawing.Point(117, 12);
            this.companySumTextBox.Name = "companySumTextBox";
            this.companySumTextBox.ReadOnly = true;
            this.companySumTextBox.Size = new System.Drawing.Size(56, 21);
            this.companySumTextBox.TabIndex = 3;
            // 
            // CompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 452);
            this.Controls.Add(this.panel1);
            this.Name = "CompanyList";
            this.Text = "企业基本信息统计";
            this.Load += new System.EventHandler(this.CompanyList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox companySumTextBox;
        private System.Windows.Forms.TextBox companySettleNumtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox companyCheckedNumtextBox;
        private System.Windows.Forms.Label label4;
    }
}