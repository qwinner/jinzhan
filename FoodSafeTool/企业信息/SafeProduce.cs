using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JinZhan.企业信息
{
    public partial class SafeProduce : UserControl
    {
        public SafeProduce()
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

        public void SetData(SafeProduceInfo info)
        {
            if (info.SP1 == "1") { radioButton6.Checked = true; } else if (info.SP1 == "1") { radioButton3.Checked = true; } else { radioButton6.Checked = false; radioButton3.Checked = false; }
            if (info.SP2 == "1") { radioButton2.Checked = true; } else if (info.SP2 == "1") { radioButton1.Checked = true; } else { radioButton2.Checked = false; radioButton1.Checked = false; }
            if (info.SP3 == "1") { radioButton5.Checked = true; } else if (info.SP3 == "1") { radioButton4.Checked = true; } else { radioButton5.Checked = false; radioButton4.Checked = false; }
            if (info.SP4 == "1") { radioButton14.Checked = true; } else if (info.SP4 == "1") { radioButton13.Checked = true; } else { radioButton14.Checked = false; radioButton13.Checked = false; }
            if (info.SP5 == "1") { radioButton18.Checked = true; } else if (info.SP5 == "1") { radioButton17.Checked = true; } else { radioButton18.Checked = false; radioButton17.Checked = false; }
            if (info.SP6 == "1") { radioButton22.Checked = true; } else if (info.SP6 == "1") { radioButton21.Checked = true; } else { radioButton22.Checked = false; radioButton21.Checked = false; }
            if (info.SP7 == "1") { radioButton28.Checked = true; } else if (info.SP7 == "1") { radioButton27.Checked = true; } else { radioButton28.Checked = false; radioButton27.Checked = false; }
            if (info.SP8 == "1") { radioButton8.Checked = true; } else if (info.SP8 == "1") { radioButton7.Checked = true; } else { radioButton8.Checked = false; radioButton7.Checked = false; }
            if (info.SP9 == "1") { radioButton10.Checked = true; } else if (info.SP9 == "1") { radioButton9.Checked = true; } else { radioButton10.Checked = false;  radioButton9.Checked = false; }
            if (info.SP10 == "1") { radioButton12.Checked = true; } else if (info.SP10 == "1") { radioButton11.Checked = true; } else { radioButton12.Checked = false; radioButton11.Checked = false; }
            if (info.SP11 == "1") { radioButton16.Checked = true; } else if (info.SP11 == "1") { radioButton15.Checked = true; } else { radioButton16.Checked = false; radioButton15.Checked = false; }
            if (info.SP12 == "1") { radioButton20.Checked = true; } else if (info.SP12 == "1") { radioButton19.Checked = true; } else { radioButton20.Checked = false; radioButton19.Checked = false; }
            if (info.SP13 == "1") { radioButton24.Checked = true; } else if (info.SP13 == "1") { radioButton23.Checked = true; } else { radioButton24.Checked = false; radioButton23.Checked = false; }
            if (info.SP14 == "1") { radioButton26.Checked = true; } else if (info.SP14 == "1") { radioButton25.Checked = true; } else { radioButton26.Checked = false; radioButton25.Checked = false; }
            if (info.SP15 == "1") { radioButton44.Checked = true; } else if (info.SP15 == "1") { radioButton43.Checked = true; } else { radioButton44.Checked = false; radioButton43.Checked = false; }
            if (info.SP16 == "1") { radioButton40.Checked = true; } else if (info.SP16 == "1") { radioButton39.Checked = true; } else { radioButton40.Checked = false; radioButton39.Checked = false; }
            if (info.SP17 == "1") { radioButton36.Checked = true; } else if (info.SP17 == "1") { radioButton35.Checked = true; } else { radioButton36.Checked = false; radioButton35.Checked = false; }
            if (info.SP18 == "1") { radioButton42.Checked = true; } else if (info.SP18 == "1") { radioButton41.Checked = true; } else { radioButton42.Checked = false; radioButton41.Checked = false; }
            if (info.SP19 == "1") { radioButton38.Checked = true; } else if (info.SP19 == "1") { radioButton37.Checked = true; } else { radioButton38.Checked = false; radioButton37.Checked = false; }
            if (info.SP20 == "1") { radioButton34.Checked = true; } else if (info.SP20 == "1") { radioButton33.Checked = true; } else { radioButton34.Checked = false; radioButton33.Checked = false; }
            if (info.SP21 == "1") { radioButton32.Checked = true; } else if (info.SP21 == "1") { radioButton31.Checked = true; } else { radioButton32.Checked = false; radioButton31.Checked = false; }
            if (info.SP22 == "1") { radioButton72.Checked = true; } else if (info.SP22 == "1") { radioButton71.Checked = true; } else { radioButton72.Checked = false; radioButton71.Checked = false; }
            if (info.SP23 == "1") { radioButton68.Checked = true; } else if (info.SP23 == "1") { radioButton67.Checked = true; } else { radioButton68.Checked = false; radioButton67.Checked = false; }
            if (info.SP24 == "1") { radioButton64.Checked = true; } else if (info.SP24 == "1") { radioButton63.Checked = true; } else { radioButton64.Checked = false; radioButton63.Checked = false; }
            if (info.SP25 == "1") { radioButton60.Checked = true; } else if (info.SP25 == "1") { radioButton59.Checked = true; } else { radioButton60.Checked = false; radioButton59.Checked = false; }
            if (info.SP26 == "1") { radioButton56.Checked = true; } else if (info.SP26 == "1") { radioButton55.Checked = true; } else { radioButton56.Checked = false; radioButton55.Checked = false; }
            if (info.SP27 == "1") { radioButton52.Checked = true; } else if (info.SP27 == "1") { radioButton51.Checked = true; } else { radioButton52.Checked = false; radioButton51.Checked = false; }
            if (info.SP28 == "1") { radioButton48.Checked = true; } else if (info.SP28 == "1") { radioButton47.Checked = true; } else { radioButton48.Checked = false; radioButton47.Checked = false; }
            if (info.SP29 == "1") { radioButton30.Checked = true; } else if (info.SP29 == "1") { radioButton29.Checked = true; } else { radioButton30.Checked = false; radioButton29.Checked = false; }
            if (info.SP30 == "1") { radioButton70.Checked = true; } else if (info.SP30 == "1") { radioButton69.Checked = true; } else { radioButton70.Checked = false; radioButton69.Checked = false; }
            if (info.SP31 == "1") { radioButton66.Checked = true; } else if (info.SP31 == "1") { radioButton65.Checked = true; } else { radioButton66.Checked = false; radioButton65.Checked = false; }
            if (info.SP32 == "1") { radioButton62.Checked = true; } else if (info.SP32 == "1") { radioButton61.Checked = true; } else { radioButton62.Checked = false; radioButton61.Checked = false; }
            if (info.SP33 == "1") { radioButton58.Checked = true; } else if (info.SP33 == "1") { radioButton57.Checked = true; } else { radioButton58.Checked = false; radioButton57.Checked = false; }
            if (info.SP34 == "1") { radioButton54.Checked = true; } else if (info.SP34 == "1") { radioButton53.Checked = true; } else { radioButton54.Checked = false; radioButton53.Checked = false; }
            if (info.SP35 == "1") { radioButton50.Checked = true; } else if (info.SP35 == "1") { radioButton49.Checked = true; } else { radioButton50.Checked = false; radioButton49.Checked = false; }
            if (info.SP36 == "1") { radioButton46.Checked = true; } else if (info.SP36 == "1") { radioButton45.Checked = true; } else { radioButton46.Checked = false; radioButton45.Checked = false; }
            this.textBox3.Text = info.SP37;
            this.textBox1.Text = info.SP38;
            this.textBox2.Text = info.SP39;
            this.textBox4.Text = info.SP40;
            this.textBox5.Text = info.SP41;

        }

        public SafeProduceInfo GetData()
        {
            SafeProduceInfo info = new SafeProduceInfo();
            RadioButton[] rb1 = { radioButton6, radioButton3 };
            info.SP1 = Global.rbcheck(rb1);
            RadioButton[] rb2 = { radioButton2, radioButton1 };
            info.SP2 = Global.rbcheck(rb2);
            RadioButton[] rb3 = { radioButton5, radioButton4 };
            info.SP3 = Global.rbcheck(rb3);
            RadioButton[] rb4 = { radioButton14, radioButton13 };
            info.SP4 = Global.rbcheck(rb4);
            RadioButton[] rb5 = { radioButton18, radioButton17 };
            info.SP5 = Global.rbcheck(rb5);
            RadioButton[] rb6 = { radioButton22, radioButton21 };
            info.SP6 = Global.rbcheck(rb6);
            RadioButton[] rb7 = { radioButton28, radioButton27 };
            info.SP7 = Global.rbcheck(rb7);
            RadioButton[] rb8 = { radioButton8, radioButton7 };
            info.SP8 = Global.rbcheck(rb8);
            RadioButton[] rb9 = { radioButton10, radioButton9 };
            info.SP9 = Global.rbcheck(rb9);
            RadioButton[] rb10 = { radioButton12, radioButton11 };
            info.SP10 = Global.rbcheck(rb10);
            RadioButton[] rb11 = { radioButton16, radioButton15 };
            info.SP11 = Global.rbcheck(rb11);
            RadioButton[] rb12 = { radioButton20, radioButton19 };
            info.SP12 = Global.rbcheck(rb12);
            RadioButton[] rb13 = { radioButton24, radioButton23 };
            info.SP13 = Global.rbcheck(rb13);
            RadioButton[] rb14 = { radioButton26, radioButton25 };
            info.SP14 = Global.rbcheck(rb14);
            RadioButton[] rb15 = { radioButton44, radioButton43 };
            info.SP15 = Global.rbcheck(rb15);
            RadioButton[] rb16 = { radioButton40, radioButton39 };
            info.SP16 = Global.rbcheck(rb16);
            RadioButton[] rb17 = { radioButton36, radioButton35 };
            info.SP17 = Global.rbcheck(rb17);
            RadioButton[] rb18 = { radioButton42, radioButton41 };
            info.SP18 = Global.rbcheck(rb18);
            RadioButton[] rb19 = { radioButton38, radioButton37 };
            info.SP19 = Global.rbcheck(rb19);
            RadioButton[] rb20 = { radioButton34, radioButton33 };
            info.SP20 = Global.rbcheck(rb20);
            RadioButton[] rb21 = { radioButton32, radioButton31 };
            info.SP21 = Global.rbcheck(rb21);
            RadioButton[] rb22 = { radioButton72, radioButton71 };
            info.SP22 = Global.rbcheck(rb22);
            RadioButton[] rb23 = { radioButton68, radioButton67 };
            info.SP23 = Global.rbcheck(rb23);
            RadioButton[] rb24 = { radioButton64, radioButton63 };
            info.SP24 = Global.rbcheck(rb24);
            RadioButton[] rb25 = { radioButton60, radioButton59 };
            info.SP25 = Global.rbcheck(rb25);
            RadioButton[] rb26 = { radioButton56, radioButton55 };
            info.SP26 = Global.rbcheck(rb26);
            RadioButton[] rb27 = { radioButton52, radioButton51 };
            info.SP27 = Global.rbcheck(rb27);
            RadioButton[] rb28 = { radioButton48, radioButton47 };
            info.SP28 = Global.rbcheck(rb28);
            RadioButton[] rb29 = { radioButton30, radioButton29 };
            info.SP29 = Global.rbcheck(rb29);
            RadioButton[] rb30 = { radioButton70, radioButton69 };
            info.SP30 = Global.rbcheck(rb30);
            RadioButton[] rb31 = { radioButton66, radioButton65 };
            info.SP31 = Global.rbcheck(rb31);
            RadioButton[] rb32 = { radioButton62, radioButton61 };
            info.SP32 = Global.rbcheck(rb32);
            RadioButton[] rb33 = { radioButton58, radioButton57 };
            info.SP33 = Global.rbcheck(rb33);
            RadioButton[] rb34 = { radioButton54, radioButton53 };
            info.SP34 = Global.rbcheck(rb34);
            RadioButton[] rb35 = { radioButton50, radioButton49 };
            info.SP35 = Global.rbcheck(rb35);
            RadioButton[] rb36 = { radioButton46, radioButton45 };
            info.SP36 = Global.rbcheck(rb36);
            info.SP37 = this.textBox3.Text;
            info.SP38 = this.textBox1.Text;
            info.SP39 = this.textBox2.Text;
            info.SP40 = this.textBox4.Text;
            info.SP41 = this.textBox5.Text;
            info.YinHNum = GetYinHuanNum(info);

            return info;
        }

        private string GetYinHuanNum(SafeProduceInfo info)
        {
            int Ret = 0;
            Ret += IsYinHuan(info.SP1) ? 0 : 1;
            Ret += IsYinHuan(info.SP2) ? 1 : 0;
            Ret += IsYinHuan(info.SP3) ? 1 : 0;
            Ret += IsYinHuan(info.SP4) ? 1 : 0;
            Ret += IsYinHuan(info.SP5) ? 1 : 0;
            Ret += IsYinHuan(info.SP6) ? 1 : 0;
            Ret += IsYinHuan(info.SP7) ? 1 : 0;
            Ret += IsYinHuan(info.SP8) ? 1 : 0;
            Ret += IsYinHuan(info.SP9) ? 1 : 0;
            Ret += IsYinHuan(info.SP10) ? 1 : 0;
            Ret += IsYinHuan(info.SP11) ? 1 : 0;
            Ret += IsYinHuan(info.SP12) ? 1 : 0;
            Ret += IsYinHuan(info.SP13) ? 1 : 0;
            Ret += IsYinHuan(info.SP14) ? 1 : 0;
            Ret += IsYinHuan(info.SP15) ? 1 : 0;
            Ret += IsYinHuan(info.SP16) ? 1 : 0;
            Ret += IsYinHuan(info.SP17) ? 1 : 0;
            Ret += IsYinHuan(info.SP18) ? 1 : 0;
            Ret += IsYinHuan(info.SP19) ? 1 : 0;
            Ret += IsYinHuan(info.SP20) ? 1 : 0;
            Ret += IsYinHuan(info.SP21) ? 1 : 0;
            Ret += IsYinHuan(info.SP22) ? 1 : 0;
            Ret += IsYinHuan(info.SP23) ? 1 : 0;
            Ret += IsYinHuan(info.SP24) ? 1 : 0;
            Ret += IsYinHuan(info.SP25) ? 1 : 0;
            Ret += IsYinHuan(info.SP26) ? 1 : 0;
            Ret += IsYinHuan(info.SP27) ? 1 : 0;
            Ret += IsYinHuan(info.SP28) ? 1 : 0;
            Ret += IsYinHuan(info.SP29) ? 1 : 0;
            Ret += IsYinHuan(info.SP30) ? 1 : 0;
            Ret += IsYinHuan(info.SP31) ? 1 : 0;
            Ret += IsYinHuan(info.SP32) ? 1 : 0;
            Ret += IsYinHuan(info.SP33) ? 1 : 0;
            Ret += IsYinHuan(info.SP34) ? 1 : 0;
            Ret += IsYinHuan(info.SP35) ? 1 : 0;
            Ret += IsYinHuan(info.SP36) ? 1 : 0;

            return Ret.ToString();
        }

        private bool IsYinHuan(string data)
        {
            bool Ret = false;
            if (data == "2")
            {
                Ret = true;
            }
            return Ret;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            SafeProduceInfo spinfo = new SafeProduceInfo();
            spinfo.SP1 = string.Empty;
            spinfo.SP2 = string.Empty;
            spinfo.SP3 = string.Empty;
            spinfo.SP4 = string.Empty;
            spinfo.SP5 = string.Empty;
            spinfo.SP6 = string.Empty;
            spinfo.SP7 = string.Empty;
            spinfo.SP8 = string.Empty;
            spinfo.SP9 = string.Empty;
            spinfo.SP10 = string.Empty;
            spinfo.SP11 = string.Empty;
            spinfo.SP12 = string.Empty;
            spinfo.SP13 = string.Empty;
            spinfo.SP14 = string.Empty;
            spinfo.SP15 = string.Empty;
            spinfo.SP16 = string.Empty;
            spinfo.SP17 = string.Empty;
            spinfo.SP18 = string.Empty;
            spinfo.SP19 = string.Empty;
            spinfo.SP20 = string.Empty;
            spinfo.SP21 = string.Empty;
            spinfo.SP22 = string.Empty;
            spinfo.SP23 = string.Empty;
            spinfo.SP24 = string.Empty;
            spinfo.SP25 = string.Empty;
            spinfo.SP26 = string.Empty;
            spinfo.SP27 = string.Empty;
            spinfo.SP28 = string.Empty;
            spinfo.SP29 = string.Empty;
            spinfo.SP30 = string.Empty;
            spinfo.SP31 = string.Empty;
            spinfo.SP32 = string.Empty;
            spinfo.SP33 = string.Empty;
            spinfo.SP34 = string.Empty;
            spinfo.SP35 = string.Empty;
            spinfo.SP36 = string.Empty;
            spinfo.SP37 = string.Empty;
            spinfo.SP38 = string.Empty;
            spinfo.SP39 = string.Empty;
            spinfo.SP40 = string.Empty;
            spinfo.SP41 = string.Empty;
            spinfo.YinHNum = string.Empty;

            SetData(spinfo);
        }
    }

    public class SafeProduceInfo
    {
        public string SP1       { get; set; }
        public string SP2       { get; set; }
        public string SP3       { get; set; }
        public string SP4       { get; set; }
        public string SP5       { get; set; }
        public string SP6       { get; set; }
        public string SP7       { get; set; }
        public string SP8       { get; set; }
        public string SP9       { get; set; }
        public string SP10      { get; set; }
        public string SP11      { get; set; }
        public string SP12      { get; set; }
        public string SP13      { get; set; }
        public string SP14      { get; set; }
        public string SP15      { get; set; }
        public string SP16      { get; set; }
        public string SP17      { get; set; }
        public string SP18      { get; set; }
        public string SP19      { get; set; }
        public string SP20      { get; set; }
        public string SP21      { get; set; }
        public string SP22      { get; set; }
        public string SP23      { get; set; }
        public string SP24      { get; set; }
        public string SP25      { get; set; }
        public string SP26      { get; set; }
        public string SP27      { get; set; }
        public string SP28      { get; set; }
        public string SP29      { get; set; }
        public string SP30      { get; set; }
        public string SP31      { get; set; }
        public string SP32      { get; set; }
        public string SP33      { get; set; }
        public string SP34      { get; set; }
        public string SP35      { get; set; }
        public string SP36      { get; set; }
        public string SP37      { get; set; }
        public string SP38      { get; set; }
        public string SP39      { get; set; }
        public string SP40      { get; set; }
        public string SP41      { get; set; }
        public string YinHNum   { get; set; }
    }
}
