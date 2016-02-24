using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JinZhan
{
    public partial class Base : UserControl
    {
        private byte[] PhotoBit1;
        private byte[] PhotoBit2;
        private byte[] PhotoBit3;
        public Base()
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

        public BaseInfo GetData()
        {
            BaseInfo info = new BaseInfo();
            info.CompanyName = textBox1.Text;
            info.Faren = textBox2.Text;
            info.FaPhoneNum = textBox3.Text;
            info.CompanyAddressA = comboBox1.Text;
            info.CompanyAddressB = textBox6.Text;
            info.ChenBaoPerson = textBox5.Text;
            info.ChenBaoPhoneNum = textBox4.Text;
            info.ChenBaoAddress = textBox9.Text;
            RadioButton[] rb = { radioButton1, radioButton2, radioButton3 };
            info.HasYingyeId = Global.rbcheck(rb);
            info.JingYingContent = comboBox2.Text;
            info.ZhuceNum = this.textBox13.Text;
            info.CompanyPersonNum = textBox8.Text;
            RadioButton[] rb1 = { radioButton4, radioButton5};
            info.HasShiTang = Global.rbcheck(rb1);
            info.EatPersonNum = textBox11.Text;
            string strChangDi = (checkBox1.Checked) ? "1," : null;
            strChangDi += (checkBox2.Checked) ? "2," : null;
            strChangDi += (checkBox3.Checked) ? "3," : null;
            strChangDi += (checkBox4.Checked) ? "4," : null;
            strChangDi += (checkBox5.Checked) ? "5," : null;
            info.ChangDi = strChangDi;
            info.SleepPersonNum = textBox12.Text;
            info.JianzhuSquere = textBox10.Text;
            info.JianzhuType = jianzhuleixing.Text;
            info.CompanyStatus = comboBox3.Text;

            info.PhotoPath1 = this.PhotoBit1;
            info.PhotoPath2 = this.PhotoBit2;
            info.PhotoPath3 = this.PhotoBit3;
            return info;
        }

        public void SetReadOnly( bool bReadOnly)
        {
            textBox1.ReadOnly = bReadOnly;
            textBox2.ReadOnly = bReadOnly;
            textBox3.ReadOnly = bReadOnly;
            textBox6.ReadOnly = bReadOnly;
            textBox5.ReadOnly = bReadOnly;
            textBox4.ReadOnly = bReadOnly;
            textBox9.ReadOnly = bReadOnly;
            textBox13.ReadOnly = bReadOnly;
            textBox8.ReadOnly = bReadOnly;
            textBox11.ReadOnly = bReadOnly;
            textBox12.ReadOnly = bReadOnly;
            textBox10.ReadOnly = bReadOnly;

        }

        public void SetData(BaseInfo info)
        {
            textBox1.Text = info.CompanyName;
            textBox2.Text = info.Faren;
            textBox3.Text = info.FaPhoneNum;
            comboBox1.Text = info.CompanyAddressA;
            textBox6.Text = info.CompanyAddressB;
            textBox5.Text = info.ChenBaoPerson;
            textBox4.Text = info.ChenBaoPhoneNum;
            textBox9.Text = info.ChenBaoAddress;
            comboBox2.Text = info.JingYingContent;
            textBox13.Text = info.ZhuceNum;
            textBox8.Text = info.CompanyPersonNum;
            textBox11.Text =info.EatPersonNum;
            textBox12.Text =info.SleepPersonNum;
            textBox10.Text = info.JianzhuSquere;
            jianzhuleixing.Text = info.JianzhuType;
            comboBox3.Text = info.CompanyStatus;

            switch (info.HasYingyeId)
            {
                case "1":
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    break;
                case "2": 
                    radioButton2.Checked = true;
                    radioButton1.Checked = false;
                    radioButton3.Checked = false;
                    break;
                case "3":
                    radioButton3.Checked = true;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    break;
                default:
                    radioButton3.Checked = false;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    break;
            }
            if (info.HasShiTang == "1")
            {
                radioButton4.Checked = true;
                radioButton5.Checked = false;
            }
            else if (info.HasShiTang == "2")
            {
                radioButton5.Checked = true;
                radioButton4.Checked = false;
            }
            else
            {
                radioButton5.Checked = false;
                radioButton4.Checked = false;
            }

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            if (info.ChangDi != null)
            {
                string[] strChangdi = info.ChangDi.Split(new char[',']);
                foreach (string var in strChangdi)
                {
                    if (var == "1")
                    {
                        checkBox1.Checked = true;
                    }
                    if (var == "2")
                    {
                        checkBox2.Checked = true;
                    }
                    if (var == "3")
                    {
                        checkBox3.Checked = true;
                    }
                    if (var == "4")
                    {
                        checkBox4.Checked = true;
                    }
                    if (var == "5")
                    {
                        checkBox5.Checked = true;
                    }
                }
            }
            try
            {
                this.PhotoBit1 = info.PhotoPath1;
                if (info.PhotoPath1 != null)
                {
                    MemoryStream mystream = new MemoryStream(info.PhotoPath1);
                    System.Drawing.Image img1 = System.Drawing.Image.FromStream(mystream, true);
                    this.pictureBox1.Image = img1;
                }
                else
                {
                    this.pictureBox1.Image = null;
                }
                this.PhotoBit2 = info.PhotoPath2;
                if (info.PhotoPath2 != null)
                {
                    MemoryStream mystream = new MemoryStream(info.PhotoPath2);
                    System.Drawing.Image img1 = System.Drawing.Image.FromStream(mystream, true);
                    this.pictureBox2.Image = img1;
                }
                else
                {
                    this.pictureBox2.Image = null;
                }
                this.PhotoBit3 = info.PhotoPath3;
                if (info.PhotoPath3 != null)
                {
                    MemoryStream mystream = new MemoryStream(info.PhotoPath3);
                    System.Drawing.Image img1 = System.Drawing.Image.FromStream(mystream, true);
                    this.pictureBox3.Image = img1;
                }
                else
                {
                    this.pictureBox3.Image = null;
                }
            }
            catch { }
        }

        private void groupBox11_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.groupBox11.BackColor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Supported Image Types (*.jpg, *.gif, *.bmp)|*.jpg;*.gif;*.bmp|JPEG Image|*.jpg|GIF Image|*.gif|BITMAP Image|*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(dlg.FileName);
                    this.PhotoBit1 = GetPhotoBit(dlg.FileName);
                }
            }
            catch
            {
                MessageBox.Show("添加照片错误");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Supported Image Types (*.jpg, *.gif, *.bmp)|*.jpg;*.gif;*.bmp|JPEG Image|*.jpg|GIF Image|*.gif|BITMAP Image|*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image = Image.FromFile(dlg.FileName);
                    this.PhotoBit2 = GetPhotoBit(dlg.FileName);
                }
            }
            catch
            {
                MessageBox.Show("添加照片错误");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Supported Image Types (*.jpg, *.gif, *.bmp)|*.jpg;*.gif;*.bmp|JPEG Image|*.jpg|GIF Image|*.gif|BITMAP Image|*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox3.Image = Image.FromFile(dlg.FileName);
                    this.PhotoBit3 = GetPhotoBit(dlg.FileName);
                }
            }
            catch
            {
                MessageBox.Show("添加照片错误");
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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            BaseInfo baseinfo = new BaseInfo();
            baseinfo.CompanyName = null;
            baseinfo.Faren = null;
            baseinfo.FaPhoneNum = null;
            baseinfo.CompanyAddressA = null;
            baseinfo.CompanyAddressB = null;
            baseinfo.ChenBaoPerson = null;
            baseinfo.ChenBaoPhoneNum = null;
            baseinfo.ChenBaoAddress = null;
            baseinfo.HasYingyeId = null;
            baseinfo.JingYingContent = null;
            baseinfo.ZhuceNum = null;
            baseinfo.CompanyPersonNum = null;
            baseinfo.HasShiTang       = null;
            baseinfo.EatPersonNum     = null;
            baseinfo.ChangDi          = null;
            baseinfo.SleepPersonNum   = null;
            baseinfo.JianzhuSquere    = null;
            baseinfo.JianzhuType      = null;
            baseinfo.CompanyStatus    = null;
            baseinfo.PhotoPath1       = null;
            baseinfo.PhotoPath2       = null;
            baseinfo.PhotoPath3       = null;
            SetData(baseinfo);

            comboBox1.Text = null;
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

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            if (this.pictureBox2.Image != null)
            {
                OpenPhoto(this.pictureBox2.Image);
            }
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            if (this.pictureBox3.Image != null)
            {
                OpenPhoto(this.pictureBox3.Image);
            }
        }
    }

    public class BaseInfo
    {
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string Faren { get; set; }
        public string FaPhoneNum { get; set; }
        public string CompanyAddressA { get; set; }
        public string CompanyAddressB { get; set; }
        public string ChenBaoPerson { get; set; }
        public string ChenBaoPhoneNum { get; set; }
        public string ChenBaoAddress { get; set; }
        public string HasYingyeId { get; set; }
        public string JingYingContent { get; set; }
        public string ZhuceNum { get; set; }
        public string CompanyPersonNum { get; set; }
        public string HasShiTang { get; set; }
        public string EatPersonNum { get; set; }
        public string ChangDi { get; set; }
        public string SleepPersonNum { get; set; }
        public string JianzhuSquere { get; set; }
        public string JianzhuType { get; set; }
        public string CompanyStatus { get; set; }
        public byte[] PhotoPath1 { get; set; }
        public byte[] PhotoPath2 { get; set; }
        public byte[] PhotoPath3 { get; set; }

    }
}
