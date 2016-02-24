using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace JinZhan
{
    public partial class AddHireHouseInfo : Form
    {
        private bool bModify = false;
        private string strPhotoPath1 = null;
        HireHouse hireHouse = new HireHouse();
        private byte[] PhotoBit;
        public AddHireHouseInfo()
        {
            bModify = false;
            InitializeComponent();
        }

        public AddHireHouseInfo(HireHouse hireHouse)
        {
            bModify = true;
            InitializeComponent();
            if (Global.authority == Authority.Looker)
            {
                this.submitBtn.Enabled = false;
            }
            else
            {
                this.submitBtn.Enabled = true;
            }
            SetData(hireHouse);
        }

        public void SetData(HireHouse house)
        {
             this.dateTimePicker1.Value=house.CheckTime;
             this.textBox2.Text=house.BaoPianName;
             this.textBox1.Text= house.BaoHuName;
             this.textBox3.Text=house.Name;
             this.comboBox2.Text=house.XingBie;
             this.textBox4.Text=house.HirePhone;
             this.textBox5.Text=house.NowAddress;
             this.chuzurenleixing.Text=house.HireType;
             this.chuzuyongtu.Text=house.HireUse;
             this.jiangzhuleixing.Text=house.BuildType;
             this.yinhuanleixing.Text=house.YinHuanType;
             this.fangwujiegou.Text=house.HouseStruct;
             this.textBox6.Text=house.ChuZujianNum;
             this.textBox7.Text=house.ChuZuSquere;
             this.textBox9.Text=house.HirePerson1;
             this.textBox8.Text=house.HirePerson2;
             this.textBox11.Text=house.HirePerson3;
             this.textBox10.Text=house.HirePerson4;
             this.dengjibeian.Text=house.Dengji;
             this.zerenshu.Text=house.Zerenshu;
             this.isqunzufang.Text=house.IsQunzu;
             this.PhotoBit = house.PhotoPath;
             try
             {
                 if (house.PhotoPath != null)
                 {
                     MemoryStream mystream = new MemoryStream(house.PhotoPath);
                     System.Drawing.Image img1 = System.Drawing.Image.FromStream(mystream, true);
                     this.pictureBox1.Image = img1;
                 }
                 else
                 {
                     this.pictureBox1.Image = null;
                 }
             }
             catch { }
             this.qunzufangtype.Text= house.QunzuType ;
             this.qunuanfangshi.Text=house.WarmStyle;
             this.haszerenshu.Text=house.HaszerenBook;
             this.textBox12.Text=house.QiandingGrade;
             this.textBox16.Text=house.MeiluNum;
             this.textBox15.Text=house.BaojingNum;
             this.textBox14.Text=house.FengDouNum;
             this.textBox13.Text=house.ChennuoNum;
        }

        public HireHouse GetData()
        {
            HireHouse house = new HireHouse();
            house.CheckTime = this.dateTimePicker1.Value.Date;
            house.BaoPianName = this.textBox2.Text;
            house.BaoHuName = this.textBox1.Text;
            house.Name = this.textBox3.Text;
            house.XingBie = this.comboBox2.Text;
            house.HirePhone = this.textBox4.Text;
            house.NowAddress = this.textBox5.Text;
            house.HireType = this.chuzurenleixing.Text;
            house.HireUse = this.chuzuyongtu.Text;
            house.BuildType = this.jiangzhuleixing.Text;
            house.YinHuanType = this.yinhuanleixing.Text;
            house.HouseStruct = this.fangwujiegou.Text;
            house.ChuZujianNum = this.textBox6.Text;
            house.ChuZuSquere = this.textBox7.Text;
            house.HirePerson1 = this.textBox9.Text;
            house.HirePerson2 = this.textBox8.Text;
            house.HirePerson3 = this.textBox11.Text;
            house.HirePerson4 = this.textBox10.Text;
            house.Dengji = this.dengjibeian.Text;
            house.Zerenshu = this.zerenshu.Text;
            house.IsQunzu = this.isqunzufang.Text;
            house.PhotoPath = this.PhotoBit;
            house.QunzuType = this.qunzufangtype.Text;
            house.WarmStyle = this.qunuanfangshi.Text;
            house.HaszerenBook = this.haszerenshu.Text;
            house.QiandingGrade = this.textBox12.Text;
            house.MeiluNum = this.textBox16.Text;
            house.BaojingNum = this.textBox15.Text;
            house.FengDouNum = this.textBox14.Text;
            house.ChennuoNum = this.textBox13.Text;

            return house;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Supported Image Types (*.jpg, *.gif, *.bmp)|*.jpg;*.gif;*.bmp|JPEG Image|*.jpg|GIF Image|*.gif|BITMAP Image|*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(dlg.FileName)) pictureBox1.Image = Image.FromFile(dlg.FileName);
                    this.strPhotoPath1 = dlg.FileName;
                    this.PhotoBit = GetPhotoBit(this.strPhotoPath1);
                }
            }
            catch
            {
                MessageBox.Show("添加照片错误");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.hireHouse = GetData();
        }

        private void InsertHireHouseInfo()
        {
            using (SqlConnection conn = new SqlConnection(SqlHelper.sqlconstr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    string strSql = null;
                    strSql += "insert into HireHouse";
                    strSql += "(CheckTime";
                    strSql += ",BaoPianName";
                    strSql += ",BaoHuName";
                    strSql += ",Name";
                    strSql += ",XingBie";
                    strSql += ",HirePhone";
                    strSql += ",NowAddress";
                    strSql += ",HireType";
                    strSql += ",HireUse ";
                    strSql += ",BuildType";
                    strSql += ",YinHuanType";
                    strSql += ",HouseStruct";
                    strSql += ",ChuZujianNum";
                    strSql += ",ChuZuSquere";
                    strSql += ",HirePerson1";
                    strSql += ",HirePerson2";
                    strSql += ",HirePerson3";
                    strSql += ",HirePerson4";
                    strSql += ",Dengji";
                    strSql += ",Zerenshu";
                    strSql += ",IsQunzu";
                    strSql += ",PhotoPath";
                    strSql += ",QunzuType";
                    strSql += ",WarmStyle";
                    strSql += ",HaszerenBook";
                    strSql += ",QiandingGrade";
                    strSql += ",MeiluNum";
                    strSql += ",BaojingNum";
                    strSql += ",FengDouNum";
                    strSql += ",ChennuoNum)";

                    strSql += " values(@CheckTime";
                    strSql += ",@BaoPianName";
                    strSql += ",@BaoHuName";
                    strSql += ",@Name";
                    strSql += ",@XingBie";
                    strSql += ",@HirePhone";
                    strSql += ",@NowAddress";
                    strSql += ",@HireType";
                    strSql += ",@HireUse ";
                    strSql += ",@BuildType";
                    strSql += ",@YinHuanType";
                    strSql += ",@HouseStruct";
                    strSql += ",@ChuZujianNum";
                    strSql += ",@ChuZuSquere";
                    strSql += ",@HirePerson1";
                    strSql += ",@HirePerson2";
                    strSql += ",@HirePerson3";
                    strSql += ",@HirePerson4";
                    strSql += ",@Dengji";
                    strSql += ",@Zerenshu";
                    strSql += ",@IsQunzu";
                    strSql += ",@PhotoPath";
                    strSql += ",@QunzuType";
                    strSql += ",@WarmStyle";
                    strSql += ",@HaszerenBook";
                    strSql += ",@QiandingGrade";
                    strSql += ",@MeiluNum";
                    strSql += ",@BaojingNum";
                    strSql += ",@FengDouNum";
                    strSql += ",@ChennuoNum)";

                    cmd.CommandText = strSql;

                    cmd.Parameters.AddWithValue("@CheckTime", this.hireHouse.CheckTime);
                    cmd.Parameters.AddWithValue("@BaoPianName", this.hireHouse.BaoPianName);
                    cmd.Parameters.AddWithValue("@BaoHuName", this.hireHouse.BaoHuName);
                    cmd.Parameters.AddWithValue("@Name", this.hireHouse.Name);
                    cmd.Parameters.AddWithValue("@XingBie", this.hireHouse.XingBie);
                    cmd.Parameters.AddWithValue("@HirePhone", this.hireHouse.HirePhone);
                    cmd.Parameters.AddWithValue("@NowAddress", this.hireHouse.NowAddress);
                    cmd.Parameters.AddWithValue("@HireType", this.hireHouse.HireType);
                    cmd.Parameters.AddWithValue("@HireUse", this.hireHouse.HireUse);
                    cmd.Parameters.AddWithValue("@BuildType", this.hireHouse.BuildType);
                    cmd.Parameters.AddWithValue("@YinHuanType", this.hireHouse.YinHuanType);
                    cmd.Parameters.AddWithValue("@HouseStruct", this.hireHouse.HouseStruct);
                    cmd.Parameters.AddWithValue("@ChuZujianNum", this.hireHouse.ChuZujianNum);
                    cmd.Parameters.AddWithValue("@ChuZuSquere", this.hireHouse.ChuZuSquere);
                    cmd.Parameters.AddWithValue("@HirePerson1", this.hireHouse.HirePerson1);
                    cmd.Parameters.AddWithValue("@HirePerson2", this.hireHouse.HirePerson2);
                    cmd.Parameters.AddWithValue("@HirePerson3", this.hireHouse.HirePerson3);
                    cmd.Parameters.AddWithValue("@HirePerson4", this.hireHouse.HirePerson4);
                    cmd.Parameters.AddWithValue("@Dengji", this.hireHouse.Dengji);
                    cmd.Parameters.AddWithValue("@Zerenshu", this.hireHouse.Zerenshu);
                    cmd.Parameters.AddWithValue("@IsQunzu", this.hireHouse.IsQunzu);

                    SqlParameter par = new SqlParameter("@PhotoPath", SqlDbType.Image);
                    if (this.hireHouse.PhotoPath == null)
                    {
                        par.Value = new byte[1];
                    }
                    else
                    {
                        par.Value = this.hireHouse.PhotoPath;
                    }
                    cmd.Parameters.Add(par);

                    cmd.Parameters.AddWithValue("@QunzuType", this.hireHouse.QunzuType);
                    cmd.Parameters.AddWithValue("@WarmStyle", this.hireHouse.WarmStyle);
                    cmd.Parameters.AddWithValue("@HaszerenBook", this.hireHouse.HaszerenBook);
                    cmd.Parameters.AddWithValue("@QiandingGrade", this.hireHouse.QiandingGrade);
                    cmd.Parameters.AddWithValue("@MeiluNum", this.hireHouse.MeiluNum);
                    cmd.Parameters.AddWithValue("@BaojingNum", this.hireHouse.BaojingNum);
                    cmd.Parameters.AddWithValue("@FengDouNum", this.hireHouse.FengDouNum);
                    cmd.Parameters.AddWithValue("@ChennuoNum", this.hireHouse.ChennuoNum);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("添加出租房信息错误");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void UpdateHireHouseInfo()
        {
            using (SqlConnection conn = new SqlConnection(SqlHelper.sqlconstr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    string strSql = null;
                    strSql += "update HireHouse set";
                    strSql += " CheckTime = @CheckTime";
                    strSql += ",BaoPianName = @BaoPianName";
                    strSql += ",BaoHuName = @BaoHuName";
                    //strSql += ",Name = @Name";
                    strSql += ",XingBie = @XingBie";
                    strSql += ",HirePhone = @HirePhone";
                    strSql += ",NowAddress = @NowAddress";
                    strSql += ",HireType = @HireType";
                    strSql += ",HireUse = @HireUse";
                    strSql += ",BuildType = @BuildType";
                    strSql += ",YinHuanType = @YinHuanType";
                    strSql += ",HouseStruct = @HouseStruct";
                    strSql += ",ChuZujianNum = @ChuZujianNum";
                    strSql += ",ChuZuSquere = @ChuZuSquere";
                    strSql += ",HirePerson1 = @HirePerson1";
                    strSql += ",HirePerson2 = @HirePerson2";
                    strSql += ",HirePerson3 = @HirePerson3";
                    strSql += ",HirePerson4 = @HirePerson4";
                    strSql += ",Dengji = @Dengji";
                    strSql += ",Zerenshu = @Zerenshu";
                    strSql += ",IsQunzu = @IsQunzu";
                    strSql += ",PhotoPath = @PhotoPath";
                    strSql += ",QunzuType = @QunzuType";
                    strSql += ",WarmStyle = @WarmStyle";
                    strSql += ",HaszerenBook = @HaszerenBook";
                    strSql += ",QiandingGrade = @QiandingGrade";
                    strSql += ",MeiluNum = @MeiluNum";
                    strSql += ",BaojingNum = @BaojingNum";
                    strSql += ",FengDouNum = @FengDouNum";
                    strSql += ",ChennuoNum = @ChennuoNum where Name = '"+ this.hireHouse.Name +"'";

                    cmd.CommandText = strSql;

                    cmd.Parameters.AddWithValue("@CheckTime", this.hireHouse.CheckTime);
                    cmd.Parameters.AddWithValue("@BaoPianName", this.hireHouse.BaoPianName);
                    cmd.Parameters.AddWithValue("@BaoHuName", this.hireHouse.BaoHuName);
                    //cmd.Parameters.AddWithValue("@Name", this.hireHouse.Name);
                    cmd.Parameters.AddWithValue("@XingBie", this.hireHouse.XingBie);
                    cmd.Parameters.AddWithValue("@HirePhone", this.hireHouse.HirePhone);
                    cmd.Parameters.AddWithValue("@NowAddress", this.hireHouse.NowAddress);
                    cmd.Parameters.AddWithValue("@HireType", this.hireHouse.HireType);
                    cmd.Parameters.AddWithValue("@HireUse", this.hireHouse.HireUse);
                    cmd.Parameters.AddWithValue("@BuildType", this.hireHouse.BuildType);
                    cmd.Parameters.AddWithValue("@YinHuanType", this.hireHouse.YinHuanType);
                    cmd.Parameters.AddWithValue("@HouseStruct", this.hireHouse.HouseStruct);
                    cmd.Parameters.AddWithValue("@ChuZujianNum", this.hireHouse.ChuZujianNum);
                    cmd.Parameters.AddWithValue("@ChuZuSquere", this.hireHouse.ChuZuSquere);
                    cmd.Parameters.AddWithValue("@HirePerson1", this.hireHouse.HirePerson1);
                    cmd.Parameters.AddWithValue("@HirePerson2", this.hireHouse.HirePerson2);
                    cmd.Parameters.AddWithValue("@HirePerson3", this.hireHouse.HirePerson3);
                    cmd.Parameters.AddWithValue("@HirePerson4", this.hireHouse.HirePerson4);
                    cmd.Parameters.AddWithValue("@Dengji", this.hireHouse.Dengji);
                    cmd.Parameters.AddWithValue("@Zerenshu", this.hireHouse.Zerenshu);
                    cmd.Parameters.AddWithValue("@IsQunzu", this.hireHouse.IsQunzu);

                    SqlParameter par = new SqlParameter("@PhotoPath", SqlDbType.Image);
                    par.Value = this.hireHouse.PhotoPath;
                    cmd.Parameters.Add(par);

                    cmd.Parameters.AddWithValue("@QunzuType", this.hireHouse.QunzuType);
                    cmd.Parameters.AddWithValue("@WarmStyle", this.hireHouse.WarmStyle);
                    cmd.Parameters.AddWithValue("@HaszerenBook", this.hireHouse.HaszerenBook);
                    cmd.Parameters.AddWithValue("@QiandingGrade", this.hireHouse.QiandingGrade);
                    cmd.Parameters.AddWithValue("@MeiluNum", this.hireHouse.MeiluNum);
                    cmd.Parameters.AddWithValue("@BaojingNum", this.hireHouse.BaojingNum);
                    cmd.Parameters.AddWithValue("@FengDouNum", this.hireHouse.FengDouNum);
                    cmd.Parameters.AddWithValue("@ChennuoNum", this.hireHouse.ChennuoNum);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("更新出租房信息错误");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void SubmitHireHouseInfo()
        {
            if (this.bModify == true)
            {
                UpdateHireHouseInfo();
            }
            else
            {
                if (IsInfoExit(this.hireHouse.Name))
                {
                    MessageBox.Show("该出租人信息已存在，不能重复添加！");
                }
                else
                {
                    InsertHireHouseInfo();
                }
            }
        }

        private bool IsInfoExit(string strName)
        {
            bool Ret = false;
            string strSql = null;
            strSql += "select Id from HireHouse where Name = '" + strName + "'";
            DataTable dt = SqlHelper.dataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                Ret = true;
            }
            return Ret;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定添加记录？", "JinZhan", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.hireHouse = GetData();
                SubmitHireHouseInfo();
                this.Close();
            }
        }

        private Byte[] GetPhotoBit(string strPath)
        {
            FileStream fs = new FileStream(strPath, FileMode.Open, FileAccess.Read);
            Byte[] photobit = new byte[fs.Length];
            fs.Read(photobit, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            return photobit;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
           // UpdateHireHouseInfo();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            HireHouse house = new HireHouse();
            house.CheckTime = DateTime.Now;
            house.BaoPianName = null;
            house.BaoHuName = null;
            house.Name = null;
            house.XingBie = null;
            house.HirePhone = null;
            house.NowAddress = null;
            house.HireType = null;
            house.HireUse = null;
            house.BuildType = null;
            house.YinHuanType = null;
            house.HouseStruct = null;
            house.ChuZujianNum = null;
            house.ChuZuSquere = null;
            house.HirePerson1 = null;
            house.HirePerson2 = null;
            house.HirePerson3 = null;
            house.HirePerson4 = null;
            house.Dengji = null;
            house.Zerenshu = null;
            house.IsQunzu = null;

            house.PhotoPath = null;

            house.QunzuType = null;
            house.WarmStyle = null;
            house.HaszerenBook = null;
            house.QiandingGrade = null;
            house.MeiluNum = null;
            house.BaojingNum = null;
            house.FengDouNum = null;
            house.ChennuoNum = null;
            SetData(house);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image != null)
            {
                OpenPhoto(this.pictureBox1.Image);
            }
        }

        private void OpenPhoto(Image img)
        {
            string strFileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            strFileName += "\\JinZhan";
            if (!Directory.Exists(strFileName))
            {
                Directory.CreateDirectory(strFileName);
            }
            strFileName = strFileName + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Replace(" ", "-").Replace(":", "-") + ".png";
            img.Save(strFileName, System.Drawing.Imaging.ImageFormat.Png);
            System.Diagnostics.Process.Start(strFileName);
        }

    }
    public class HireHouse
    {
        public DateTime CheckTime { get; set; }
        public string BaoPianName { get; set; }
        public string BaoHuName { get; set; }
        public string Name { get; set; }
        public string XingBie { get; set; }
        public string HirePhone { get; set; }
        public string NowAddress { get; set; }
        public string HireType { get; set; }
        public string HireUse { get; set; }
        public string BuildType { get; set; }
        public string YinHuanType { get; set; }
        public string HouseStruct { get; set; }
        public string ChuZujianNum { get; set; }
        public string ChuZuSquere { get; set; }
        public string HirePerson1 { get; set; }
        public string HirePerson2 { get; set; }
        public string HirePerson3 { get; set; }
        public string HirePerson4 { get; set; }
        public string Dengji { get; set; }
        public string Zerenshu { get; set; }
        public string IsQunzu { get; set; }
        public byte[] PhotoPath { get; set; }
        public string QunzuType { get; set; }
        public string WarmStyle { get; set; }
        public string HaszerenBook { get; set; }
        public string QiandingGrade { get; set; }
        public string MeiluNum { get; set; }
        public string BaojingNum { get; set; }
        public string FengDouNum { get; set; }
        public string ChennuoNum { get; set; }
    }
}
