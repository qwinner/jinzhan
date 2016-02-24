namespace JinZhan
{
    partial class ExportData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportData));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HireHouseInfo = new System.Windows.Forms.RadioButton();
            this.CompanyInfo = new System.Windows.Forms.RadioButton();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HireHouseInfo);
            this.groupBox1.Controls.Add(this.CompanyInfo);
            this.groupBox1.Location = new System.Drawing.Point(38, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 69);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // HireHouseInfo
            // 
            this.HireHouseInfo.AutoSize = true;
            this.HireHouseInfo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HireHouseInfo.Location = new System.Drawing.Point(16, 42);
            this.HireHouseInfo.Name = "HireHouseInfo";
            this.HireHouseInfo.Size = new System.Drawing.Size(95, 16);
            this.HireHouseInfo.TabIndex = 1;
            this.HireHouseInfo.TabStop = true;
            this.HireHouseInfo.Text = "出租房屋信息";
            this.HireHouseInfo.UseVisualStyleBackColor = true;
            // 
            // CompanyInfo
            // 
            this.CompanyInfo.AutoSize = true;
            this.CompanyInfo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CompanyInfo.Location = new System.Drawing.Point(16, 15);
            this.CompanyInfo.Name = "CompanyInfo";
            this.CompanyInfo.Size = new System.Drawing.Size(71, 16);
            this.CompanyInfo.TabIndex = 0;
            this.CompanyInfo.TabStop = true;
            this.CompanyInfo.Text = "企业信息";
            this.CompanyInfo.UseVisualStyleBackColor = true;
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(26, 97);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 69;
            this.OkBtn.Text = "保存";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(120, 97);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 70;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ExportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 142);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(251, 176);
            this.MinimumSize = new System.Drawing.Size(251, 176);
            this.Name = "ExportData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导出数据";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton HireHouseInfo;
        private System.Windows.Forms.RadioButton CompanyInfo;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}