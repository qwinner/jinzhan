using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace JinZhan
{
    public partial class HireHouseInfoList : Form
    {
        private string strTempSql = null;
        private bool bInitOk = false;
        public HireHouseInfoList()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            InitializeComponent();
            //利用反射设置DataGridView的双缓冲
            Type dgvType = this.dataGridView1.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.dataGridView1, true, null);
        }

        private void HireHouse_Load(object sender, EventArgs e)
        {
            if (Global.authority == Authority.Looker)
            {
                this.addInfo.Enabled = false;
                this.deleteBtn.Enabled = false;
            }
            else
            {
                this.addInfo.Enabled = true;
                this.deleteBtn.Enabled = true;
            }
            this.chuzuren.SelectedIndex = 0;
            this.chuzuyongtu.SelectedIndex = 0;
            this.yinhuanleixing.SelectedIndex = 0;
            this.zerenshu.SelectedIndex = 0;
            this.fangwujietou.SelectedIndex = 0;
            this.qunuanfangshi.SelectedIndex = 0;
            this.jianzuleixing.SelectedIndex = 0;
            this.dengjibeian.SelectedIndex = 0;
            this.haszerenshu.SelectedIndex = 0;

            string strSql = "Select * From HireHouse";
            this.BindData(strSql);
            this.strTempSql = strSql;
            this.bInitOk = true;
            SetChuZuData();
        }

        private void SetChuZuData()
        {
            string strSql2 = "Select distinct(Name) From HireHouse";
            DataTable dt2 = SqlHelper.dataTable(strSql2);
            int num2 = dt2.Rows.Count;
            this.chuzuInfo1.SetData( num2.ToString());
        }

        private void BindData(string strSql)
        {
            DataTable dt = SqlHelper.dataTable(strSql);
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].HeaderText = "检查时间";
            this.dataGridView1.Columns[1].Width = 100;
            this.dataGridView1.Columns[2].HeaderText = "包片专职管理员";
            this.dataGridView1.Columns[2].Width = 140;
            this.dataGridView1.Columns[3].HeaderText = "包户协管员名称";
            this.dataGridView1.Columns[3].Width = 165;
            this.dataGridView1.Columns[4].HeaderText = "姓名";
            this.dataGridView1.Columns[4].Width = 165;
            this.dataGridView1.Columns[5].HeaderText = "性别";
            this.dataGridView1.Columns[5].Width = 165;
            this.dataGridView1.Columns[6].HeaderText = "联系电话";
            this.dataGridView1.Columns[6].Width = 100;
            this.dataGridView1.Columns[7].HeaderText = "现住地址";
            this.dataGridView1.Columns[7].Width = 140;
            this.dataGridView1.Columns[8].HeaderText = "出租人类型";
            this.dataGridView1.Columns[8].Width = 165;
            this.dataGridView1.Columns[9].HeaderText = "出租用途";
            this.dataGridView1.Columns[9].Width = 165;
            this.dataGridView1.Columns[10].HeaderText = "建筑类型";
            this.dataGridView1.Columns[10].Width = 165;
            this.dataGridView1.Columns[11].HeaderText = "隐患类型";
            this.dataGridView1.Columns[11].Width = 100;
            this.dataGridView1.Columns[12].HeaderText = "房屋结构";
            this.dataGridView1.Columns[12].Width = 140;
            this.dataGridView1.Columns[13].HeaderText = "出租间数";
            this.dataGridView1.Columns[13].Width = 165;
            this.dataGridView1.Columns[14].HeaderText = "出租大小";
            this.dataGridView1.Columns[14].Width = 165;
            this.dataGridView1.Columns[15].HeaderText = "本市租住人数";
            this.dataGridView1.Columns[15].Width = 165;
            this.dataGridView1.Columns[16].HeaderText = "外省租住人数";
            this.dataGridView1.Columns[16].Width = 100;
            this.dataGridView1.Columns[17].HeaderText = "港澳台租住人数";
            this.dataGridView1.Columns[17].Width = 140;
            this.dataGridView1.Columns[18].HeaderText = "外籍租住人数";
            this.dataGridView1.Columns[18].Width = 165;
            this.dataGridView1.Columns[19].HeaderText = "登记备案";
            this.dataGridView1.Columns[19].Width = 165;
            this.dataGridView1.Columns[20].HeaderText = "签订责任书";
            this.dataGridView1.Columns[20].Width = 165;
            this.dataGridView1.Columns[21].HeaderText = "是否群租房";
            this.dataGridView1.Columns[21].Width = 100;
            this.dataGridView1.Columns[22].Visible = false;//.HeaderText = "群租房照片";
           // this.dataGridView1.Columns[22].Width = 140;
            this.dataGridView1.Columns[23].HeaderText = "群租房类型";
            this.dataGridView1.Columns[23].Width = 165;
            this.dataGridView1.Columns[24].HeaderText = "取暖方式";
            this.dataGridView1.Columns[24].Width = 165;
            this.dataGridView1.Columns[25].HeaderText = "是否签订责任书";
            this.dataGridView1.Columns[25].Width = 165;
            this.dataGridView1.Columns[26].HeaderText = "签订分数";
            this.dataGridView1.Columns[26].Width = 100;
            this.dataGridView1.Columns[27].HeaderText = "煤炉取暖间数";
            this.dataGridView1.Columns[27].Width = 140;
            this.dataGridView1.Columns[28].HeaderText = "安装报警器数";
            this.dataGridView1.Columns[28].Width = 165;
            this.dataGridView1.Columns[29].HeaderText = "安装风斗间数";
            this.dataGridView1.Columns[29].Width = 165;
            this.dataGridView1.Columns[30].HeaderText = "签订承诺书数";
            this.dataGridView1.Columns[30].Width = 165;
        }


        private void find_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.inputTextBox.Text))
            {
                string strSql = "Select * From HireHouse where Name = '" + this.inputTextBox.Text + "'";
                this.BindData(strSql);
                this.strTempSql = strSql;
            }
            else
            {
                MessageBox.Show("请输入查询条件");
            }
        }

        private void mohuFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.inputtextBox2.Text))
            {
                string strSql = "Select * From HireHouse where Name like '%" + this.inputtextBox2.Text + "%'";
                this.BindData(strSql);
                this.strTempSql = strSql;
            }
            else
            {
                MessageBox.Show("请输入查询条件");
            }
        }

        private void addCompany_Click(object sender, EventArgs e)
        {
            AddHireHouseInfo addInfoDlg = new AddHireHouseInfo();
            addInfoDlg.ShowDialog();
            string strSql = "Select * From HireHouse";
            this.BindData(strSql);
            this.strTempSql = strSql;
        }

        private void FilterData()
        {
            if (this.bInitOk == true)
            {
                string strSql = "Select * From HireHouse";
                strSql += " where Id > 0";
                if (0 != this.chuzuren.SelectedIndex)
                    strSql += "and HireType = '" + this.chuzuren.Text + "'";
                if (0 != this.chuzuyongtu.SelectedIndex)
                    strSql += "and HireUse = '" + this.chuzuyongtu.Text + "' ";
                if (0 != this.yinhuanleixing.SelectedIndex)
                    strSql += "and YinHuanType = '" + this.yinhuanleixing.Text + "'";
                if (0 != this.zerenshu.SelectedIndex)
                    strSql += "and Zerenshu = '" + this.zerenshu.Text + "'";
                if (0 != this.fangwujietou.SelectedIndex)
                    strSql += "and HouseStruct = '" + this.fangwujietou.Text + "'";
                if (0 != this.qunuanfangshi.SelectedIndex)
                    strSql += "and WarmStyle = '" + this.qunuanfangshi.Text + "'";
                if (0 != this.jianzuleixing.SelectedIndex)
                    strSql += "and BuildType = '" + this.jianzuleixing.Text + "'";
                if (0 != this.dengjibeian.SelectedIndex)
                    strSql += "and Dengji = '" + this.dengjibeian.Text + "'";
                if (0 != this.haszerenshu.SelectedIndex)
                    strSql += "and HaszerenBook = '" + this.haszerenshu.Text + "'";
                this.BindData(strSql);
                this.strTempSql = strSql;
            }
        }

        private void chuzuren_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void chuzuyongtu_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void jianzuleixing_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void yinhuanleixing_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void fangwujietou_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void dengjibeian_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void zerenshu_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void qunuanfangshi_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void haszerenshu_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                ViewHouseInfo();
                string strSql = "Select * From HireHouse";
                this.BindData(strSql);
                this.strTempSql = strSql;
        }

        private void ViewHouseInfo()
        {
            HireHouse house = new HireHouse();
            try
            {
                string strSql = "Select * From HireHouse where Name ='" + this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString() + "'";
                DataTable dt = SqlHelper.dataTable(strSql);
                if (dt.Rows.Count == 0) return;
                house.CheckTime = Convert.ToDateTime(dt.Rows[0][1]);
                house.BaoPianName = dt.Rows[0][2].ToString();
                house.BaoHuName = dt.Rows[0][3].ToString();
                house.Name = dt.Rows[0][4].ToString();
                house.XingBie = dt.Rows[0][5].ToString();
                house.HirePhone = dt.Rows[0][6].ToString();
                house.NowAddress = dt.Rows[0][7].ToString();
                house.HireType = dt.Rows[0][8].ToString();
                house.HireUse = dt.Rows[0][9].ToString();
                house.BuildType = dt.Rows[0][10].ToString();
                house.YinHuanType = dt.Rows[0][11].ToString();
                house.HouseStruct = dt.Rows[0][12].ToString();
                house.ChuZujianNum = dt.Rows[0][13].ToString();
                house.ChuZuSquere = dt.Rows[0][14].ToString();
                house.HirePerson1 = dt.Rows[0][15].ToString();
                house.HirePerson2 = dt.Rows[0][16].ToString();
                house.HirePerson3 = dt.Rows[0][17].ToString();
                house.HirePerson4 = dt.Rows[0][18].ToString();
                house.Dengji = dt.Rows[0][19].ToString();
                house.Zerenshu = dt.Rows[0][20].ToString();
                house.IsQunzu = dt.Rows[0][21].ToString();

                house.PhotoPath = (byte[])dt.Rows[0][22];

                house.QunzuType = dt.Rows[0][23].ToString();
                house.WarmStyle = dt.Rows[0][24].ToString();
                house.HaszerenBook = dt.Rows[0][25].ToString();
                house.QiandingGrade = dt.Rows[0][26].ToString();
                house.MeiluNum = dt.Rows[0][27].ToString();
                house.BaojingNum = dt.Rows[0][28].ToString();
                house.FengDouNum = dt.Rows[0][29].ToString();
                house.ChennuoNum = dt.Rows[0][30].ToString();
            }
            catch
            {
                MessageBox.Show("读取数据库出错");
            }
            AddHireHouseInfo houseinfodlg = new AddHireHouseInfo(house);
            houseinfodlg.ShowDialog();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel文件(*.xls)|*.xls|所有文件(*.*)|*.*";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataTable dt = null;
                ExportData export = new ExportData();
                string strsql = "Select * ";
                strsql += this.strTempSql.Substring(this.strTempSql.IndexOf("From"));
                dt = export.GetHireHouseDataTable(strsql);
                if (dt != null)
                {
                    CSVFileHelper.SaveCSV(dt, dlg.FileName);
                    System.Diagnostics.Process.Start(dlg.FileName);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除此条记录？", "JinZhan", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string strName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string strSql = "Delete from HireHouse where Name ='" + this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString() + "'";
                SqlHelper.excuteSql(strSql);
                string strSql2 = "Select * From HireHouse";
                this.BindData(strSql2);
            }
        }
    }
}
