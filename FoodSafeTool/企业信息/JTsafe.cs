using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JinZhan.企业信息
{
    public partial class JTsafe : UserControl
    {
        public JTsafe()
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

        public JTsafeInfo GetData()
        {
            JTsafeInfo info = new JTsafeInfo();
            info.StrCarNum = this.StrCarNum.Text;
            info.IsProf = this.IsProf.Text;
            info.TranBy = this.TranBy.Text;
            info.TranType = this.TranType.SelectedText;
            return info;
        }

        public void SetData(JTsafeInfo info)
        {
            this.StrCarNum.Text = info.StrCarNum;
            this.IsProf.Text = info.IsProf;
            this.TranBy.Text = info.TranBy;
            this.TranType.Text = info.TranType;
        }

        public void SetReadOnly()
        {
            this.StrCarNum.ReadOnly = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            TranType.Items.Clear();
            TranType.Items.AddRange(GetJTsafeTranType(TranBy.SelectedIndex).ToArray());
        }

        private List<string> GetJTsafeTranType(int nIndex)
        {
            List<string> data = new List<string>();
            if (1 == nIndex)
            {
                data.Add("专业客运出租");
                data.Add("专业客运公交");
                data.Add("专业客运省际长途");
                data.Add("专业客运旅游");
                data.Add("专业客运小公共 ");
                data.Add("商业网点免费班车");
                data.Add("社区班车");
            }
            else if(2==nIndex)
            {
                data.Add("专业货运水泥罐车");
                data.Add("专业货运化危险品");
                data.Add("专业货运搬家");
                data.Add("专业货运物流");
                data.Add("专业货运邮政汽运 ");
                data.Add("专业货运清洁环卫");
                data.Add("专业货运机械施工");
                data.Add("专业货运运输服务站 ");
                data.Add("专业货运运输公司");
                data.Add("水泥泵车");
                data.Add("特种车");
            }
            else
            {}
            return data;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            JTsafeInfo jtinfo = new JTsafeInfo();
            jtinfo.StrCarNum = null;
            jtinfo.IsProf = null;
            jtinfo.TranBy = null;
            jtinfo.TranType = null;

            SetData(jtinfo);
        }

        private void IsProf_SelectedIndexChanged(object sender, EventArgs e)
        {
            TranBy.Items.Clear();
            TranType.Items.Clear();
            if (this.IsProf.SelectedIndex == 1)
            {
                TranBy.Items.Add(" ");
                TranBy.Items.Add("专业客运");
                TranBy.Items.Add("专业货运");
            }
        }
    } 
    public class JTsafeInfo 
    {
        public string StrCarNum { get; set; }
        public string IsProf { get; set; }
        public string TranBy { get; set; }
        public string TranType { get; set; }
    }
}
