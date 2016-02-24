using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JinZhan.企业信息
{
    public partial class Education : UserControl
    {
        public Education()
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

        public void SetData(EducationInfo info)
        {
            this.typeComboBox.Text = info.Type;
            this.buildTime.Value = info.BuidTime;
            this.classNum.Text = info.ClassNum;
            this.houseType.Text = info.HouseType;
            this.studentNum.Text = info.StudentNum;
            this.HouseProperty.Text = info.HouseProperty;
            this.teacherNum.Text = info.TeacherNum;
            this.ownerProperty.Text = info.OwnerProperty;
            this.ownerName.Text = info.OwnerName;
            this.zhandiSquere.Text = info.ZhandiSquere;
            this.huodongSquere.Text = info.HuodongSquere;
            this.jianzhuSquere.Text = info.SchoolJianzhuSquere;
        }

        public EducationInfo GetData()
        {
            EducationInfo info = new EducationInfo();
            info.Type = this.typeComboBox.Text;
            info.BuidTime = this.buildTime.Value.Date;
            info.ClassNum = this.classNum.Text;
            info.HouseType = this.houseType.Text;
            info.StudentNum = this.studentNum.Text;
            info.HouseProperty = this.HouseProperty.Text;
            info.TeacherNum = this.teacherNum.Text;
            info.OwnerProperty = this.ownerProperty.Text;
            info.OwnerName = this.ownerName.Text;
            info.ZhandiSquere = this.zhandiSquere.Text;
            info.HuodongSquere = this.huodongSquere.Text;
            info.SchoolJianzhuSquere = this.jianzhuSquere.Text;

            return info;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            EducationInfo educationinfo = new EducationInfo();
            educationinfo.Type = null;
            educationinfo.BuidTime = DateTime.Now;
            educationinfo.ClassNum = null;
            educationinfo.HouseType = null;
            educationinfo.StudentNum = null;
            educationinfo.HouseProperty = null;
            educationinfo.TeacherNum = null;
            educationinfo.OwnerProperty = null;
            educationinfo.OwnerName = null;
            educationinfo.ZhandiSquere = null;
            educationinfo.HuodongSquere = null;
            educationinfo.SchoolJianzhuSquere = null;
            SetData(educationinfo);
        }

    }

    public class EducationInfo
    {
        public string Type { get; set; }
        public DateTime BuidTime{ get; set; }
        public string ClassNum { get; set; }
        public string HouseType { get; set; }
        public string StudentNum { get; set; }
        public string HouseProperty { get; set; }
        public string TeacherNum { get; set; }
        public string OwnerProperty { get; set; }
        public string OwnerName { get; set; }
        public string ZhandiSquere { get; set; }
        public string HuodongSquere { get; set; }
        public string SchoolJianzhuSquere { get; set; }
    }
}
