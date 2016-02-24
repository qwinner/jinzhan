using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JinZhan.企业信息
{
    public partial class Foodsafe : UserControl
    {
        public Foodsafe()
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

        public void SetData(FoodSafeInfo info)
        {
            this.CompanyType.Text = info.CompanyType;
            this.HasLicense.Text = info.HasLicense;
            this.LicenseName.Text = info.LicenseName;
        }

        public FoodSafeInfo GetData()
        {
            FoodSafeInfo info = new FoodSafeInfo();
            info.CompanyType = this.CompanyType.Text;
            info.HasLicense  = this.HasLicense.Text;
            info.LicenseName = this.LicenseName.Text;

            return info;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            FoodSafeInfo foodinfo = new FoodSafeInfo();
            foodinfo.CompanyType = null;
            foodinfo.HasLicense = null;
            foodinfo.LicenseName = null;

            SetData(foodinfo);
        }
    }

    public class FoodSafeInfo
    {
        public string CompanyType { get; set; }
        public string HasLicense { get; set; }
        public string LicenseName { get; set; }
    }
}
