namespace JinZhan
{
    partial class HireHouseInfoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HireHouseInfoList));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.mohuFind = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.inputtextBox2 = new System.Windows.Forms.TextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chuzuInfo1 = new JinZhan.ChuzuInfo();
            this.haszerenshu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.qunuanfangshi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.zerenshu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dengjibeian = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fangwujietou = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yinhuanleixing = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jianzuleixing = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chuzuyongtu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chuzuren = new System.Windows.Forms.ComboBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1207, 466);
            this.splitContainer1.SplitterDistance = 314;
            this.splitContainer1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.exportBtn);
            this.groupBox1.Controls.Add(this.mohuFind);
            this.groupBox1.Controls.Add(this.find);
            this.groupBox1.Controls.Add(this.inputtextBox2);
            this.groupBox1.Controls.Add(this.inputTextBox);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "出租人名称查找";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.deleteBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteBtn.Location = new System.Drawing.Point(1009, 18);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 21);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "删除";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportBtn.Location = new System.Drawing.Point(1090, 18);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 21);
            this.exportBtn.TabIndex = 6;
            this.exportBtn.Text = "导出";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // mohuFind
            // 
            this.mohuFind.Location = new System.Drawing.Point(358, 18);
            this.mohuFind.Name = "mohuFind";
            this.mohuFind.Size = new System.Drawing.Size(75, 23);
            this.mohuFind.TabIndex = 3;
            this.mohuFind.Text = "模糊查找";
            this.mohuFind.UseVisualStyleBackColor = true;
            this.mohuFind.Click += new System.EventHandler(this.mohuFind_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(30, 20);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(75, 23);
            this.find.TabIndex = 0;
            this.find.Text = "精确查找";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // inputtextBox2
            // 
            this.inputtextBox2.Location = new System.Drawing.Point(458, 20);
            this.inputtextBox2.Name = "inputtextBox2";
            this.inputtextBox2.Size = new System.Drawing.Size(207, 21);
            this.inputtextBox2.TabIndex = 2;
            this.inputtextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(125, 20);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(207, 21);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.addInfo);
            this.panel3.Location = new System.Drawing.Point(4, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(39, 249);
            this.panel3.TabIndex = 2;
            // 
            // addInfo
            // 
            this.addInfo.Location = new System.Drawing.Point(5, 78);
            this.addInfo.Name = "addInfo";
            this.addInfo.Size = new System.Drawing.Size(31, 112);
            this.addInfo.TabIndex = 0;
            this.addInfo.Text = "添加新信息";
            this.addInfo.UseVisualStyleBackColor = true;
            this.addInfo.Click += new System.EventHandler(this.addCompany_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 62);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1161, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chuzuInfo1);
            this.groupBox2.Controls.Add(this.haszerenshu);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.qunuanfangshi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.zerenshu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dengjibeian);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.fangwujietou);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.yinhuanleixing);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.jianzuleixing);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.chuzuyongtu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chuzuren);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1207, 148);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息筛选查找";
            // 
            // chuzuInfo1
            // 
            this.chuzuInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chuzuInfo1.Location = new System.Drawing.Point(885, 20);
            this.chuzuInfo1.Name = "chuzuInfo1";
            this.chuzuInfo1.Size = new System.Drawing.Size(316, 49);
            this.chuzuInfo1.TabIndex = 30;
            // 
            // haszerenshu
            // 
            this.haszerenshu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.haszerenshu.FormattingEnabled = true;
            this.haszerenshu.Items.AddRange(new object[] {
            "全部",
            "是",
            "否"});
            this.haszerenshu.Location = new System.Drawing.Point(690, 103);
            this.haszerenshu.Name = "haszerenshu";
            this.haszerenshu.Size = new System.Drawing.Size(110, 20);
            this.haszerenshu.TabIndex = 29;
            this.haszerenshu.SelectedIndexChanged += new System.EventHandler(this.haszerenshu_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(583, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 28;
            this.label9.Text = "是否签订责任书：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "取暖方式：";
            // 
            // qunuanfangshi
            // 
            this.qunuanfangshi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qunuanfangshi.FormattingEnabled = true;
            this.qunuanfangshi.Items.AddRange(new object[] {
            "全部",
            "土暖气",
            "电取暖",
            "炉具",
            "土炕",
            "无取暖方式 "});
            this.qunuanfangshi.Location = new System.Drawing.Point(348, 106);
            this.qunuanfangshi.Name = "qunuanfangshi";
            this.qunuanfangshi.Size = new System.Drawing.Size(218, 20);
            this.qunuanfangshi.TabIndex = 26;
            this.qunuanfangshi.SelectedIndexChanged += new System.EventHandler(this.qunuanfangshi_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "签订责任书：";
            // 
            // zerenshu
            // 
            this.zerenshu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zerenshu.FormattingEnabled = true;
            this.zerenshu.Items.AddRange(new object[] {
            "全部",
            "无",
            "治安",
            "消防",
            "婚育"});
            this.zerenshu.Location = new System.Drawing.Point(111, 106);
            this.zerenshu.Name = "zerenshu";
            this.zerenshu.Size = new System.Drawing.Size(121, 20);
            this.zerenshu.TabIndex = 24;
            this.zerenshu.SelectedIndexChanged += new System.EventHandler(this.zerenshu_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "登记备案：";
            // 
            // dengjibeian
            // 
            this.dengjibeian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dengjibeian.FormattingEnabled = true;
            this.dengjibeian.Items.AddRange(new object[] {
            "全部",
            "有",
            "无"});
            this.dengjibeian.Location = new System.Drawing.Point(679, 63);
            this.dengjibeian.Name = "dengjibeian";
            this.dengjibeian.Size = new System.Drawing.Size(121, 20);
            this.dengjibeian.TabIndex = 22;
            this.dengjibeian.SelectedIndexChanged += new System.EventHandler(this.dengjibeian_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "房屋结构：";
            // 
            // fangwujietou
            // 
            this.fangwujietou.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fangwujietou.FormattingEnabled = true;
            this.fangwujietou.Items.AddRange(new object[] {
            "全部",
            "砖混结构",
            "钢结构",
            "砖木结构",
            "彩钢板",
            "其他"});
            this.fangwujietou.Location = new System.Drawing.Point(348, 66);
            this.fangwujietou.Name = "fangwujietou";
            this.fangwujietou.Size = new System.Drawing.Size(218, 20);
            this.fangwujietou.TabIndex = 20;
            this.fangwujietou.SelectedIndexChanged += new System.EventHandler(this.fangwujietou_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "隐患类型：";
            // 
            // yinhuanleixing
            // 
            this.yinhuanleixing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yinhuanleixing.FormattingEnabled = true;
            this.yinhuanleixing.Items.AddRange(new object[] {
            "全部",
            "不稳定",
            "治安",
            "消防",
            "建筑"});
            this.yinhuanleixing.Location = new System.Drawing.Point(111, 66);
            this.yinhuanleixing.Name = "yinhuanleixing";
            this.yinhuanleixing.Size = new System.Drawing.Size(121, 20);
            this.yinhuanleixing.TabIndex = 18;
            this.yinhuanleixing.SelectedIndexChanged += new System.EventHandler(this.yinhuanleixing_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "建筑类型：";
            // 
            // jianzuleixing
            // 
            this.jianzuleixing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jianzuleixing.FormattingEnabled = true;
            this.jianzuleixing.Items.AddRange(new object[] {
            "全部",
            "平房",
            "楼房",
            "地下空间",
            "其他"});
            this.jianzuleixing.Location = new System.Drawing.Point(679, 24);
            this.jianzuleixing.Name = "jianzuleixing";
            this.jianzuleixing.Size = new System.Drawing.Size(121, 20);
            this.jianzuleixing.TabIndex = 16;
            this.jianzuleixing.SelectedIndexChanged += new System.EventHandler(this.jianzuleixing_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "出租用途：";
            // 
            // chuzuyongtu
            // 
            this.chuzuyongtu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chuzuyongtu.FormattingEnabled = true;
            this.chuzuyongtu.Items.AddRange(new object[] {
            "全部",
            "生活居住",
            "日常办公",
            "生产加工",
            "商用",
            "无照经营旅店住宿",
            "仓储",
            "居住、办公、生产、商用一体",
            "其他"});
            this.chuzuyongtu.Location = new System.Drawing.Point(348, 27);
            this.chuzuyongtu.Name = "chuzuyongtu";
            this.chuzuyongtu.Size = new System.Drawing.Size(218, 20);
            this.chuzuyongtu.TabIndex = 14;
            this.chuzuyongtu.SelectedIndexChanged += new System.EventHandler(this.chuzuyongtu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "出租人类型：";
            // 
            // chuzuren
            // 
            this.chuzuren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chuzuren.FormattingEnabled = true;
            this.chuzuren.Items.AddRange(new object[] {
            "全部",
            "个人直租",
            "单位直租",
            "中介公司",
            "个人转租",
            "委托"});
            this.chuzuren.Location = new System.Drawing.Point(111, 27);
            this.chuzuren.Name = "chuzuren";
            this.chuzuren.Size = new System.Drawing.Size(121, 20);
            this.chuzuren.TabIndex = 12;
            this.chuzuren.SelectedIndexChanged += new System.EventHandler(this.chuzuren_SelectedIndexChanged);
            // 
            // HireHouseInfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1213, 471);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HireHouseInfoList";
            this.Text = "出租房屋信息登记表";
            this.Load += new System.EventHandler(this.HireHouse_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button mohuFind;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.TextBox inputtextBox2;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox qunuanfangshi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox zerenshu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dengjibeian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox fangwujietou;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox yinhuanleixing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox jianzuleixing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox chuzuyongtu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chuzuren;
        private System.Windows.Forms.ComboBox haszerenshu;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button deleteBtn;
        private ChuzuInfo chuzuInfo1;
    }
}