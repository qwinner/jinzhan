namespace JinZhan.企业信息
{
    partial class JTsafe
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
            this.StrCarNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TranType = new System.Windows.Forms.ComboBox();
            this.IsProf = new System.Windows.Forms.ComboBox();
            this.TranBy = new System.Windows.Forms.ComboBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StrCarNum
            // 
            this.StrCarNum.Location = new System.Drawing.Point(100, 18);
            this.StrCarNum.Name = "StrCarNum";
            this.StrCarNum.Size = new System.Drawing.Size(100, 21);
            this.StrCarNum.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(16, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "运输方式：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(216, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "是否是专业单位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "机动车数量：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(250, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "运输类型：";
            // 
            // TranType
            // 
            this.TranType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TranType.FormattingEnabled = true;
            this.TranType.Location = new System.Drawing.Point(324, 48);
            this.TranType.Name = "TranType";
            this.TranType.Size = new System.Drawing.Size(100, 20);
            this.TranType.TabIndex = 13;
            // 
            // IsProf
            // 
            this.IsProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsProf.FormattingEnabled = true;
            this.IsProf.Items.AddRange(new object[] {
            "",
            "是",
            "否"});
            this.IsProf.Location = new System.Drawing.Point(324, 15);
            this.IsProf.Name = "IsProf";
            this.IsProf.Size = new System.Drawing.Size(100, 20);
            this.IsProf.TabIndex = 14;
            this.IsProf.SelectedIndexChanged += new System.EventHandler(this.IsProf_SelectedIndexChanged);
            // 
            // TranBy
            // 
            this.TranBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TranBy.FormattingEnabled = true;
            this.TranBy.Location = new System.Drawing.Point(100, 48);
            this.TranBy.Name = "TranBy";
            this.TranBy.Size = new System.Drawing.Size(100, 20);
            this.TranBy.TabIndex = 15;
            this.TranBy.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(507, 15);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 70;
            this.clearBtn.Text = "清空";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // JTsafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.TranBy);
            this.Controls.Add(this.IsProf);
            this.Controls.Add(this.TranType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StrCarNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "JTsafe";
            this.Size = new System.Drawing.Size(585, 82);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StrCarNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TranType;
        private System.Windows.Forms.ComboBox IsProf;
        private System.Windows.Forms.ComboBox TranBy;
        private System.Windows.Forms.Button clearBtn;

    }
}
