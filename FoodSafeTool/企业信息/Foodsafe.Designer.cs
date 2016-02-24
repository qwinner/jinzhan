namespace JinZhan.企业信息
{
    partial class Foodsafe
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CompanyType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HasLicense = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LicenseName = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompanyType
            // 
            this.CompanyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompanyType.FormattingEnabled = true;
            this.CompanyType.Items.AddRange(new object[] {
            "",
            "餐饮单位",
            "食品生产单位",
            "食品流通企业",
            "药品生产企业",
            "药品经营企业",
            "医疗器械经营单位",
            "化妆品经营单位",
            "保健品经营单位",
            "无"});
            this.CompanyType.Location = new System.Drawing.Point(97, 10);
            this.CompanyType.Name = "CompanyType";
            this.CompanyType.Size = new System.Drawing.Size(100, 20);
            this.CompanyType.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "企业类型:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(220, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "是否有专业执照:";
            // 
            // HasLicense
            // 
            this.HasLicense.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HasLicense.FormattingEnabled = true;
            this.HasLicense.Items.AddRange(new object[] {
            "",
            "是",
            "否"});
            this.HasLicense.Location = new System.Drawing.Point(321, 10);
            this.HasLicense.Name = "HasLicense";
            this.HasLicense.Size = new System.Drawing.Size(79, 20);
            this.HasLicense.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(8, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "专业执照名称:";
            // 
            // LicenseName
            // 
            this.LicenseName.Location = new System.Drawing.Point(97, 41);
            this.LicenseName.Name = "LicenseName";
            this.LicenseName.Size = new System.Drawing.Size(303, 21);
            this.LicenseName.TabIndex = 19;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(507, 7);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 69;
            this.clearBtn.Text = "清空";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Foodsafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.LicenseName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HasLicense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CompanyType);
            this.Controls.Add(this.label1);
            this.Name = "Foodsafe";
            this.Size = new System.Drawing.Size(629, 83);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CompanyType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox HasLicense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LicenseName;
        private System.Windows.Forms.Button clearBtn;
    }
}
