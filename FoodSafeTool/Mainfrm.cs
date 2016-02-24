using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;

using System.Collections;
namespace JinZhan
{
    public partial class Mainfrm : Form
    {
        public Mainfrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.userManagerBtn.Enabled = false;
            if ((Global.authority == Authority.Admin) || (Global.authority == Authority.Manager))
            {
                this.userManagerBtn.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (this.Opacity < 1)
            {
                this.Opacity += 0.1;
            }
            timer1.Stop();
        }


        private void CompanyInfoList(object sender, EventArgs e)
        {
            CompanyInfoList infoList = new CompanyInfoList();
            groupBox1.Controls.Clear();
            infoList.TopLevel = false;
            infoList.Parent = groupBox1;
            infoList.WindowState = FormWindowState.Maximized;
            groupBox1.Controls.Add(this.pictureBox1);
            groupBox1.Controls.Add(infoList);
            infoList.Show();

        }

        private void OutPutData(object sender, EventArgs e)
        {
            ExportData dlg = new ExportData();
            dlg.ShowDialog();
        }

        private void HireHouseInfo(object sender, EventArgs e)
        {
            HireHouseInfoList hirehouseinfoList = new HireHouseInfoList();
            groupBox1.Controls.Clear();
            hirehouseinfoList.TopLevel = false;
            hirehouseinfoList.Parent = groupBox1;
            hirehouseinfoList.WindowState = FormWindowState.Maximized;
            groupBox1.Controls.Add(this.pictureBox1);
            groupBox1.Controls.Add(hirehouseinfoList);
            hirehouseinfoList.Show();

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            UserManage userMagDlg = new UserManage();
            userMagDlg.ShowDialog();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AppExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyrightStripButton_Click(object sender, EventArgs e)
        {
            About dlg = new About();
            dlg.ShowDialog();
        }

    }
}