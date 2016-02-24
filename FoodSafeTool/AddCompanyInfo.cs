using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JinZhan.企业信息;
using System.IO;
using System.Data.SqlClient;

namespace JinZhan
{
    public partial class AddCompanyInfo : Form
    {
        private bool bModify = false;
        private Base baseinfo = new Base();
        private Education education = new Education();
        private Foodsafe foodsafe = new Foodsafe();
        private JTsafe jtsafe = new JTsafe();
        private LDperson ldperson = new LDperson();
        private SafeProduce safeproduce = new SafeProduce();
        private XFsafe xfsafe = new XFsafe();

        private BaseInfo info = new BaseInfo();
        private EducationInfo educationinfo = new EducationInfo();
        private FoodSafeInfo foodsafeinfo = new FoodSafeInfo();
        private JTsafeInfo jtinfo = new JTsafeInfo();
        private LDpersonInfo ldpersoninfo = new LDpersonInfo();
        private SafeProduceInfo safeproduceinfo = new SafeProduceInfo();
        private XFsafeInfo xfsafeinfo = new XFsafeInfo();
        public AddCompanyInfo()
        {
            bModify = false;
            InitializeComponent();
            if (Global.authority == Authority.Looker)
            {
                this.okBtn.Enabled = false;
                this.AddjgBtn.Enabled = false;
            }
            else
            {
                this.okBtn.Enabled = true;
                this.AddjgBtn.Enabled = true;
            }
        }

        public AddCompanyInfo(BaseInfo info, EducationInfo educationinfo, FoodSafeInfo foodsafeinfo,
            JTsafeInfo jtinfo, LDpersonInfo ldpersoninfo, SafeProduceInfo safeproduceinfo, XFsafeInfo xfsafeinfo)
        {
            bModify = true;
            InitializeComponent();
            this.baseinfo.SetData(info);
            this.education.SetData(educationinfo);
            this.foodsafe.SetData(foodsafeinfo);
            this.jtsafe.SetData(jtinfo);
            this.ldperson.SetData(ldpersoninfo);
            this.safeproduce.SetData(safeproduceinfo);
            this.xfsafe.SetData(xfsafeinfo);
            if (Global.authority == Authority.Looker)
            {
                this.okBtn.Enabled = false;
                this.AddjgBtn.Enabled = false;
            }
            else
            {
                this.okBtn.Enabled = true;
                this.AddjgBtn.Enabled = true;
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定添加记录？", "JinZhan", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                SaveData();
                SubmitBaseInfo();
                this.Close();
            }
        }

        private bool IsCompanyExit(string strCompanyName)
        {
            bool Ret = false;
            string strSql = null;
            strSql += "select CompanyName from CompanyInfo where CompanyName = '"+ strCompanyName +"'";
            DataTable dt = SqlHelper.dataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                Ret = true;
            }
            return Ret;
        }

