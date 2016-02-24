using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace JinZhan
{
    public partial class ViewJGPhoto : Form
    {
        private List<byte[]> strPhotoList = new List<byte[]>();
        private List<string> strInfoList = new List<string>();
        private int nPhotoIndex = 0;
        private System.Drawing.Image img1;
        private System.Drawing.Image img2;
        private System.Drawing.Image img3;
        public ViewJGPhoto()
        {
            InitializeComponent();
        }

        public ViewJGPhoto(string strCompanyName)
        {
            InitializeComponent();
            this.textBox4.Text = strCompanyName;
            if (!string.IsNullOrEmpty(this.textBox4.Text))
            {
                string strSql = "Select distinct(CheckTime) from T_CheckInfo";
                strSql += " where CompanyName like '" + this.textBox4.Text + "'";
                DataTable dt = SqlHelper.dataTable(strSql);
                this.dataGridView1.DataSource = dt;
                this.dataGridView1.Columns[0].HeaderText = "检查时间";
                this.dataGridView1.Columns[0].Width = 100;
            }
        }

        private void ViewJGPhoto_Load(object sender, EventArgs e)
        {
            this.nextBtn.Enabled = false;
            this.beforeBtn.Enabled = false;

        }

        private void GetPhotoByDate(string strDate,string strCompanyName)
        {
            byte[] data = new byte[0];
            using (SqlConnection conn = new SqlConnection(SqlHelper.sqlconstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from T_CheckInfo where CheckTime = '" + strDate + "' and CompanyName like '%" + strCompanyName + "%'";
                SqlDataReader sdr = cmd.ExecuteReader();
                this.strPhotoList.Clear();
                this.strInfoList.Clear();
                while (sdr.Read())
                {
                    data = (byte[])sdr["PhotoBit"];
                    this.strPhotoList.Add(data);
                    this.strInfoList.Add(sdr["Comment"].ToString());
                }
                sdr.Close();
                conn.Close();
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBox4.Text))
            {
                string strSql = "Select distinct(CheckTime) from T_CheckInfo";
                strSql += " where CompanyName like '" + this.textBox4.Text + "'";
                DataTable dt = SqlHelper.dataTable(strSql);
                this.dataGridView1.DataSource = dt;
                this.dataGridView1.Columns[0].HeaderText = "检查时间";
                this.dataGridView1.Columns[0].Width = 100;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if((e.RowIndex >= 0)&&(e.ColumnIndex >= 0))
            {
                string strDate = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                GetPhotoByDate(strDate, this.textBox4.Text);
                this.nPhotoIndex = 0;
                ShowPhoto();
                this.nextBtn.Enabled = true;
                if (4 >= this.strPhotoList.Count)
                {
                    this.nextBtn.Enabled = false;
                }
                this.beforeBtn.Enabled = false;
            }
        }

        private void ShowPhoto()
        {
            if (this.nPhotoIndex < 0)
            {
                this.beforeBtn.Enabled = false;
                return;
            }
            this.pictureBox1.Image = null;
            this.pictureBox2.Image = null;
            this.pictureBox3.Image = null;
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            int nIndex1 = 0 + this.nPhotoIndex * 3;
            if (this.strPhotoList.Count > nIndex1)
            {
                MemoryStream mystream = new MemoryStream(this.strPhotoList[nIndex1]);
                this.img1 = System.Drawing.Image.FromStream(mystream, true);
                this.pictureBox1.Image = this.img1;
                this.textBox1.Text = this.strInfoList[nIndex1];
            }
            else
            {
                this.nextBtn.Enabled = false;
            }
            int nIndex2 = 1 + this.nPhotoIndex * 3;
            if (this.strPhotoList.Count > nIndex2)
            {
                MemoryStream mystream = new MemoryStream(this.strPhotoList[nIndex2]);
                this.img2 = System.Drawing.Image.FromStream(mystream, true);
                this.pictureBox2.Image = this.img2;
                this.textBox2.Text = this.strInfoList[nIndex2];
            }
            else
            {
                this.nextBtn.Enabled = false;
            }
            int nIndex3 = 2 + this.nPhotoIndex * 3;
            if (this.strPhotoList.Count > nIndex3)
            {
                MemoryStream mystream = new MemoryStream(this.strPhotoList[nIndex3]);
                this.img3 = System.Drawing.Image.FromStream(mystream, true);
                this.pictureBox3.Image = this.img3;
                this.textBox3.Text = this.strInfoList[nIndex3];
            }
            else
            {
                this.nextBtn.Enabled = false;
            }
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

        private void beforeBtn_Click(object sender, EventArgs e)
        {
            LookBefore();
        }

        private void LookBefore()
        {
            --this.nPhotoIndex;
            if ((this.nPhotoIndex-1) < 0)
            {
                this.nPhotoIndex = 0;
                this.beforeBtn.Enabled = false;
            }
            this.nextBtn.Enabled = true;
            ShowPhoto();
        }

        private void LookNext()
        {
            ++this.nPhotoIndex;
            if ( 3 * (this.nPhotoIndex+1) >= this.strPhotoList.Count)
            {
                this.nextBtn.Enabled = false;
            }
            ShowPhoto();
            this.beforeBtn.Enabled = true;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            LookNext();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintPanel.GetGroup(this.groupBox1);
        }

    }
}
