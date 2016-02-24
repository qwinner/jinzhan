using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using JinZhan.企业信息;
using System.Reflection;
namespace JinZhan
{
    public partial class CompanyInfoList : Form
    {
        private string strTempSql = null;
        private bool bInitOk = false;
        private string strCheck = null;
        private List<string> listCheck = new List<string>();
        public CompanyInfoList()
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

        private void Emergency_Load(object sender, EventArgs e)
        {
            if (Global.authority == Authority.Looker)
            {
                this.addCompany.Enabled = false;
                this.deleteBtn.Enabled = false;
            }
            else
            {
                this.addCompany.Enabled = true;
                this.deleteBtn.Enabled = true;
            }
            this.shudi.SelectedIndex = 0;
            this.jingyingneirong.SelectedIndex = 0;
            this.yingyezhizhao.SelectedIndex = 0;
            this.shitang.SelectedIndex = 0;
            this.jianzhuleixing.SelectedIndex = 0;
            this.anquanzhidu.SelectedIndex = 0;
            this.dianxiaojian.SelectedIndex = 0;
            this.zerenshu.SelectedIndex = 0;
            this.qiyexianzhuang.SelectedIndex = 0;
            this.checkBox1.Checked = true;
            this.checkBox2.Checked = true;
            this.checkBox3.Checked = true;
            this.checkBox4.Checked = true;
            this.checkBox5.Checked = true;

            string strSql = "Select CompanyInfo.Id,CompanyInfo.CompanyName,Faren,FaPhoneNum,CompanyAddressA,";
            strSql += "CompanyAddressB,ChenBaoPerson,ChenBaoPhoneNum,ChenBaoAddress,HasYingyeId,";
            strSql += "JingYingContent,ZhuceNum,CompanyPersonNum,HasShiTang,EatPersonNum,";
            strSql += "ChangDi,SleepPersonNum,JianzhuSquere,JianzhuType ,CompanyStatus ,YinHNum ";
            strSql += "From CompanyInfo ";
            //strSql += " select count(distinct(CheckTime)) From T_CheckInfo where T_CheckInfo.CompanyName = (select CompanyName from CompanyInfo) ";

            this.BindData(strSql);
            this.strTempSql = strSql;
            this.bInitOk = true;
            SetHeadPageData();
        }

        private void SetHeadPageData()
        {
            string strSql = "Select distinct(CompanyName) From CompanyInfo";
            DataTable dt = SqlHelper.dataTable(strSql);
            int num = dt.Rows.Count;

            string strSql1 = "Select * From T_CheckInfo";
            DataTable dt1 = SqlHelper.dataTable(strSql1);
            int num1 = dt1.Rows.Count;

            this.headPage1.SetData(num.ToString(), num1.ToString());
        }

        private DataTable ParsingData(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                dr.BeginEdit();
                dr[9] = ParsingYingyezhizhao(dr[10].ToString());
                dr[13] = ParsingHasData(dr[13].ToString());
                dr[15] = ParsingChangDi(dr[15].ToString());
                dr.EndEdit();
            }
            dt = AppendData(dt);
            return dt;
        }

        private DataTable AppendData(DataTable dt)
        {
            int nColumnCount = dt.Columns.Count;
            dt.Columns.Add();
            int nRowCount = dt.Rows.Count;
            for(int i =0;i < nRowCount ; i++)
            {
                string strCompanyName = dt.Rows[i][1].ToString();
                string strSql = "Select count(distinct(CheckTime)) From T_CheckInfo where CompanyName = '"+ strCompanyName +"'";
                DataTable tmpdt = SqlHelper.dataTable(strSql);
                string strNum = tmpdt.Rows[0][0].ToString();
                dt.Rows[i][nColumnCount]=(strNum);
            }
            return dt;
        }

        private string ParsingYingyezhizhao(string data)
        {
            string Ret = string.Empty;
            if (data == "1")
            {
                Ret = "有";
            }
            else if (data == "2")
            {
                Ret = "无";
            }
            else if (data == "3")
            {
                Ret = "异";
            }
            else
            {
            }

            return Ret;
        }

