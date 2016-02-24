using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace JinZhan
{
    public partial class AddJGe : Form
    {
        private ImageList imgList = new ImageList();
        private int nImgIndex = 0;
        private string strTmpImgPath;
        private List<string> strPathList = new List<string>();
        private List<string> strInfoList = new List<string>();

        private string strCompanyName;
        public AddJGe()
        {
            InitializeComponent();
        }
        public AddJGe(string strCompanyName)
        {
            InitializeComponent();
            this.strCompanyName = strCompanyName;
        }

        private void AddJGe_Load(object sender, EventArgs e)
        {
        }

        private void AddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Supported Image Types (*.jpg, *.gif, *.bmp)|*.jpg;*.gif;*.bmp|JPEG Image|*.jpg|GIF Image|*.gif|BITMAP Image|*.bmp";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //listView1.LargeImageList.Images.Add(Image.FromFile(dlg.FileName));
                this.strTmpImgPath = dlg.FileName;
                this.pictureBox1.Image = Image.FromFile(dlg.FileName);
            }
        }


        private void listView1_Click(object sender, EventArgs e)
        {
            int nIndex = this.listView1.SelectedItems[0].Index;
            pictureBox1.Image = Image.FromFile(this.strPathList[nIndex]);
            textBox3.Text = this.strInfoList[nIndex];
        }

        private void AddToList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("描述不能为空");
            }
            else if (this.strTmpImgPath == null)
            {
                MessageBox.Show("图片不能为空");
            }
            else
            {
                try
                {
                    this.imgList.Images.Add(Image.FromFile(this.strTmpImgPath));
                    listView1.LargeImageList = imgList;
                    listView1.Items.Add(textBox3.Text, nImgIndex++);
                    this.strPathList.Add(this.strTmpImgPath);
                    this.strInfoList.Add(textBox3.Text);
                }
                catch { }
            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete)
                &&(this.listView1.SelectedItems.Count > 0))
            {
                int nCount = this.listView1.SelectedItems.Count;
                for (int nIndex = 0; nIndex < nCount; nIndex++)
                {
                    this.listView1.Items.RemoveAt(nIndex);
                    this.strPathList.RemoveAt(nIndex);
                    this.strInfoList.RemoveAt(nIndex);
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            int nCount = this.strPathList.Count;
            int nCount1 = this.strInfoList.Count;
            if (nCount == nCount1)
            {
                for (int i = 0; i < nCount;i++ )
                {
                    Byte[] bit = GetPhotoBit(this.strPathList[i]);
                    SubmitSingleData(bit,this.strInfoList[i]);
                }
            }
            this.Close();
        }

        private void SubmitSingleData(Byte[] bit,string comment)
        {
            using (SqlConnection conn = new SqlConnection(SqlHelper.sqlconstr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into T_CheckInfo(CheckTime,CompanyName,PhotoBit,Comment) values(@CheckTime,@CompanyName,@PhotoBit,@Comment)";
                    cmd.Parameters.AddWithValue("@CheckTime", this.dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@CompanyName", this.strCompanyName);
                    SqlParameter par = new SqlParameter("@PhotoBit", SqlDbType.Image);
                    par.Value = bit;
                    cmd.Parameters.Add(par);
                    cmd.Parameters.AddWithValue("@Comment", comment);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("添加监管记录错误,该企业不存在");
                }
                finally
                {
                    conn.Close();
                }
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

    }
}
