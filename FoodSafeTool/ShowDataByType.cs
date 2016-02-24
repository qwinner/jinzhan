using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.OleDb;
using System.Collections;

namespace FoodSafeTool
{
    public partial class ShowDataByType : Form
    {
        public ShowDataByType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.chart1
        }

        private void ShowDataByType_Load(object sender, EventArgs e)
        {
            chartlet1.ChartTitle.Text = "企业信息表";
            chartlet1.ChartTitle.OffsetY = -15;
            chartlet1.AppearanceStyle = FanG.Chartlet.AppearanceStyles.Bar_2D_Aurora_FlatCrystal_Glow_NoBorder;
            chartlet1.Background.Paper = Color.FromArgb(0, 0, 0, 0);

            string strSql = "Select food,sum(Sales) as  满意,sum(Cost) as 较满意,sum(Profit) as 不满意 from Sales group by food";
            DataSet ds = AccessHelper.dataSet(strSql);
            chartlet1.BindChartData(ds);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //动态修改外观
            switch (comboBox1.SelectedIndex)
            {
                case 0: chartlet1.AppearanceStyle = FanG.Chartlet.AppearanceStyles.Bar_2D_Aurora_FlatCrystal_Glow_NoBorder; break;
                case 1: chartlet1.AppearanceStyle = FanG.Chartlet.AppearanceStyles.Line_3D_Aurora_FlatCrystalSquare_NoGlow_NoBorder; break;
                case 2: chartlet1.AppearanceStyle = FanG.Chartlet.AppearanceStyles.Pie_3D_Aurora_FlatCrystal_NoGlow_NoBorder; break;
                default: ; break;
            }
            //每次希望修改属性后立即重绘图形就需要调用 Refresh()方法
            chartlet1.Refresh();
        }

        private void ShowDataByType_FormClosed(object sender, FormClosedEventArgs e)
        {
            //类似于所有控件，需要在推出前嗲用Dispose()方法来释放资源
            chartlet1.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //将自定义颜色赋给内置的颜色数组
            chartlet1.Aurora[0] = Color.Black;
            chartlet1.Aurora[1] = Color.BlueViolet;
            //颜色数组总共有12个颜色元素 。。。Aurora[11]

            chartlet1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                //case 0:
                //     chartlet1.ChartTitle.Text = "企业信息表";
                //    chartlet1.ChartTitle.OffsetY = -8;
                //    chartlet1.AppearanceStyle = FanG.Chartlet.AppearanceStyles.Bar_2D_Aurora_FlatCrystal_Glow_NoBorder;
                //    chartlet1.Background.Paper = Color.FromArgb(0, 0, 0, 0);
                //    string strSql = "Select food,sum(Sales) as  满意,sum(Cost) as 较满意,sum(Profit) as 不满意 from Sales group by food";
                //      DataSet ds = AccessHelper.dataSet(strSql);
                //      chartlet1.BindChartData(ds);
                //    break;
                case 0:
                     chartlet1.ChartTitle.Text = "企业信息表";
                      chartlet1.ChartTitle.OffsetY = -15;
                      chartlet1.AppearanceStyle = FanG.Chartlet.AppearanceStyles.Bar_2D_Aurora_FlatCrystal_Glow_NoBorder;
                    chartlet1.Background.Paper = Color.FromArgb(0, 0, 0, 0);
                    string strSql1 = "Select food,sum(Sales) as  满意,Count(Cost) as 较满意,sum(Profit) as 不满意 from Sales group by food";
                      DataSet ds1 = AccessHelper.dataSet(strSql1);
                      chartlet1.BindChartData(ds1);
                    break;
                default: ; break;
            }
        }



    }
}
