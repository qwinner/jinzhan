using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JinZhan.企业信息
{
    public partial class LDperson : UserControl
    {
        public LDperson()
        {
            InitializeComponent();
            if (Global.authority == Authority.Looker)
            {
                this.clearBtn.Enabled = false;
            }
            else
            {
                this.clearBtn.Enabled = true;
            }
        }

        public void SetReadOnly()
        {

        }

        public void SetData(LDpersonInfo info)
        {
            this.LivePersonNum.Text  = info.LivePersonNum;
            this.LiveHouseNum.Text   = info.LiveHouseNum;
            this.HouseFloorNum.Text  = info.HouseFloorNum;
            this.GetWarmStyle.Text   = info.GetWarmStyle;
            if (info.HasWarnning == "1") 
            { 
                radioButton5.Checked = true; 
            }
            else if (info.HasWarnning == "2")
            {
                radioButton4.Checked = true;
            }
            else { radioButton5.Checked = false; radioButton4.Checked = false; }
            this.HirePersonType.Text = info.HirePersonType;
            if (info.HasPromiseBook == "1")
            { 
                radioButton2.Checked = true;
            }
            else if (info.HasPromiseBook == "2")
            {
                radioButton1.Checked = true;
            }
            else { radioButton2.Checked = false; radioButton1.Checked = false; }
            if (info.IsBackUp == "1")
            { 
                radioButton6.Checked = true; 
            }
            else if (info.IsBackUp == "2")
            {
                radioButton3.Checked = true;
            }
            else { radioButton6.Checked = false; radioButton3.Checked = false; }
            this.BuildSquere.Text    = info.BuildSquere;
            this.OwnerPerson.Text    = info.OwnerPerson;
            this.Telephone.Text      = info.Telephone;

        }

        public LDpersonInfo GetData()
        {
            LDpersonInfo info = new LDpersonInfo();
            info.LivePersonNum =this.LivePersonNum .Text;
            info.LiveHouseNum  =this.LiveHouseNum  .Text;
            info.HouseFloorNum =this.HouseFloorNum .Text;
            info.GetWarmStyle  =this.GetWarmStyle  .Text;

            RadioButton[] rb1 = { radioButton5, radioButton4 };
            info.HasWarnning = Global.rbcheck(rb1);
            info.HirePersonType=this.HirePersonType.Text;
            RadioButton[] rb2 = { radioButton2, radioButton1 };
            info.HasPromiseBook = Global.rbcheck(rb2);
            RadioButton[] rb3 = { radioButton6, radioButton3 };
            info.IsBackUp = Global.rbcheck(rb3);

            info.BuildSquere   =this.BuildSquere   .Text;
            info.OwnerPerson   =this.OwnerPerson   .Text;
            info.Telephone = this.Telephone.Text;

            return info;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            LDpersonInfo ldinfo = new LDpersonInfo();
            ldinfo.LivePersonNum = null;
            ldinfo.LiveHouseNum = null;
            ldinfo.HouseFloorNum = null;
            ldinfo.GetWarmStyle = null;
            ldinfo.HasWarnning = null;
            ldinfo.HirePersonType = null;
            ldinfo.HasPromiseBook = null;
            ldinfo.IsBackUp = null;
            ldinfo.BuildSquere = null;
            ldinfo.OwnerPerson = null;
            ldinfo.Telephone = null;

            SetData(ldinfo);
        }
    }

    public class LDpersonInfo
    {
        public string LivePersonNum   { get; set; }
        public string LiveHouseNum    { get; set; }
        public string HouseFloorNum   { get; set; }
        public string GetWarmStyle    { get; set; }
        public string HasWarnning     { get; set; }
        public string HirePersonType  { get; set; }
        public string HasPromiseBook  { get; set; }
        public string IsBackUp        { get; set; }
        public string BuildSquere     { get; set; }
        public string OwnerPerson     { get; set; }
        public string Telephone       { get; set; }
    }
}
