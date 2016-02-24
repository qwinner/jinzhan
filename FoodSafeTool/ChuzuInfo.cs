using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JinZhan
{
    public partial class ChuzuInfo : UserControl
    {
        public ChuzuInfo()
        {
            InitializeComponent();
        }
        public void SetData(string strNum3)
        {
            this.companySettleNumtextBox.Text = strNum3;
        }
    }
}
