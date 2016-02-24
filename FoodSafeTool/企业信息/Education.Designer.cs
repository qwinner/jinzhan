namespace JinZhan.企业信息
{
    partial class Education
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
            this.label1 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buildTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.houseType = new System.Windows.Forms.ComboBox();
            this.HouseProperty = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ownerProperty = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.classNum = new System.Windows.Forms.TextBox();
            this.studentNum = new System.Windows.Forms.TextBox();
            this.teacherNum = new System.Windows.Forms.TextBox();
            this.ownerName = new System.Windows.Forms.TextBox();
            this.zhandiSquere = new System.Windows.Forms.TextBox();
            this.jianzhuSquere = new System.Windows.Forms.TextBox();
            this.huodongSquere = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "举办者类型:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "",
            "个人",
            "公司"});
            this.typeComboBox.Location = new System.Drawing.Point(126, 16);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(79, 20);
            this.typeComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(263, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "建校（园）时间:";
            // 
            // buildTime
            // 
            this.buildTime.Location = new System.Drawing.Point(364, 15);
            this.buildTime.Name = "buildTime";
            this.buildTime.Size = new System.Drawing.Size(152, 21);
            this.buildTime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(20, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "学校、园所班级数:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(20, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "学校、园所学生数:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(20, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "学校、园所教职员工数:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(348, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "校舍类型:";
            // 
            // houseType
            // 
            this.houseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.houseType.FormattingEnabled = true;
            this.houseType.Items.AddRange(new object[] {
            "",
            "平房",
            "楼房"});
            this.houseType.Location = new System.Drawing.Point(414, 54);
            this.houseType.Name = "houseType";
            this.houseType.Size = new System.Drawing.Size(102, 20);
            this.houseType.TabIndex = 8;
            // 
            // HouseProperty
            // 
            this.HouseProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HouseProperty.FormattingEnabled = true;
            this.HouseProperty.Items.AddRange(new object[] {
            "",
            "租赁",
            "自有"});
            this.HouseProperty.Location = new System.Drawing.Point(414, 88);
            this.HouseProperty.Name = "HouseProperty";
            this.HouseProperty.Size = new System.Drawing.Size(102, 20);
            this.HouseProperty.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(348, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "校舍性质:";
            // 
            // ownerProperty
            // 
            this.ownerProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownerProperty.FormattingEnabled = true;
            this.ownerProperty.Items.AddRange(new object[] {
            "",
            "公司",
            "个人",
            "村委会"});
            this.ownerProperty.Location = new System.Drawing.Point(414, 123);
            this.ownerProperty.Name = "ownerProperty";
            this.ownerProperty.Size = new System.Drawing.Size(102, 20);
            this.ownerProperty.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(312, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "校舍产权人性质:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(20, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "校舍产权人姓名或公司、村委会名称:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(20, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "学校、幼儿园占地面积(平方米):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(20, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "学校、幼儿园建筑面积(平方米):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(300, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "室外活动场地面积(平方米):";
            // 
            // classNum
            // 
            this.classNum.Location = new System.Drawing.Point(143, 57);
            this.classNum.Name = "classNum";
            this.classNum.Size = new System.Drawing.Size(100, 21);
            this.classNum.TabIndex = 17;
            // 
            // studentNum
            // 
            this.studentNum.Location = new System.Drawing.Point(143, 87);
            this.studentNum.Name = "studentNum";
            this.studentNum.Size = new System.Drawing.Size(100, 21);
            this.studentNum.TabIndex = 18;
            // 
            // teacherNum
            // 
            this.teacherNum.Location = new System.Drawing.Point(163, 123);
            this.teacherNum.Name = "teacherNum";
            this.teacherNum.Size = new System.Drawing.Size(80, 21);
            this.teacherNum.TabIndex = 19;
            // 
            // ownerName
            // 
            this.ownerName.Location = new System.Drawing.Point(229, 161);
            this.ownerName.Name = "ownerName";
            this.ownerName.Size = new System.Drawing.Size(287, 21);
            this.ownerName.TabIndex = 20;
            // 
            // zhandiSquere
            // 
            this.zhandiSquere.Location = new System.Drawing.Point(201, 198);
            this.zhandiSquere.Name = "zhandiSquere";
            this.zhandiSquere.Size = new System.Drawing.Size(80, 21);
            this.zhandiSquere.TabIndex = 21;
            // 
            // jianzhuSquere
            // 
            this.jianzhuSquere.Location = new System.Drawing.Point(201, 239);
            this.jianzhuSquere.Name = "jianzhuSquere";
            this.jianzhuSquere.Size = new System.Drawing.Size(80, 21);
            this.jianzhuSquere.TabIndex = 22;
            // 
            // huodongSquere
            // 
            this.huodongSquere.Location = new System.Drawing.Point(455, 198);
            this.huodongSquere.Name = "huodongSquere";
            this.huodongSquere.Size = new System.Drawing.Size(61, 21);
            this.huodongSquere.TabIndex = 23;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(575, 15);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 69;
            this.clearBtn.Text = "清空";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Education
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.huodongSquere);
            this.Controls.Add(this.jianzhuSquere);
            this.Controls.Add(this.zhandiSquere);
            this.Controls.Add(this.ownerName);
            this.Controls.Add(this.teacherNum);
            this.Controls.Add(this.studentNum);
            this.Controls.Add(this.classNum);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ownerProperty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HouseProperty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.houseType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buildTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Education";
            this.Size = new System.Drawing.Size(674, 270);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker buildTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox houseType;
        private System.Windows.Forms.ComboBox HouseProperty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ownerProperty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox classNum;
        private System.Windows.Forms.TextBox studentNum;
        private System.Windows.Forms.TextBox teacherNum;
        private System.Windows.Forms.TextBox ownerName;
        private System.Windows.Forms.TextBox zhandiSquere;
        private System.Windows.Forms.TextBox jianzhuSquere;
        private System.Windows.Forms.TextBox huodongSquere;
        private System.Windows.Forms.Button clearBtn;
    }
}