        private string ParsingHasData(string data)
        {
            string Ret = string.Empty;
            if (data == "1")
            {
                Ret = "有";
            }
            else if (data == "2")
            {
                Ret = "无";
            }
            else
            { }
            return Ret;
        }

        private string ParsingChangDi(string data)
        {
            string Ret = string.Empty;
            data = data.Replace("1", "生产");
            data = data.Replace("2", "存储");
            data = data.Replace("3", "住宿");
            data = data.Replace("4", "居住");
            Ret = data.Replace("5", "办公");
            return Ret;
        }

        private void BindData(string strSql)
        {
            DataTable dt = SqlHelper.dataTable(strSql);
            dt = ParsingData(dt);
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].HeaderText = "企业名称";
            this.dataGridView1.Columns[1].Width = 100;
            this.dataGridView1.Columns[2].HeaderText = "法人";
            this.dataGridView1.Columns[2].Width = 100;
            this.dataGridView1.Columns[3].HeaderText = "法人联系电话";
            this.dataGridView1.Columns[3].Width = 100;
            this.dataGridView1.Columns[4].HeaderText = "企业属地";
            this.dataGridView1.Columns[4].Width = 100;
            this.dataGridView1.Columns[5].HeaderText = "企业详细地址";
            this.dataGridView1.Columns[5].Width = 140;
            this.dataGridView1.Columns[6].HeaderText = "土地承包人";
            this.dataGridView1.Columns[6].Width = 100;
            this.dataGridView1.Columns[7].HeaderText = "土地承包人联系电话";
            this.dataGridView1.Columns[7].Width = 100;
            this.dataGridView1.Columns[8].HeaderText = "土地承包人户籍地址";
            this.dataGridView1.Columns[8].Width = 100;
            this.dataGridView1.Columns[9].HeaderText = "营业执照";
            this.dataGridView1.Columns[9].Width = 100;
            this.dataGridView1.Columns[10].HeaderText = "经营内容";
            this.dataGridView1.Columns[10].Width = 100;
            this.dataGridView1.Columns[11].HeaderText = "工商注册号";
            this.dataGridView1.Columns[11].Width = 100;
            this.dataGridView1.Columns[12].HeaderText = "企业人数";
            this.dataGridView1.Columns[12].Width = 100;
            this.dataGridView1.Columns[13].HeaderText = "食堂";
            this.dataGridView1.Columns[13].Width = 100;
            this.dataGridView1.Columns[14].HeaderText = "用餐人数";
            this.dataGridView1.Columns[14].Width = 100;
            this.dataGridView1.Columns[15].HeaderText = "场地情况";
            this.dataGridView1.Columns[15].Width = 100;
            this.dataGridView1.Columns[16].HeaderText = "住宿人数";
            this.dataGridView1.Columns[16].Width = 100;
            this.dataGridView1.Columns[17].HeaderText = "建筑类型";
            this.dataGridView1.Columns[17].Width = 100;
            this.dataGridView1.Columns[18].HeaderText = "建筑面积";
            this.dataGridView1.Columns[18].Width = 100;
            this.dataGridView1.Columns[19].HeaderText = "企业现状";
            this.dataGridView1.Columns[19].Width = 100;
            this.dataGridView1.Columns[20].HeaderText = "隐患数";
            this.dataGridView1.Columns[20].Width = 100;
            this.dataGridView1.Columns[21].HeaderText = "检查次数";
            this.dataGridView1.Columns[21].Width = 100;
        }

        private void addCompany_Click(object sender, EventArgs e)
        {
            AddCompanyInfo addcompanyDlg = new AddCompanyInfo();
            addcompanyDlg.ShowDialog();
            string strSql = "Select CompanyInfo.Id,CompanyInfo.CompanyName,Faren,FaPhoneNum,CompanyAddressA,";
            strSql += "CompanyAddressB,ChenBaoPerson,ChenBaoPhoneNum,ChenBaoAddress,HasYingyeId,";
            strSql += "JingYingContent,ZhuceNum,CompanyPersonNum,HasShiTang,EatPersonNum,";
            strSql += "ChangDi,SleepPersonNum,JianzhuSquere,JianzhuType ,CompanyStatus ,YinHNum ";
            strSql += "From CompanyInfo ";
            this.BindData(strSql);
            this.strTempSql = strSql;
        }

        private void shudi_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void jingyingneirong_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void yingyezhizhao_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void shitang_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void jianzhuleixing_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            if (this.bInitOk == true)
            {
                string strSql = "Select CompanyInfo.Id,CompanyInfo.CompanyName,Faren,FaPhoneNum,CompanyAddressA,";
                strSql += "CompanyAddressB,ChenBaoPerson,ChenBaoPhoneNum,ChenBaoAddress,HasYingyeId,";
                strSql += "JingYingContent,ZhuceNum,CompanyPersonNum,HasShiTang,EatPersonNum,";
                strSql += "ChangDi,SleepPersonNum,JianzhuSquere,JianzhuType ,CompanyStatus ,YinHNum ";
                strSql += "From CompanyInfo ";

                strSql += " where ChangDi like '%"+this.strCheck+"%'";
                if (0 != this.shitang.SelectedIndex)
                    strSql += "and HasShiTang = '" + this.shitang.SelectedIndex.ToString() + "'";
                if (0 != this.shudi.SelectedIndex)
                    strSql += "and CompanyAddressA = '" + this.shudi.Text + "' ";
                if (0 != this.jingyingneirong.SelectedIndex)
                    strSql += "and JingYingContent = '" + this.jingyingneirong.Text + "'";
                if (0 != this.yingyezhizhao.SelectedIndex)
                    strSql += "and HasYingyeId = '" + this.yingyezhizhao.SelectedIndex.ToString() + "'";
                if (0 != this.jianzhuleixing.SelectedIndex)
                    strSql += "and JianzhuType = '" + this.jianzhuleixing.Text + "'";
                if (0 != this.anquanzhidu.SelectedIndex)
                    strSql += "and HasSafeSystem = '" + this.anquanzhidu.SelectedIndex.ToString() + "'";
                if (0 != this.dianxiaojian.SelectedIndex)
                    strSql += "and DianXiaoJian = '" + this.dianxiaojian.SelectedIndex.ToString() + "'";
                if (0 != this.zerenshu.SelectedIndex)
                    strSql += "and HasSafeBook = '" + this.zerenshu.SelectedIndex.ToString() + "'";
                if (0 != this.qiyexianzhuang.SelectedIndex)
                    strSql += "and CompanyStatus = '" + this.qiyexianzhuang.SelectedIndex.ToString() + "'";


                this.BindData(strSql);
                this.strTempSql = strSql;
            }
        }

        private void anquanzhidu_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void dianxiaojian_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void zerenshu_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                if (listCheck.Contains("1,") == false)
                    listCheck.Add("1,");
                this.listCheck.Sort();
                this.strCheck = GetStrFromList(this.listCheck);
            }
            else
            {
                if (listCheck.Contains("1,") == true)
                    listCheck.Remove("1,");
                this.listCheck.Sort();
                this.strCheck = GetStrFromList(this.listCheck);
            }
            FilterData();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                if (listCheck.Contains("2,") == false)
                    listCheck.Add("2,");
                this.listCheck.Sort();
                this.strCheck = GetStrFromList(this.listCheck);
            }
            else
            {
                if (listCheck.Contains("2,") == true)
                    listCheck.Remove("2,");
                this.listCheck.Sort();
                this.strCheck = GetStrFromList(this.listCheck);
            }
                FilterData();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                if (listCheck.Contains("3,") == false)
                    listCheck.Add("3,");
                this.listCheck.Sort();
                this.strCheck = GetStrFromList(this.listCheck);
            }
            else
            {
                if (listCheck.Contains("3,") == true)
                    listCheck.Remove("3,");
                this.listCheck.Sort();
                this.strCheck = GetStrFromList(this.listCheck);
            }
            FilterData();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox4.Checked)
            {
                if (listCheck.Contains("4,") == false)
                    listCheck.Add("4,");
                this.listCheck.Sort();
                this.strCheck = GetStrFromList(this.listCheck);
            }
            else
            {
                if (listCheck.Contains("4,") == true)
                    listCheck.Remove("4,");
                this.listCheck.Sort();
                this.strCheck = GetStrFromList(this.listCheck);
            }
            FilterData();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox5.Checked)
            {
                if (listCheck.Contains("5,") == false)
                    listCheck.Add("5,");
                this.listCheck.Sort();
                this.strCheck = GetStrFromList(this.listCheck);
            }
            else
            {
                if (listCheck.Contains("5,") == true)
                    listCheck.Remove("5,");
                this.listCheck.Sort();
                this.strCheck = GetStrFromList(this.listCheck);
            }
            FilterData();
        }

        private string GetStrFromList(List<string> data)
        {
            string strRet = null;
            foreach (var v in data)
            {
                strRet += v.ToString();
            }
            return strRet;
        }

        private void find_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.inputTextBox.Text))
            {
                string strSql = "Select CompanyInfo.Id,CompanyInfo.CompanyName,Faren,FaPhoneNum,CompanyAddressA,";
                strSql += "CompanyAddressB,ChenBaoPerson,ChenBaoPhoneNum,ChenBaoAddress,HasYingyeId,";
                strSql += "JingYingContent,ZhuceNum,CompanyPersonNum,HasShiTang,EatPersonNum,";
                strSql += "ChangDi,SleepPersonNum,JianzhuSquere,JianzhuType ,CompanyStatus ,YinHNum ";
                strSql += "From CompanyInfo ";
                strSql += " where CompanyInfo.CompanyName = '" + this.inputTextBox.Text + "'";
                //strSql += "union all select count(distinct(CheckTime)) From T_CheckInfo where T_CheckInfo.CompanyName = CompanyInfo.CompanyName ";
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
                string strSql = "Select CompanyInfo.Id,CompanyInfo.CompanyName,Faren,FaPhoneNum,CompanyAddressA,";
                strSql += "CompanyAddressB,ChenBaoPerson,ChenBaoPhoneNum,ChenBaoAddress,HasYingyeId,";
                strSql += "JingYingContent,ZhuceNum,CompanyPersonNum,HasShiTang,EatPersonNum,";
                strSql += "ChangDi,SleepPersonNum,JianzhuSquere,JianzhuType ,CompanyStatus ,YinHNum ";
                strSql += "From CompanyInfo ";
                strSql += " where CompanyInfo.CompanyName like '%" + this.inputtextBox2.Text + "%'";
                //strSql += "union all select count(distinct(CheckTime)) From T_CheckInfo where T_CheckInfo.CompanyName = CompanyInfo.CompanyName ";
                this.BindData(strSql);
                this.strTempSql = strSql;
            }
            else
            {
                MessageBox.Show("请输入查询条件");
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
              ViewCompanyInfo();
        }

        private void ViewCompanyInfo()
        {
            BaseInfo baseinfo = new BaseInfo();
            EducationInfo educationinfo = new EducationInfo();
            FoodSafeInfo foodinfo = new FoodSafeInfo();
            JTsafeInfo jtinfo = new JTsafeInfo();
            LDpersonInfo ldinfo = new LDpersonInfo();
            SafeProduceInfo spinfo = new SafeProduceInfo();
            XFsafeInfo xfinfo = new XFsafeInfo();
            try
            {
                string strSql = "Select * From CompanyInfo where Id = " + Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value) + "";
                DataTable dt = SqlHelper.dataTable(strSql);
                if (dt.Rows.Count == 0) return;
                baseinfo.CompanyName = dt.Rows[0][1].ToString();
                baseinfo.Faren = dt.Rows[0][2].ToString();
                baseinfo.FaPhoneNum = dt.Rows[0][3].ToString();
                baseinfo.CompanyAddressA = dt.Rows[0][4].ToString();
                baseinfo.CompanyAddressB = dt.Rows[0][5].ToString();
                baseinfo.ChenBaoPerson = dt.Rows[0][6].ToString();
                baseinfo.ChenBaoPhoneNum = dt.Rows[0][7].ToString();
                baseinfo.ChenBaoAddress = dt.Rows[0][8].ToString();
                baseinfo.HasYingyeId = dt.Rows[0][9].ToString();
                baseinfo.JingYingContent = dt.Rows[0][10].ToString();
                baseinfo.ZhuceNum = dt.Rows[0][11].ToString();
                baseinfo.CompanyPersonNum = dt.Rows[0][12].ToString();
                baseinfo.HasShiTang = dt.Rows[0][13].ToString();
                baseinfo.EatPersonNum = dt.Rows[0][14].ToString();
                baseinfo.ChangDi = dt.Rows[0][15].ToString();
                baseinfo.SleepPersonNum = dt.Rows[0][16].ToString();
                baseinfo.JianzhuSquere = dt.Rows[0][17].ToString();
                baseinfo.JianzhuType = dt.Rows[0][18].ToString();
                baseinfo.CompanyStatus = dt.Rows[0][19].ToString();
                baseinfo.PhotoPath1 = (byte[])dt.Rows[0][20];
                baseinfo.PhotoPath2 = (byte[])dt.Rows[0][21];
                baseinfo.PhotoPath3 = (byte[])dt.Rows[0][22];


                educationinfo.Type = dt.Rows[0][23].ToString();
                if (dt.Rows[0][24] != null) educationinfo.BuidTime = Convert.ToDateTime(dt.Rows[0][24]);
                educationinfo.ClassNum = dt.Rows[0][25].ToString();
                educationinfo.HouseType = dt.Rows[0][26].ToString();
                educationinfo.StudentNum = dt.Rows[0][27].ToString();
                educationinfo.HouseProperty = dt.Rows[0][28].ToString();
                educationinfo.TeacherNum = dt.Rows[0][29].ToString();
                educationinfo.OwnerProperty = dt.Rows[0][30].ToString();
                educationinfo.OwnerName = dt.Rows[0][31].ToString();
                educationinfo.ZhandiSquere = dt.Rows[0][32].ToString();
                educationinfo.HuodongSquere = dt.Rows[0][33].ToString();
                educationinfo.SchoolJianzhuSquere = dt.Rows[0][34].ToString();

                foodinfo.CompanyType = dt.Rows[0][35].ToString();
                foodinfo.HasLicense = dt.Rows[0][36].ToString();
                foodinfo.LicenseName = dt.Rows[0][37].ToString();


                jtinfo.StrCarNum = dt.Rows[0][38].ToString();
                jtinfo.IsProf = dt.Rows[0][39].ToString();
                jtinfo.TranBy = dt.Rows[0][40].ToString();
                jtinfo.TranType = dt.Rows[0][41].ToString();

                ldinfo.LivePersonNum = dt.Rows[0][42].ToString();
                ldinfo.LiveHouseNum = dt.Rows[0][43].ToString();
                ldinfo.HouseFloorNum = dt.Rows[0][44].ToString();
                ldinfo.GetWarmStyle = dt.Rows[0][45].ToString();
                ldinfo.HasWarnning = dt.Rows[0][46].ToString();
                ldinfo.HirePersonType = dt.Rows[0][47].ToString();
                ldinfo.HasPromiseBook = dt.Rows[0][48].ToString();
                ldinfo.IsBackUp = dt.Rows[0][49].ToString();
                ldinfo.BuildSquere = dt.Rows[0][50].ToString();
                ldinfo.OwnerPerson = dt.Rows[0][51].ToString();
                ldinfo.Telephone = dt.Rows[0][52].ToString();

                spinfo.SP1 = dt.Rows[0][53].ToString();
                spinfo.SP2 = dt.Rows[0][54].ToString();
                spinfo.SP3 = dt.Rows[0][55].ToString();
                spinfo.SP4 = dt.Rows[0][56].ToString();
                spinfo.SP5 = dt.Rows[0][57].ToString();
                spinfo.SP6 = dt.Rows[0][58].ToString();
                spinfo.SP7 = dt.Rows[0][59].ToString();
                spinfo.SP8 = dt.Rows[0][60].ToString();
                spinfo.SP9 = dt.Rows[0][61].ToString();
                spinfo.SP10 = dt.Rows[0][62].ToString();
                spinfo.SP11 = dt.Rows[0][63].ToString();
                spinfo.SP12 = dt.Rows[0][64].ToString();
                spinfo.SP13 = dt.Rows[0][65].ToString();
                spinfo.SP14 = dt.Rows[0][66].ToString();
                spinfo.SP15 = dt.Rows[0][67].ToString();
                spinfo.SP16 = dt.Rows[0][68].ToString();
                spinfo.SP17 = dt.Rows[0][69].ToString();
                spinfo.SP18 = dt.Rows[0][70].ToString();
                spinfo.SP19 = dt.Rows[0][71].ToString();
                spinfo.SP20 = dt.Rows[0][72].ToString();
                spinfo.SP21 = dt.Rows[0][73].ToString();
                spinfo.SP22 = dt.Rows[0][74].ToString();
                spinfo.SP23 = dt.Rows[0][75].ToString();
                spinfo.SP24 = dt.Rows[0][76].ToString();
                spinfo.SP25 = dt.Rows[0][77].ToString();
                spinfo.SP26 = dt.Rows[0][78].ToString();
                spinfo.SP27 = dt.Rows[0][79].ToString();
                spinfo.SP28 = dt.Rows[0][80].ToString();
                spinfo.SP29 = dt.Rows[0][81].ToString();
                spinfo.SP30 = dt.Rows[0][82].ToString();
                spinfo.SP31 = dt.Rows[0][83].ToString();
                spinfo.SP32 = dt.Rows[0][84].ToString();
                spinfo.SP33 = dt.Rows[0][85].ToString();
                spinfo.SP34 = dt.Rows[0][86].ToString();
                spinfo.SP35 = dt.Rows[0][87].ToString();
                spinfo.SP36 = dt.Rows[0][88].ToString();
                spinfo.SP37 = dt.Rows[0][89].ToString();
                spinfo.SP38 = dt.Rows[0][90].ToString();
                spinfo.SP39 = dt.Rows[0][91].ToString();
                spinfo.SP40 = dt.Rows[0][92].ToString();
                spinfo.SP41 = dt.Rows[0][93].ToString();
                spinfo.YinHNum = dt.Rows[0][94].ToString();


                xfinfo.ManagerName = dt.Rows[0][95].ToString();
                xfinfo.XFTelephone = dt.Rows[0][96].ToString();
                xfinfo.HasSafeSystem = dt.Rows[0][97].ToString();
                xfinfo.DianXiaoJian = dt.Rows[0][98].ToString();
                xfinfo.HasSafeBook = dt.Rows[0][99].ToString();

                AddCompanyInfo companydlg = new AddCompanyInfo(baseinfo, educationinfo, foodinfo, jtinfo, ldinfo, spinfo, xfinfo);
                companydlg.ShowDialog();
            }
            catch
            {
            }

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
                dt = export.GetCompanyDataTable(strsql);
                if (dt != null)
                {
                    CSVFileHelper.SaveCSV(dt, dlg.FileName);
                    System.Diagnostics.Process.Start(dlg.FileName);
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    if (this.dataGridView1.Rows[i].Cells[19].Value.ToString().Trim() == "移出")
                    {
                        this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if (this.dataGridView1.Rows[i].Cells[19].Value.ToString().Trim() == "注销")
                    {
                        this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    { }
                }
            }
        }

        private void ViewPhotoBtn_Click(object sender, EventArgs e)
        {
            ViewJGPhoto dlg = new ViewJGPhoto();
            dlg.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除此条记录？", "JinZhan", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string strName1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string strSql1 = "Delete From T_CheckInfo where CompanyName = " + Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[1].Value) + "";
                SqlHelper.excuteSql(strSql1);

                string strName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string strSql = "Delete From CompanyInfo where Id = " + Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value) + "";
                SqlHelper.excuteSql(strSql);

                this.BindData(this.strTempSql);
            }
        }

        private void qiyexianzhuang_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }
    }
}
