using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JinZhan
{
    public partial class ExportData : Form
    {
        public ExportData()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel文件(*.xls)|*.xls|所有文件(*.*)|*.*";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataTable dt = null;
                if (this.CompanyInfo.Checked == true)
                {
                    string strSql = "Select * From CompanyInfo";
                    dt = GetCompanyDataTable(strSql);
                }
                else if (this.HireHouseInfo.Checked == true)
                {
                    string strSql = "Select * From HireHouse";
                    dt = GetHireHouseDataTable(strSql);
                }
                else
                { }
                CSVFileHelper.SaveCSV(dt, dlg.FileName);
                this.Close();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
                dr[46] = ParsingIsData(dr[46].ToString());
                dr[48] = ParsingIsData(dr[48].ToString());
                dr[49] = ParsingIsData(dr[49].ToString());

                dr[53] = ParsingIsData(dr[53].ToString());
                dr[54] = ParsingIsData(dr[54].ToString());
                dr[55] = ParsingIsData(dr[55].ToString());
                dr[56] = ParsingIsData(dr[56].ToString());
                dr[57] = ParsingIsData(dr[57].ToString());
                dr[58] = ParsingIsData(dr[58].ToString());
                dr[59] = ParsingIsData(dr[59].ToString());
                dr[60] = ParsingIsData(dr[60].ToString());
                dr[61] = ParsingIsData(dr[61].ToString());
                dr[62] = ParsingIsData(dr[62].ToString());
                dr[63] = ParsingIsData(dr[63].ToString());
                dr[64] = ParsingIsData(dr[64].ToString());
                dr[65] = ParsingIsData(dr[65].ToString());
                dr[66] = ParsingIsData(dr[66].ToString());
                dr[67] = ParsingIsData(dr[67].ToString());
                dr[68] = ParsingIsData(dr[68].ToString());
                dr[69] = ParsingIsData(dr[69].ToString());
                dr[70] = ParsingIsData(dr[70].ToString());
                dr[71] = ParsingIsData(dr[71].ToString());
                dr[72] = ParsingIsData(dr[72].ToString());
                dr[73] = ParsingIsData(dr[73].ToString());
                dr[74] = ParsingIsData(dr[74].ToString());
                dr[75] = ParsingIsData(dr[75].ToString());
                dr[76] = ParsingIsData(dr[76].ToString());
                dr[77] = ParsingIsData(dr[77].ToString());
                dr[78] = ParsingIsData(dr[78].ToString());
                dr[79] = ParsingIsData(dr[79].ToString());
                dr[80] = ParsingIsData(dr[80].ToString());
                dr[81] = ParsingIsData(dr[81].ToString());
                dr[82] = ParsingIsData(dr[82].ToString());
                dr[83] = ParsingIsData(dr[83].ToString());
                dr[84] = ParsingIsData(dr[84].ToString());
                dr[85] = ParsingIsData(dr[85].ToString());
                dr[86] = ParsingIsData(dr[86].ToString());
                dr[87] = ParsingIsData(dr[87].ToString());
                dr[88] = ParsingIsData(dr[88].ToString());

                dr[97] = ParsingHasData(dr[97].ToString());
                dr[98] = ParsingHasData(dr[98].ToString());
                dr[99] = ParsingHasData(dr[99].ToString());

                dr.EndEdit();
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
            if(data == "1")
            {
                Ret = "有";
            }
            else if(data == "2")
            {
                Ret = "无";
            }
            else
            {}
            return Ret;
        }

        private string ParsingIsData(string data)
        {
            string Ret = string.Empty;
            if (data == "1")
            {
                Ret = "是";
            }
            else if (data == "2")
            {
                Ret = "否";
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

        public DataTable GetCompanyDataTable(string strSql)
        {
            DataTable dt = SqlHelper.dataTable(strSql);
            try
            {
                dt = ParsingData(dt);
                dt.Columns[0].ColumnName = "编号";
                dt.Columns[1].ColumnName = "企业";
                dt.Columns[2].ColumnName = "法人";
                dt.Columns[3].ColumnName = "法人联系方式";
                dt.Columns[4].ColumnName = "企业地址属地";
                dt.Columns[5].ColumnName = "企业详细地址";
                dt.Columns[6].ColumnName = "土地承包人";
                dt.Columns[7].ColumnName = "土地承包人联系方式";
                dt.Columns[8].ColumnName = "承包人地址";
                dt.Columns[9].ColumnName = "营业执照";
                dt.Columns[10].ColumnName = "经营内容";
                dt.Columns[11].ColumnName = "工商注册号";
                dt.Columns[12].ColumnName = "企业人数";
                dt.Columns[13].ColumnName = "食堂";
                dt.Columns[14].ColumnName = "用餐人数";
                dt.Columns[15].ColumnName = "场地情况";
                dt.Columns[16].ColumnName = "住宿人数";
                dt.Columns[17].ColumnName = "建筑类型";
                dt.Columns[18].ColumnName = "建筑面积(平方米)";
                dt.Columns[19].ColumnName = "企业现状";
                dt.Columns[20].ColumnName = "企业门面照片路径";
                dt.Columns[21].ColumnName = "营业执照照片";
                dt.Columns[22].ColumnName = "法人身份证照片";
                dt.Columns[23].ColumnName = "学校举办者类型";
                dt.Columns[24].ColumnName = "建园时间";
                dt.Columns[25].ColumnName = "学校班级数";
                dt.Columns[26].ColumnName = "校舍类型";
                dt.Columns[27].ColumnName = "学校学生数";
                dt.Columns[28].ColumnName = "校舍性质";
                dt.Columns[29].ColumnName = "学校教职员工数";
                dt.Columns[30].ColumnName = "校舍产权人性质";
                dt.Columns[31].ColumnName = "校舍产权人姓名或公司、村委会名称";
                dt.Columns[32].ColumnName = "学校占地面积(平方米)";
                dt.Columns[33].ColumnName = "活动场地面积(平方米)";
                dt.Columns[34].ColumnName = "学校建筑面积(平方米)";
                dt.Columns[35].ColumnName = "食品企业类型";
                dt.Columns[36].ColumnName = "是否有专业执照";
                dt.Columns[37].ColumnName = "专业执照名称";
                dt.Columns[38].ColumnName = "机动车数量";
                dt.Columns[39].ColumnName = "运输企业是否是专业单位";
                dt.Columns[40].ColumnName = "运输方式";
                dt.Columns[41].ColumnName = "运输类型";
                dt.Columns[42].ColumnName = "出租屋居住人数";
                dt.Columns[43].ColumnName = "出租屋居住间数";
                dt.Columns[44].ColumnName = "房屋层数";
                dt.Columns[45].ColumnName = "取暖方式";
                dt.Columns[46].ColumnName = "是否安装一氧化碳报警器";
                dt.Columns[47].ColumnName = "出租人类型";
                dt.Columns[48].ColumnName = "是否签订不安装一氧化碳报警器承诺书";
                dt.Columns[49].ColumnName = "是否到村流管站备案";
                dt.Columns[50].ColumnName = "居住房屋建筑面积(平方米)";
                dt.Columns[51].ColumnName = "包户责任人";
                dt.Columns[52].ColumnName = "联系方式";
                dt.Columns[53].ColumnName = "是否生产、经营、储存易燃易爆产品";
                dt.Columns[54].ColumnName = "是否配置足额消防器材";
                dt.Columns[55].ColumnName = "消防器材是否能正常使用";
                dt.Columns[56].ColumnName = "疏散通道不小于1.5米";
                dt.Columns[57].ColumnName = "消防通道是否畅通";
                dt.Columns[58].ColumnName = "疏散指示标识是否合规";
                dt.Columns[59].ColumnName = "安全出口标识是否合规";
                dt.Columns[60].ColumnName = "消防档案是否健全";
                dt.Columns[61].ColumnName = "防火间距不小于6米";
                dt.Columns[62].ColumnName = "消防通道宽度不小于4米";
                dt.Columns[63].ColumnName = "易燃易爆物品是否单独存放";
                dt.Columns[64].ColumnName = "疏散通道是否畅通";
                dt.Columns[65].ColumnName = "应急照明灯是否合规";
                dt.Columns[66].ColumnName = "生产区域无明火作业";
                dt.Columns[67].ColumnName = "用电线路无私拉乱接";
                dt.Columns[68].ColumnName = "电线穿非燃管保护";
                dt.Columns[69].ColumnName = "箱体内外无堆放杂物";
                dt.Columns[70].ColumnName = "闸盒一闸一路";
                dt.Columns[71].ColumnName = "配电箱用不可燃材料制作";
                dt.Columns[72].ColumnName = "是否签订责任书";
                dt.Columns[73].ColumnName = "是否粘贴宣传材料";
                dt.Columns[74].ColumnName = "是否安装风斗";
                dt.Columns[75].ColumnName = "是否安装报警器";
                dt.Columns[76].ColumnName = "是否签订不安装报警器承诺书";
                dt.Columns[77].ColumnName = "未私自改装、加装燃气管道";
                dt.Columns[78].ColumnName = "钢瓶是否年检";
                dt.Columns[79].ColumnName = "橡胶软管未出现老化破损";
                dt.Columns[80].ColumnName = "不在使用液化气同时使用其他明火";
                dt.Columns[81].ColumnName = "炉具是否合格";
                dt.Columns[82].ColumnName = "是否安装三通";
                dt.Columns[83].ColumnName = "报警器是否通电";
                dt.Columns[84].ColumnName = "是否有购气合同";
                dt.Columns[85].ColumnName = "安装燃气浓度报警器";
                dt.Columns[86].ColumnName = "钢瓶是否外体完好";
                dt.Columns[87].ColumnName = "不在住宿房间内使用液化气";
                dt.Columns[88].ColumnName = "不在钢瓶存储房间内堆放易燃易爆物品";
                dt.Columns[89].ColumnName = "整改结果";
                dt.Columns[90].ColumnName = "负责人签字";
                dt.Columns[91].ColumnName = "检查人签字";
                dt.Columns[92].ColumnName = "督促整改负责人签字";
                dt.Columns[93].ColumnName = "被检查人签字";
                dt.Columns[94].ColumnName = "隐患数量";
                dt.Columns[95].ColumnName = "安全负责人姓名";
                dt.Columns[96].ColumnName = "安全负责人联系方式";
                dt.Columns[97].ColumnName = "安全制度";
                dt.Columns[98].ColumnName = "电销检";
                dt.Columns[99].ColumnName = "安全责任书";

                dt.Columns.Remove("企业门面照片路径");
                dt.Columns.Remove("营业执照照片");
                dt.Columns.Remove("法人身份证照片");
            }
            catch
            {
                MessageBox.Show("获取数据出错！");
            }
            return dt; 
        }

        public DataTable GetHireHouseDataTable(string strSql)
        {
            DataTable dt = SqlHelper.dataTable(strSql);
            try
            {
            dt.Columns[0].ColumnName = "编号";
            dt.Columns[1].ColumnName = "检查日期";
            dt.Columns[2].ColumnName = "包片专职管理员名称";
            dt.Columns[3].ColumnName = "包户协管员名称";
            dt.Columns[4].ColumnName = "姓名";
            dt.Columns[5].ColumnName = "性别";
            dt.Columns[6].ColumnName = "联系电话";
            dt.Columns[7].ColumnName = "现住地址";
            dt.Columns[8].ColumnName = "出租人类型";
            dt.Columns[9].ColumnName = "出租用途";
            dt.Columns[10].ColumnName = "建筑类型";
            dt.Columns[11].ColumnName = "隐患类型";
            dt.Columns[12].ColumnName = "房屋结构";
            dt.Columns[13].ColumnName = "出租间数";
            dt.Columns[14].ColumnName = "出租大小(平方米)";
            dt.Columns[15].ColumnName = "本市租住人数";
            dt.Columns[16].ColumnName = "外省租住人数";
            dt.Columns[17].ColumnName = "港澳台租住人数";
            dt.Columns[18].ColumnName = "外籍租住人数";
            dt.Columns[19].ColumnName = "登记备案";
            dt.Columns[20].ColumnName = "签订责任书";
            dt.Columns[21].ColumnName = "是否群租房";
            dt.Columns[22].ColumnName = "群租房照片";
            dt.Columns[23].ColumnName = "群租房类型";
            dt.Columns[24].ColumnName = "取暖方式";
            dt.Columns[25].ColumnName = "是否签订责任书";
            dt.Columns[26].ColumnName = "签订分数";
            dt.Columns[27].ColumnName = "煤炉取暖间数";
            dt.Columns[28].ColumnName = "安装报警器数";
            dt.Columns[29].ColumnName = "安装风斗间数";
            dt.Columns[30].ColumnName = "签订承诺书数";

            dt.Columns.Remove("群租房照片");
            }
            catch
            {
                MessageBox.Show("获取数据出错！");
            }
            return dt;
        }
    }
}