        private void InsertCompanyInfo()
        {
             using (SqlConnection conn = new SqlConnection(SqlHelper.sqlconstr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    string strSql = null;
                    strSql += "insert into CompanyInfo";
                    strSql += "(CompanyName";
                    strSql += ",Faren";
                    strSql += ",FaPhoneNum";
                    strSql += ",CompanyAddressA";
                    strSql += ",CompanyAddressB";
                    strSql += ",ChenBaoPerson";
                    strSql += ",ChenBaoPhoneNum";
                    strSql += ",ChenBaoAddress";
                    strSql += ",HasYingyeId ";
                    strSql += ",JingYingContent";
                    strSql += ",ZhuceNum";
                    strSql += ",CompanyPersonNum";
                    strSql += ",HasShiTang";
                    strSql += ",EatPersonNum";
                    strSql += ",ChangDi";
                    strSql += ",SleepPersonNum";
                    strSql += ",JianzhuSquere";
                    strSql += ",JianzhuType";
                    strSql += ",CompanyStatus";
                    strSql += ",PhotoPath1";
                    strSql += ",PhotoPath2";
                    strSql += ",PhotoPath3";

                    strSql += ",Type";
                    strSql += ",BuidTime";
                    strSql += ",ClassNum";
                    strSql += ",HouseType";
                    strSql += ",StudentNum";
                    strSql += ",HouseProperty";
                    strSql += ",TeacherNum";
                    strSql += ",OwnerProperty";
                    strSql += ",OwnerName";
                    strSql += ",ZhandiSquere";
                    strSql += ",HuodongSquere";
                    strSql += ",SchoolJianzhuSquere";

                    strSql += ",CompanyType";
                    strSql += ",HasLicense";
                    strSql += ",LicenseName";

                    strSql += ",StrCarNum";
                    strSql += ",IsProf";
                    strSql += ",TranBy";
                    strSql += ",TranType";

                    strSql += ",LivePersonNum";
                    strSql += ",LiveHouseNum";
                    strSql += ",HouseFloorNum";
                    strSql += ",GetWarmStyle";
                    strSql += ",HasWarnning";
                    strSql += ",HirePersonType";
                    strSql += ",HasPromiseBook";
                    strSql += ",IsBackUp";
                    strSql += ",BuildSquere";
                    strSql += ",OwnerPerson";
                    strSql += ",Telephone";

                    strSql += ",SP1  ";
                    strSql += ",SP2  ";
                    strSql += ",SP3  ";
                    strSql += ",SP4  ";
                    strSql += ",SP5  ";
                    strSql += ",SP6  ";
                    strSql += ",SP7  ";
                    strSql += ",SP8  ";
                    strSql += ",SP9  ";
                    strSql += ",SP10 ";
                    strSql += ",SP11 ";
                    strSql += ",SP12 ";
                    strSql += ",SP13 ";
                    strSql += ",SP14 ";
                    strSql += ",SP15 ";
                    strSql += ",SP16 ";
                    strSql += ",SP17 ";
                    strSql += ",SP18 ";
                    strSql += ",SP19 ";
                    strSql += ",SP20 ";
                    strSql += ",SP21 ";
                    strSql += ",SP22 ";
                    strSql += ",SP23 ";
                    strSql += ",SP24 ";
                    strSql += ",SP25 ";
                    strSql += ",SP26 ";
                    strSql += ",SP27 ";
                    strSql += ",SP28 ";
                    strSql += ",SP29 ";
                    strSql += ",SP30 ";
                    strSql += ",SP31 ";
                    strSql += ",SP32 ";
                    strSql += ",SP33 ";
                    strSql += ",SP34 ";
                    strSql += ",SP35 ";
                    strSql += ",SP36 ";
                    strSql += ",SP37 ";
                    strSql += ",SP38 ";
                    strSql += ",SP39 ";
                    strSql += ",SP40 ";
                    strSql += ",SP41 ";
                    strSql += ",YinHNum ";

                    strSql += ",ManagerName";
                    strSql += ",XFTelephone";
                    strSql += ",HasSafeSystem";
                    strSql += ",DianXiaoJian";
                    strSql += ",HasSafeBook)";


                    strSql += "values(@CompanyName";
                    strSql += ",@Faren";
                    strSql += ",@FaPhoneNum";
                    strSql += ",@CompanyAddressA";
                    strSql += ",@CompanyAddressB";
                    strSql += ",@ChenBaoPerson";
                    strSql += ",@ChenBaoPhoneNum";
                    strSql += ",@ChenBaoAddress";
                    strSql += ",@HasYingyeId ";
                    strSql += ",@JingYingContent";
                    strSql += ",@ZhuceNum";
                    strSql += ",@CompanyPersonNum";
                    strSql += ",@HasShiTang";
                    strSql += ",@EatPersonNum";
                    strSql += ",@ChangDi";
                    strSql += ",@SleepPersonNum";
                    strSql += ",@JianzhuSquere";
                    strSql += ",@JianzhuType";
                    strSql += ",@CompanyStatus";
                    strSql += ",@PhotoPath1";
                    strSql += ",@PhotoPath2";
                    strSql += ",@PhotoPath3";

                    strSql += ",@Type";
                    strSql += ",@BuidTime";
                    strSql += ",@ClassNum";
                    strSql += ",@HouseType";
                    strSql += ",@StudentNum";
                    strSql += ",@HouseProperty";
                    strSql += ",@TeacherNum";
                    strSql += ",@OwnerProperty";
                    strSql += ",@OwnerName";
                    strSql += ",@ZhandiSquere";
                    strSql += ",@HuodongSquere";
                    strSql += ",@SchoolJianzhuSquere";

                    strSql += ",@CompanyType";
                    strSql += ",@HasLicense";
                    strSql += ",@LicenseName";

                    strSql += ",@StrCarNum";
                    strSql += ",@IsProf";
                    strSql += ",@TranBy";
                    strSql += ",@TranType";

                    strSql += ",@LivePersonNum";
                    strSql += ",@LiveHouseNum";
                    strSql += ",@HouseFloorNum";
                    strSql += ",@GetWarmStyle";
                    strSql += ",@HasWarnning";
                    strSql += ",@HirePersonType";
                    strSql += ",@HasPromiseBook";
                    strSql += ",@IsBackUp";
                    strSql += ",@BuildSquere";
                    strSql += ",@OwnerPerson";
                    strSql += ",@Telephone";

                    strSql += ",@SP1  ";
                    strSql += ",@SP2  ";
                    strSql += ",@SP3  ";
                    strSql += ",@SP4  ";
                    strSql += ",@SP5  ";
                    strSql += ",@SP6  ";
                    strSql += ",@SP7  ";
                    strSql += ",@SP8  ";
                    strSql += ",@SP9  ";
                    strSql += ",@SP10 ";
                    strSql += ",@SP11 ";
                    strSql += ",@SP12 ";
                    strSql += ",@SP13 ";
                    strSql += ",@SP14 ";
                    strSql += ",@SP15 ";
                    strSql += ",@SP16 ";
                    strSql += ",@SP17 ";
                    strSql += ",@SP18 ";
                    strSql += ",@SP19 ";
                    strSql += ",@SP20 ";
                    strSql += ",@SP21 ";
                    strSql += ",@SP22 ";
                    strSql += ",@SP23 ";
                    strSql += ",@SP24 ";
                    strSql += ",@SP25 ";
                    strSql += ",@SP26 ";
                    strSql += ",@SP27 ";
                    strSql += ",@SP28 ";
                    strSql += ",@SP29 ";
                    strSql += ",@SP30 ";
                    strSql += ",@SP31 ";
                    strSql += ",@SP32 ";
                    strSql += ",@SP33 ";
                    strSql += ",@SP34 ";
                    strSql += ",@SP35 ";
                    strSql += ",@SP36 ";
                    strSql += ",@SP37 ";
                    strSql += ",@SP38 ";
                    strSql += ",@SP39 ";
                    strSql += ",@SP40 ";
                    strSql += ",@SP41 ";
                    strSql += ",@YinHNum ";

                    strSql += ",@ManagerName";
                    strSql += ",@XFTelephone";
                    strSql += ",@HasSafeSystem";
                    strSql += ",@DianXiaoJian";
                    strSql += ",@HasSafeBook)";

                    cmd.CommandText = strSql;

                    cmd.Parameters.AddWithValue("@CompanyName",this.info.CompanyName);
                    cmd.Parameters.AddWithValue("@Faren",this.info.Faren );
                    cmd.Parameters.AddWithValue("@FaPhoneNum",this.info.FaPhoneNum );
                    cmd.Parameters.AddWithValue("@CompanyAddressA",this.info.CompanyAddressA );
                    cmd.Parameters.AddWithValue("@CompanyAddressB",this.info.CompanyAddressB );
                    cmd.Parameters.AddWithValue("@ChenBaoPerson",this.info.ChenBaoPerson);
                    cmd.Parameters.AddWithValue("@ChenBaoPhoneNum",this.info.ChenBaoPhoneNum );
                    cmd.Parameters.AddWithValue("@ChenBaoAddress",this.info.ChenBaoAddress );
                    cmd.Parameters.AddWithValue("@HasYingyeId ",this.info.HasYingyeId );
                    cmd.Parameters.AddWithValue("@JingYingContent",this.info.JingYingContent );
                    cmd.Parameters.AddWithValue("@ZhuceNum",this.info.ZhuceNum );
                    cmd.Parameters.AddWithValue("@CompanyPersonNum",this.info.CompanyPersonNum );
                    cmd.Parameters.AddWithValue("@HasShiTang",this.info.HasShiTang );
                    cmd.Parameters.AddWithValue("@EatPersonNum",this.info.EatPersonNum );
                    cmd.Parameters.AddWithValue("@ChangDi",this.info.ChangDi);
                    cmd.Parameters.AddWithValue("@SleepPersonNum",this.info.SleepPersonNum );
                    cmd.Parameters.AddWithValue("@JianzhuSquere",this.info.JianzhuSquere);
                    cmd.Parameters.AddWithValue("@JianzhuType",this.info.JianzhuType );
                    cmd.Parameters.AddWithValue("@CompanyStatus",this.info.CompanyStatus );

                    SqlParameter par1 = new SqlParameter("@PhotoPath1", SqlDbType.Image);
                    if (info.PhotoPath1 == null)
                    {
                        par1.Value = new byte[1];
                    }
                    else
                    {
                        par1.Value = this.info.PhotoPath1;
                    }
                    cmd.Parameters.Add(par1);

                    SqlParameter par2 = new SqlParameter("@PhotoPath2", SqlDbType.Image);
                    if (info.PhotoPath2 == null)
                    {
                        par2.Value = new byte[1];
                    }
                    else
                    {
                        par2.Value = this.info.PhotoPath2;
                    }
                    cmd.Parameters.Add(par2);

                    SqlParameter par3 = new SqlParameter("@PhotoPath3", SqlDbType.Image);
                    if (info.PhotoPath3 == null)
                    {
                        par3.Value = new byte[1];
                    }
                    else
                    {
                        par3.Value = this.info.PhotoPath3;
                    }
                    cmd.Parameters.Add(par3);

                    cmd.Parameters.AddWithValue("@Type",this.educationinfo.Type );
                    cmd.Parameters.AddWithValue("@BuidTime",this.educationinfo.BuidTime );
                    cmd.Parameters.AddWithValue("@ClassNum",this.educationinfo.ClassNum );
                    cmd.Parameters.AddWithValue("@HouseType",this.educationinfo.HouseType );
                    cmd.Parameters.AddWithValue("@StudentNum",this.educationinfo.StudentNum );
                    cmd.Parameters.AddWithValue("@HouseProperty",this.educationinfo.HouseProperty);
                    cmd.Parameters.AddWithValue("@TeacherNum",this.educationinfo.TeacherNum );
                    cmd.Parameters.AddWithValue("@OwnerProperty",this.educationinfo.OwnerProperty );
                    cmd.Parameters.AddWithValue("@OwnerName",this.educationinfo.OwnerName );
                    cmd.Parameters.AddWithValue("@ZhandiSquere",this.educationinfo.ZhandiSquere );
                    cmd.Parameters.AddWithValue("@HuodongSquere",this.educationinfo.HuodongSquere);
                    cmd.Parameters.AddWithValue("@SchoolJianzhuSquere",this.educationinfo.SchoolJianzhuSquere);

                    cmd.Parameters.AddWithValue("@CompanyType",this.foodsafeinfo.CompanyType );
                    cmd.Parameters.AddWithValue("@HasLicense",this.foodsafeinfo.HasLicense);
                    cmd.Parameters.AddWithValue("@LicenseName",this.foodsafeinfo.LicenseName );

                    cmd.Parameters.AddWithValue("@StrCarNum",this.jtinfo.StrCarNum );
                    cmd.Parameters.AddWithValue("@IsProf",this.jtinfo.IsProf );
                    cmd.Parameters.AddWithValue("@TranBy",this.jtinfo.TranBy);
                    cmd.Parameters.AddWithValue("@TranType",this.jtinfo.TranType);

                    cmd.Parameters.AddWithValue("@LivePersonNum",this.ldpersoninfo.LivePersonNum);
                    cmd.Parameters.AddWithValue("@LiveHouseNum",this.ldpersoninfo.LiveHouseNum );
                    cmd.Parameters.AddWithValue("@HouseFloorNum",this.ldpersoninfo.HouseFloorNum );
                    cmd.Parameters.AddWithValue("@GetWarmStyle",this.ldpersoninfo.GetWarmStyle);
                    cmd.Parameters.AddWithValue("@HasWarnning",this.ldpersoninfo.HasWarnning );
                    cmd.Parameters.AddWithValue("@HirePersonType",this.ldpersoninfo.HirePersonType);
                    cmd.Parameters.AddWithValue("@HasPromiseBook",this.ldpersoninfo.HasPromiseBook );
                    cmd.Parameters.AddWithValue("@IsBackUp",this.ldpersoninfo.IsBackUp );
                    cmd.Parameters.AddWithValue("@BuildSquere",this.ldpersoninfo.BuildSquere );
                    cmd.Parameters.AddWithValue("@OwnerPerson",this.ldpersoninfo.OwnerPerson);
                    cmd.Parameters.AddWithValue("@Telephone",this.ldpersoninfo.Telephone );

                    cmd.Parameters.AddWithValue("@SP1  ",this.safeproduceinfo.SP1 );
                    cmd.Parameters.AddWithValue("@SP2  ",this.safeproduceinfo.SP2 );
                    cmd.Parameters.AddWithValue("@SP3  ",this.safeproduceinfo.SP3 );
                    cmd.Parameters.AddWithValue("@SP4  ",this.safeproduceinfo.SP4 );
                    cmd.Parameters.AddWithValue("@SP5  ",this.safeproduceinfo.SP5 );
                    cmd.Parameters.AddWithValue("@SP6  ",this.safeproduceinfo.SP6 );
                    cmd.Parameters.AddWithValue("@SP7  ",this.safeproduceinfo.SP7 );
                    cmd.Parameters.AddWithValue("@SP8  ",this.safeproduceinfo.SP8 );
                    cmd.Parameters.AddWithValue("@SP9  ",this.safeproduceinfo.SP9 );
                    cmd.Parameters.AddWithValue("@SP10 ",this.safeproduceinfo.SP10 );
                    cmd.Parameters.AddWithValue("@SP11 ",this.safeproduceinfo.SP11 );
                    cmd.Parameters.AddWithValue("@SP12 ",this.safeproduceinfo.SP12 );
                    cmd.Parameters.AddWithValue("@SP13 ",this.safeproduceinfo.SP13 );
                    cmd.Parameters.AddWithValue("@SP14 ",this.safeproduceinfo.SP14 );
                    cmd.Parameters.AddWithValue("@SP15 ",this.safeproduceinfo.SP15 );
                    cmd.Parameters.AddWithValue("@SP16 ",this.safeproduceinfo.SP16 );
                    cmd.Parameters.AddWithValue("@SP17 ",this.safeproduceinfo.SP17 );
                    cmd.Parameters.AddWithValue("@SP18 ",this.safeproduceinfo.SP18 );
                    cmd.Parameters.AddWithValue("@SP19 ",this.safeproduceinfo.SP19 );
                    cmd.Parameters.AddWithValue("@SP20 ",this.safeproduceinfo.SP20 );
                    cmd.Parameters.AddWithValue("@SP21 ",this.safeproduceinfo.SP21 );
                    cmd.Parameters.AddWithValue("@SP22 ",this.safeproduceinfo.SP22 );
                    cmd.Parameters.AddWithValue("@SP23 ",this.safeproduceinfo.SP23 );
                    cmd.Parameters.AddWithValue("@SP24 ",this.safeproduceinfo.SP24 );
                    cmd.Parameters.AddWithValue("@SP25 ",this.safeproduceinfo.SP25 );
                    cmd.Parameters.AddWithValue("@SP26 ",this.safeproduceinfo.SP26 );
                    cmd.Parameters.AddWithValue("@SP27 ",this.safeproduceinfo.SP27 );
                    cmd.Parameters.AddWithValue("@SP28 ",this.safeproduceinfo.SP28 );
                    cmd.Parameters.AddWithValue("@SP29 ",this.safeproduceinfo.SP29 );
                    cmd.Parameters.AddWithValue("@SP30 ",this.safeproduceinfo.SP30 );
                    cmd.Parameters.AddWithValue("@SP31 ",this.safeproduceinfo.SP31 );
                    cmd.Parameters.AddWithValue("@SP32 ",this.safeproduceinfo.SP32 );
                    cmd.Parameters.AddWithValue("@SP33 ",this.safeproduceinfo.SP33 );
                    cmd.Parameters.AddWithValue("@SP34 ",this.safeproduceinfo.SP34 );
                    cmd.Parameters.AddWithValue("@SP35 ",this.safeproduceinfo.SP35 );
                    cmd.Parameters.AddWithValue("@SP36 ",this.safeproduceinfo.SP36 );
                    cmd.Parameters.AddWithValue("@SP37 ",this.safeproduceinfo.SP37 );
                    cmd.Parameters.AddWithValue("@SP38 ",this.safeproduceinfo.SP38 );
                    cmd.Parameters.AddWithValue("@SP39 ",this.safeproduceinfo.SP39 );
                    cmd.Parameters.AddWithValue("@SP40 ",this.safeproduceinfo.SP40 );
                    cmd.Parameters.AddWithValue("@SP41 ",this.safeproduceinfo.SP41 );
                    cmd.Parameters.AddWithValue("@YinHNum ",this.safeproduceinfo.YinHNum );

                    cmd.Parameters.AddWithValue("@ManagerName",this.xfsafeinfo.ManagerName);
                    cmd.Parameters.AddWithValue("@XFTelephone",this.xfsafeinfo.XFTelephone);
                    cmd.Parameters.AddWithValue("@HasSafeSystem",this.xfsafeinfo.HasSafeSystem);
                    cmd.Parameters.AddWithValue("@DianXiaoJian",this.xfsafeinfo.DianXiaoJian);
                    cmd.Parameters.AddWithValue("@HasSafeBook",this.xfsafeinfo.HasSafeBook );
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("添加企业信息错误");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void UpdateCompanyInfo()
        {
            using (SqlConnection conn = new SqlConnection(SqlHelper.sqlconstr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    string strSql = null;
                    strSql += "update CompanyInfo set ";
                    //strSql += " CompanyName=@CompanyName";
                    strSql += " Faren=@Faren";
                    strSql += ",FaPhoneNum=@FaPhoneNum";
                    strSql += ",CompanyAddressA=@CompanyAddressA";
                    strSql += ",CompanyAddressB=@CompanyAddressB";
                    strSql += ",ChenBaoPerson=@ChenBaoPerson";
                    strSql += ",ChenBaoPhoneNum=@ChenBaoPhoneNum";
                    strSql += ",ChenBaoAddress=@ChenBaoAddress";
                    strSql += ",HasYingyeId=@HasYingyeId ";
                    strSql += ",JingYingContent=@JingYingContent";
                    strSql += ",ZhuceNum=@ZhuceNum";
                    strSql += ",CompanyPersonNum=@CompanyPersonNum";
                    strSql += ",HasShiTang=@HasShiTang";
                    strSql += ",EatPersonNum=@EatPersonNum";
                    strSql += ",ChangDi=@ChangDi";
                    strSql += ",SleepPersonNum=@SleepPersonNum";
                    strSql += ",JianzhuSquere=@JianzhuSquere";
                    strSql += ",JianzhuType=@JianzhuType";
                    strSql += ",CompanyStatus=@CompanyStatus";
                    strSql += ",PhotoPath1=@PhotoPath1";
                    strSql += ",PhotoPath2=@PhotoPath2";
                    strSql += ",PhotoPath3=@PhotoPath3";

                    strSql += ",Type=@Type";
                    strSql += ",BuidTime=@BuidTime";
                    strSql += ",ClassNum=@ClassNum";
                    strSql += ",HouseType=@HouseType";
                    strSql += ",StudentNum=@StudentNum";
                    strSql += ",HouseProperty=@HouseProperty";
                    strSql += ",TeacherNum=@TeacherNum";
                    strSql += ",OwnerProperty=@OwnerProperty";
                    strSql += ",OwnerName=@OwnerName";
                    strSql += ",ZhandiSquere=@ZhandiSquere";
                    strSql += ",HuodongSquere=@HuodongSquere";
                    strSql += ",SchoolJianzhuSquere=@SchoolJianzhuSquere";

                    strSql += ",CompanyType=@CompanyType";
                    strSql += ",HasLicense=@HasLicense";
                    strSql += ",LicenseName=@LicenseName";

                    strSql += ",StrCarNum=@StrCarNum";
                    strSql += ",IsProf=@IsProf";
                    strSql += ",TranBy=@TranBy";
                    strSql += ",TranType=@TranType";

                    strSql += ",LivePersonNum=@LivePersonNum";
                    strSql += ",LiveHouseNum=@LiveHouseNum";
                    strSql += ",HouseFloorNum=@HouseFloorNum";
                    strSql += ",GetWarmStyle= @GetWarmStyle";
                    strSql += ",HasWarnning= @HasWarnning";
                    strSql += ",HirePersonType= @HirePersonType";
                    strSql += ",HasPromiseBook= @HasPromiseBook";
                    strSql += ",IsBackUp= @IsBackUp";
                    strSql += ",BuildSquere= @BuildSquere";
                    strSql += ",OwnerPerson= @OwnerPerson";
                    strSql += ",Telephone= @Telephone";

                    strSql += ",SP1 =@SP1  ";
                    strSql += ",SP2 =@SP2  ";
                    strSql += ",SP3 =@SP3  ";
                    strSql += ",SP4 =@SP4  ";
                    strSql += ",SP5 =@SP5  ";
                    strSql += ",SP6 =@SP6  ";
                    strSql += ",SP7 =@SP7  ";
                    strSql += ",SP8 =@SP8  ";
                    strSql += ",SP9 =@SP9  ";
                    strSql += ",SP10 = @SP10 ";
                    strSql += ",SP11 = @SP11 ";
                    strSql += ",SP12 = @SP12 ";
                    strSql += ",SP13 = @SP13 ";
                    strSql += ",SP14 = @SP14 ";
                    strSql += ",SP15 = @SP15 ";
                    strSql += ",SP16 = @SP16 ";
                    strSql += ",SP17 = @SP17 ";
                    strSql += ",SP18 = @SP18 ";
                    strSql += ",SP19 = @SP19 ";
                    strSql += ",SP20 = @SP20 ";
                    strSql += ",SP21 = @SP21 ";
                    strSql += ",SP22 = @SP22 ";
                    strSql += ",SP23 = @SP23 ";
                    strSql += ",SP24 = @SP24 ";
                    strSql += ",SP25 = @SP25 ";
                    strSql += ",SP26 = @SP26 ";
                    strSql += ",SP27 = @SP27 ";
                    strSql += ",SP28 = @SP28 ";
                    strSql += ",SP29 = @SP29 ";
                    strSql += ",SP30 = @SP30 ";
                    strSql += ",SP31 = @SP31 ";
                    strSql += ",SP32 = @SP32 ";
                    strSql += ",SP33 = @SP33 ";
                    strSql += ",SP34 = @SP34 ";
                    strSql += ",SP35 = @SP35 ";
                    strSql += ",SP36 = @SP36 ";
                    strSql += ",SP37 = @SP37 ";
                    strSql += ",SP38 = @SP38 ";
                    strSql += ",SP39 = @SP39 ";
                    strSql += ",SP40 = @SP40 ";
                    strSql += ",SP41 = @SP41 ";
                    strSql += ",YinHNum = @YinHNum ";

                    strSql += ",ManagerName = @ManagerName";
                    strSql += ",XFTelephone = @XFTelephone";
                    strSql += ",HasSafeSystem = @HasSafeSystem";
                    strSql += ",DianXiaoJian = @DianXiaoJian";
                    strSql += ",HasSafeBook = @HasSafeBook where CompanyName = '"+ this.info.CompanyName +"'";

                    cmd.CommandText = strSql;

                    //cmd.Parameters.AddWithValue("@CompanyName", this.info.CompanyName);
                    cmd.Parameters.AddWithValue("@Faren", this.info.Faren);
                    cmd.Parameters.AddWithValue("@FaPhoneNum", this.info.FaPhoneNum);
                    cmd.Parameters.AddWithValue("@CompanyAddressA", this.info.CompanyAddressA);
                    cmd.Parameters.AddWithValue("@CompanyAddressB", this.info.CompanyAddressB);
                    cmd.Parameters.AddWithValue("@ChenBaoPerson", this.info.ChenBaoPerson);
                    cmd.Parameters.AddWithValue("@ChenBaoPhoneNum", this.info.ChenBaoPhoneNum);
                    cmd.Parameters.AddWithValue("@ChenBaoAddress", this.info.ChenBaoAddress);
                    cmd.Parameters.AddWithValue("@HasYingyeId ", this.info.HasYingyeId);
                    cmd.Parameters.AddWithValue("@JingYingContent", this.info.JingYingContent);
                    cmd.Parameters.AddWithValue("@ZhuceNum", this.info.ZhuceNum);
                    cmd.Parameters.AddWithValue("@CompanyPersonNum", this.info.CompanyPersonNum);
                    cmd.Parameters.AddWithValue("@HasShiTang", this.info.HasShiTang);
                    cmd.Parameters.AddWithValue("@EatPersonNum", this.info.EatPersonNum);
                    cmd.Parameters.AddWithValue("@ChangDi", this.info.ChangDi);
                    cmd.Parameters.AddWithValue("@SleepPersonNum", this.info.SleepPersonNum);
                    cmd.Parameters.AddWithValue("@JianzhuSquere", this.info.JianzhuSquere);
                    cmd.Parameters.AddWithValue("@JianzhuType", this.info.JianzhuType);
                    cmd.Parameters.AddWithValue("@CompanyStatus", this.info.CompanyStatus);

                    SqlParameter par1 = new SqlParameter("@PhotoPath1", SqlDbType.Image);
                    if (info.PhotoPath1 == null)
                    {
                        par1.Value = new byte[1];
                    }
                    else
                    {
                        par1.Value = this.info.PhotoPath1;
                    }
                    cmd.Parameters.Add(par1);

                    SqlParameter par2 = new SqlParameter("@PhotoPath2", SqlDbType.Image);
                    if (info.PhotoPath2 == null)
                    {
                        par2.Value = new byte[1];
                    }
                    else
                    {
                        par2.Value = this.info.PhotoPath2;
                    }
                    cmd.Parameters.Add(par2);

                    SqlParameter par3 = new SqlParameter("@PhotoPath3", SqlDbType.Image);
                    if (info.PhotoPath3 == null)
                    {
                        par3.Value = new byte[1];
                    }
                    else
                    {
                        par3.Value = this.info.PhotoPath3;
                    }
                    cmd.Parameters.Add(par3);

                    cmd.Parameters.AddWithValue("@Type", this.educationinfo.Type);
                    cmd.Parameters.AddWithValue("@BuidTime", this.educationinfo.BuidTime);
                    cmd.Parameters.AddWithValue("@ClassNum", this.educationinfo.ClassNum);
                    cmd.Parameters.AddWithValue("@HouseType", this.educationinfo.HouseType);
                    cmd.Parameters.AddWithValue("@StudentNum", this.educationinfo.StudentNum);
                    cmd.Parameters.AddWithValue("@HouseProperty", this.educationinfo.HouseProperty);
                    cmd.Parameters.AddWithValue("@TeacherNum", this.educationinfo.TeacherNum);
                    cmd.Parameters.AddWithValue("@OwnerProperty", this.educationinfo.OwnerProperty);
                    cmd.Parameters.AddWithValue("@OwnerName", this.educationinfo.OwnerName);
                    cmd.Parameters.AddWithValue("@ZhandiSquere", this.educationinfo.ZhandiSquere);
                    cmd.Parameters.AddWithValue("@HuodongSquere", this.educationinfo.HuodongSquere);
                    cmd.Parameters.AddWithValue("@SchoolJianzhuSquere", this.educationinfo.SchoolJianzhuSquere);

                    cmd.Parameters.AddWithValue("@CompanyType", this.foodsafeinfo.CompanyType);
                    cmd.Parameters.AddWithValue("@HasLicense", this.foodsafeinfo.HasLicense);
                    cmd.Parameters.AddWithValue("@LicenseName", this.foodsafeinfo.LicenseName);

                    cmd.Parameters.AddWithValue("@StrCarNum", this.jtinfo.StrCarNum);
                    cmd.Parameters.AddWithValue("@IsProf", this.jtinfo.IsProf);
                    cmd.Parameters.AddWithValue("@TranBy", this.jtinfo.TranBy);
                    cmd.Parameters.AddWithValue("@TranType", this.jtinfo.TranType);

                    cmd.Parameters.AddWithValue("@LivePersonNum", this.ldpersoninfo.LivePersonNum);
                    cmd.Parameters.AddWithValue("@LiveHouseNum", this.ldpersoninfo.LiveHouseNum);
                    cmd.Parameters.AddWithValue("@HouseFloorNum", this.ldpersoninfo.HouseFloorNum);
                    cmd.Parameters.AddWithValue("@GetWarmStyle", this.ldpersoninfo.GetWarmStyle);
                    cmd.Parameters.AddWithValue("@HasWarnning", this.ldpersoninfo.HasWarnning);
                    cmd.Parameters.AddWithValue("@HirePersonType", this.ldpersoninfo.HirePersonType);
                    cmd.Parameters.AddWithValue("@HasPromiseBook", this.ldpersoninfo.HasPromiseBook);
                    cmd.Parameters.AddWithValue("@IsBackUp", this.ldpersoninfo.IsBackUp);
                    cmd.Parameters.AddWithValue("@BuildSquere", this.ldpersoninfo.BuildSquere);
                    cmd.Parameters.AddWithValue("@OwnerPerson", this.ldpersoninfo.OwnerPerson);
                    cmd.Parameters.AddWithValue("@Telephone", this.ldpersoninfo.Telephone);

                    cmd.Parameters.AddWithValue("@SP1  ", this.safeproduceinfo.SP1);
                    cmd.Parameters.AddWithValue("@SP2  ", this.safeproduceinfo.SP2);
                    cmd.Parameters.AddWithValue("@SP3  ", this.safeproduceinfo.SP3);
                    cmd.Parameters.AddWithValue("@SP4  ", this.safeproduceinfo.SP4);
                    cmd.Parameters.AddWithValue("@SP5  ", this.safeproduceinfo.SP5);
                    cmd.Parameters.AddWithValue("@SP6  ", this.safeproduceinfo.SP6);
                    cmd.Parameters.AddWithValue("@SP7  ", this.safeproduceinfo.SP7);
                    cmd.Parameters.AddWithValue("@SP8  ", this.safeproduceinfo.SP8);
                    cmd.Parameters.AddWithValue("@SP9  ", this.safeproduceinfo.SP9);
                    cmd.Parameters.AddWithValue("@SP10 ", this.safeproduceinfo.SP10);
                    cmd.Parameters.AddWithValue("@SP11 ", this.safeproduceinfo.SP11);
                    cmd.Parameters.AddWithValue("@SP12 ", this.safeproduceinfo.SP12);
                    cmd.Parameters.AddWithValue("@SP13 ", this.safeproduceinfo.SP13);
                    cmd.Parameters.AddWithValue("@SP14 ", this.safeproduceinfo.SP14);
                    cmd.Parameters.AddWithValue("@SP15 ", this.safeproduceinfo.SP15);
                    cmd.Parameters.AddWithValue("@SP16 ", this.safeproduceinfo.SP16);
                    cmd.Parameters.AddWithValue("@SP17 ", this.safeproduceinfo.SP17);
                    cmd.Parameters.AddWithValue("@SP18 ", this.safeproduceinfo.SP18);
                    cmd.Parameters.AddWithValue("@SP19 ", this.safeproduceinfo.SP19);
                    cmd.Parameters.AddWithValue("@SP20 ", this.safeproduceinfo.SP20);
                    cmd.Parameters.AddWithValue("@SP21 ", this.safeproduceinfo.SP21);
                    cmd.Parameters.AddWithValue("@SP22 ", this.safeproduceinfo.SP22);
                    cmd.Parameters.AddWithValue("@SP23 ", this.safeproduceinfo.SP23);
                    cmd.Parameters.AddWithValue("@SP24 ", this.safeproduceinfo.SP24);
                    cmd.Parameters.AddWithValue("@SP25 ", this.safeproduceinfo.SP25);
                    cmd.Parameters.AddWithValue("@SP26 ", this.safeproduceinfo.SP26);
                    cmd.Parameters.AddWithValue("@SP27 ", this.safeproduceinfo.SP27);
                    cmd.Parameters.AddWithValue("@SP28 ", this.safeproduceinfo.SP28);
                    cmd.Parameters.AddWithValue("@SP29 ", this.safeproduceinfo.SP29);
                    cmd.Parameters.AddWithValue("@SP30 ", this.safeproduceinfo.SP30);
                    cmd.Parameters.AddWithValue("@SP31 ", this.safeproduceinfo.SP31);
                    cmd.Parameters.AddWithValue("@SP32 ", this.safeproduceinfo.SP32);
                    cmd.Parameters.AddWithValue("@SP33 ", this.safeproduceinfo.SP33);
                    cmd.Parameters.AddWithValue("@SP34 ", this.safeproduceinfo.SP34);
                    cmd.Parameters.AddWithValue("@SP35 ", this.safeproduceinfo.SP35);
                    cmd.Parameters.AddWithValue("@SP36 ", this.safeproduceinfo.SP36);
                    cmd.Parameters.AddWithValue("@SP37 ", this.safeproduceinfo.SP37);
                    cmd.Parameters.AddWithValue("@SP38 ", this.safeproduceinfo.SP38);
                    cmd.Parameters.AddWithValue("@SP39 ", this.safeproduceinfo.SP39);
                    cmd.Parameters.AddWithValue("@SP40 ", this.safeproduceinfo.SP40);
                    cmd.Parameters.AddWithValue("@SP41 ", this.safeproduceinfo.SP41);
                    cmd.Parameters.AddWithValue("@YinHNum ", this.safeproduceinfo.YinHNum);

                    cmd.Parameters.AddWithValue("@ManagerName", this.xfsafeinfo.ManagerName);
                    cmd.Parameters.AddWithValue("@XFTelephone", this.xfsafeinfo.XFTelephone);
                    cmd.Parameters.AddWithValue("@HasSafeSystem", this.xfsafeinfo.HasSafeSystem);
                    cmd.Parameters.AddWithValue("@DianXiaoJian", this.xfsafeinfo.DianXiaoJian);
                    cmd.Parameters.AddWithValue("@HasSafeBook", this.xfsafeinfo.HasSafeBook);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("更新企业信息错误");
                }
                finally
                {
                    conn.Close();
                }
            }

        }

        private void SubmitBaseInfo()
        {
            if (this.bModify == true)
            {
                UpdateCompanyInfo();
            }
            else
            {
                if (IsCompanyExit(this.info.CompanyName))
                {
                    MessageBox.Show("该企业信息已存在，不能重复添加！");
                }
                else
                {
                    InsertCompanyInfo();
                }
            }
        }

        private void AddCompanyInfo_Load(object sender, EventArgs e)
        {
            InitView();
        }

        private void InitView()
        {
            baseInfoGroupBox.Controls.Clear();
            baseInfoGroupBox.Controls.Add(baseinfo);
            baseinfo.Dock = DockStyle.Fill;

            XFGroupBox.Controls.Clear();
            XFGroupBox.Controls.Add(this.xfsafe);
            this.xfsafe.Dock = DockStyle.Fill;

            foodGroupBox.Controls.Clear();
            foodGroupBox.Controls.Add(this.foodsafe);
            this.foodsafe.Dock = DockStyle.Fill;

            JTGroupBox.Controls.Clear();
            JTGroupBox.Controls.Add(this.jtsafe);
            this.jtsafe.Dock = DockStyle.Fill;

            educationGroupBox.Controls.Clear();
            educationGroupBox.Controls.Add(this.education);
            this.education.Dock = DockStyle.Fill;

            LDGroupBox.Controls.Clear();
            LDGroupBox.Controls.Add(this.ldperson);
            this.ldperson.Dock = DockStyle.Fill;

            SafeProductGroupBox.Controls.Clear();
            SafeProductGroupBox.Controls.Add(this.safeproduce);
            this.safeproduce.Dock = DockStyle.Fill;

            baseInfoGroupBox.Select();
        }

        private void xfBtn_Click(object sender, EventArgs e)
        {
            XFGroupBox.Select();
        }

        private void spBtn_Click(object sender, EventArgs e)
        {
            foodGroupBox.Select();
        }

        private void jtBtn_Click(object sender, EventArgs e)
        {
            JTGroupBox.Select();
        }

        private void wjBtn_Click(object sender, EventArgs e)
        {
            educationGroupBox.Select();
        }

        private void ldBtn_Click(object sender, EventArgs e)
        {
            LDGroupBox.Select();
        }

        private void baseBtn_Click(object sender, EventArgs e)
        {
            baseInfoGroupBox.Select();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            this.info = this.baseinfo.GetData();
            this.educationinfo = this.education.GetData();
            this.foodsafeinfo = this.foodsafe.GetData();
            this.jtinfo = this.jtsafe.GetData();
            this.ldpersoninfo = this.ldperson.GetData();
            this.safeproduceinfo = this.safeproduce.GetData();
            this.xfsafeinfo = this.xfsafe.GetData();
        }

        private void AddjgBtn_Click(object sender, EventArgs e)
        {
            SaveData();
            AddJGe dlg = new AddJGe(info.CompanyName);
            dlg.ShowDialog();
        }

        private void yhBtn_Click(object sender, EventArgs e)
        {
            SafeProductGroupBox.Select();
        }

        private void ViewjgBtn_Click(object sender, EventArgs e)
        {
            SaveData();
            ViewJGPhoto dlg = new ViewJGPhoto(info.CompanyName);
            dlg.ShowDialog();
        }




    }
}
