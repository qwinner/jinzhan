using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JinZhan
{
    public partial class HeadPage : UserControl
    {
        public HeadPage()
        {
            InitializeComponent();
        }

        private void HeadPage_Load(object sender, EventArgs e)
        {
        }

        public void SetData(string strNum1,string strNum2)
        {
            this.companySumTextBox.Text = strNum1;
            this.companyCheckedNumtextBox.Text = strNum2;
        }

        //private void GetCompanyData()
        //{
        //    string strSql = "Select distinct(CompanyName) From CompanyInfo";
        //    DataTable dt = SqlHelper.dataTable(strSql);
        //    int num = dt.Rows.Count;
        //    this.companySumTextBox.Text = num.ToString();

        //    string strSql1 = "Select * From T_CheckInfo";
        //    DataTable dt1 = SqlHelper.dataTable(strSql1);
        //    int num1 = dt1.Rows.Count;
        //    this.companyCheckedNumtextBox.Text = num1.ToString();

        //    string strSql2 = "Select distinct(Name) From HireHouse";
        //    DataTable dt2 = SqlHelper.dataTable(strSql2);
        //    int num2 = dt2.Rows.Count;
        //    this.companySettleNumtextBox.Text = num2.ToString();
        //}
    }
}
