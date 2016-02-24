namespace JinZhan
{
    partial class Mainfrm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.companydata = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.chuzufangwudata = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportDataBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.userManagerBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.copyrightStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1001, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(143, 17);
            this.toolStripStatusLabel3.Text = "CopyRight  2013.12 V1.0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(185, 17);
            this.toolStripStatusLabel2.Text = "                              ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel1.Text = ",";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.toolStripStatusLabel4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel4.ImageTransparentColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(533, 17);
            this.toolStripStatusLabel4.Text = "                                                                                 " +
                "       ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companydata,
            this.toolStripSeparator2,
            this.chuzufangwudata,
            this.toolStripSeparator3,
            this.ExportDataBtn,
            this.toolStripSeparator5,
            this.userManagerBtn,
            this.toolStripSeparator6,
            this.copyrightStripButton,
            this.toolStripSeparator7,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1001, 85);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // companydata
            // 
            this.companydata.Font = new System.Drawing.Font("宋体", 10F);
            this.companydata.ForeColor = System.Drawing.SystemColors.Highlight;
            this.companydata.Image = ((System.Drawing.Image)(resources.GetObject("companydata.Image")));
            this.companydata.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.companydata.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.companydata.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.companydata.Name = "companydata";
            this.companydata.Size = new System.Drawing.Size(67, 82);
            this.companydata.Text = "企业信息";
            this.companydata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.companydata.Click += new System.EventHandler(this.CompanyInfoList);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 85);
            // 
            // chuzufangwudata
            // 
            this.chuzufangwudata.Font = new System.Drawing.Font("宋体", 10F);
            this.chuzufangwudata.ForeColor = System.Drawing.SystemColors.Highlight;
            this.chuzufangwudata.Image = ((System.Drawing.Image)(resources.GetObject("chuzufangwudata.Image")));
            this.chuzufangwudata.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chuzufangwudata.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.chuzufangwudata.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chuzufangwudata.Name = "chuzufangwudata";
            this.chuzufangwudata.Size = new System.Drawing.Size(67, 82);
            this.chuzufangwudata.Text = "出租房屋";
            this.chuzufangwudata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chuzufangwudata.Click += new System.EventHandler(this.HireHouseInfo);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 85);
            // 
            // ExportDataBtn
            // 
            this.ExportDataBtn.Font = new System.Drawing.Font("宋体", 10F);
            this.ExportDataBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ExportDataBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExportDataBtn.Image")));
            this.ExportDataBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExportDataBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ExportDataBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportDataBtn.Name = "ExportDataBtn";
            this.ExportDataBtn.Size = new System.Drawing.Size(67, 82);
            this.ExportDataBtn.Text = "数据导出";
            this.ExportDataBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExportDataBtn.Click += new System.EventHandler(this.OutPutData);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 85);
            // 
            // userManagerBtn
            // 
            this.userManagerBtn.Font = new System.Drawing.Font("宋体", 10F);
            this.userManagerBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.userManagerBtn.Image = ((System.Drawing.Image)(resources.GetObject("userManagerBtn.Image")));
            this.userManagerBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.userManagerBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.userManagerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userManagerBtn.Name = "userManagerBtn";
            this.userManagerBtn.Size = new System.Drawing.Size(67, 82);
            this.userManagerBtn.Text = "用户管理";
            this.userManagerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.userManagerBtn.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 85);
            // 
            // copyrightStripButton
            // 
            this.copyrightStripButton.Font = new System.Drawing.Font("宋体", 10F);
            this.copyrightStripButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.copyrightStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyrightStripButton.Image")));
            this.copyrightStripButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.copyrightStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copyrightStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyrightStripButton.Name = "copyrightStripButton";
            this.copyrightStripButton.Size = new System.Drawing.Size(67, 82);
            this.copyrightStripButton.Text = "软件信息";
            this.copyrightStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.copyrightStripButton.Click += new System.EventHandler(this.copyrightStripButton_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 85);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("宋体", 10F);
            this.toolStripButton2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(59, 82);
            this.toolStripButton2.Text = "退出";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.AppExit);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1001, 459);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(995, 439);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1001, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Mainfrm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "北京市朝阳区金盏乡人民政府企业信息及出租房屋信息安全管理系统 V1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripButton companydata;
        private System.Windows.Forms.ToolStripButton ExportDataBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        //private AxMapXLib.AxMap axMap1;
        private System.Windows.Forms.ToolStripButton chuzufangwudata;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripButton userManagerBtn;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton copyrightStripButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

