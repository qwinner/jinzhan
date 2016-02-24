using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JinZhan.企业信息
{
    public partial class XFsafe : UserControl
    {
        public XFsafe()
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

        public void SetData(XFsafeInfo info)
        {
            this.ManagerName.Text = info.ManagerName;
            this.Telephone.Text = info.XFTelephone;
            if (info.HasSafeSystem == "1") { radioButton6.Checked = true; } else if (info.HasSafeSystem == "1") { radioButton3.Checked = true; } else { radioButton6.Checked = false; radioButton3.Checked = false; }
            if (info.DianXiaoJian == "1") { radioButton2.Checked = true; } else if (info.DianXiaoJian == "1") { radioButton1.Checked = true; } else { radioButton2.Checked = false; radioButton1.Checked = false; }
            if (info.HasSafeBook == "1") { radioButton5.Checked = true; } else if (info.HasSafeBook == "1") { radioButton4.Checked = true; } else { radioButton5.Checked = false; radioButton4.Checked = false; }
        }

        public XFsafeInfo GetData()
        {
            XFsafeInfo info = new XFsafeInfo();
            info.ManagerName   = this.ManagerName.Text;
            info.XFTelephone     = this.Telephone.Text;
            RadioButton[] rb1 = { radioButton6, radioButton3 };
            info.HasSafeSystem = Global.rbcheck(rb1);
            RadioButton[] rb2 = { radioButton2, radioButton1 };
            info.DianXiaoJian = Global.rbcheck(rb2);
            RadioButton[] rb3 = { radioButton5, radioButton4 };
            info.HasSafeBook = Global.rbcheck(rb3);

            return info;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            XFsafeInfo xfinfo = new XFsafeInfo();
            xfinfo.ManagerName = string.Empty;
            xfinfo.XFTelephone = string.Empty;
            xfinfo.HasSafeSystem = string.Empty;
            xfinfo.DianXiaoJian = string.Empty;
            xfinfo.HasSafeBook = string.Empty;

            SetData(xfinfo);
        }
    }

    public class XFsafeInfo
    {
        public string ManagerName      { get; set; }
        public string XFTelephone        { get; set; }
        public string HasSafeSystem    { get; set; }
        public string DianXiaoJian     { get; set; }
        public string HasSafeBook      { get; set; }
    }
}
