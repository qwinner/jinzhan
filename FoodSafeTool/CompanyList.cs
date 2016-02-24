using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JinZhan
{
    public partial class CompanyList : Form
    {
        public CompanyList()
        {
            InitializeComponent();
        }

        private void CompanyList_Load(object sender, EventArgs e)
        {
            GetCompanyListData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetCompanyListData();
        }

        private void GetCompanyListData()
        {
            string strSql = "Select * From CompanyInfo";
            DataTable dt = SqlHelper.dataTable(strSql);
            int num = dt.Rows.Count;
            this.companySumTextBox.Text = num.ToString();


        }

    }
}
