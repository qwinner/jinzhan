using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace JinZhan
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while(this.Opacity>1)
            {
                this.Opacity-=0.25;
            }
            timer1.Stop();
            this.Hide();
            Mainfrm dlg = new Mainfrm();
            dlg.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Start_Load(object sender, EventArgs e)
        {
            Drag.bindControl(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!SqlHelper.connectsql())
            {
                return;
            }
            else
            {
                if (!string.IsNullOrEmpty(textBox1.Text.Trim()) && !string.IsNullOrEmpty(textBox2.Text.Trim()))
                {
                    if ("jinzhanxiang" != textBox1.Text)
                    {
                        if (HasUserName())
                        {
                            if (HasUser() == true)
                            {
                                this.button1.Visible = false;
                                this.button2.Visible = false;
                                this.textBox1.Visible = false;
                                this.textBox2.Visible = false;
                                this.label1.Visible = false;
                                this.label2.Visible = false;
                                this.pictureBox1.Visible = true;
                                timer1.Interval = 2000;
                                timer1.Start();
                            }
                            else
                            {
                                MessageBox.Show("密码错误！");
                            }
                        }
                        else
                        {
                            MessageBox.Show("用户名不存在！");
                        }
                    }
                    else
                    {
                        AdminOnly();
                    }
                }
                else
                {
                    MessageBox.Show("请将必要信息填写完整！");
                }
            }
        }

        private bool HasUserName()
        {
            bool bRet = false;
            string strSql = "Select * From T_User where [User] = '" + this.textBox1.Text + "'";
            DataTable dt = SqlHelper.dataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                bRet = true;
            }

            return bRet;
        }

        private bool HasUser()
        {
            bool bRet = false;
            string strSql = "Select * From T_User where [User] = '" + this.textBox1.Text + "' and PassWord = '"+ this.textBox2.Text +"'";
            DataTable dt = SqlHelper.dataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                bRet = true;
                Global.authority = (Authority)Convert.ToInt16( dt.Rows[0][2].ToString());
            }

            return bRet;
        }

        private void AdminOnly()
        {
            if (("jinzhanxiang" == textBox1.Text) && ("BTBUandJZX" == textBox2.Text))
            {
                this.button1.Visible = false;
                this.button2.Visible = false;
                this.textBox1.Visible = false;
                this.textBox2.Visible = false;
                this.label1.Visible = false;
                this.label2.Visible = false;
                this.pictureBox1.Visible = true;
                timer1.Interval = 2000;
                timer1.Start();
                Global.authority = Authority.Admin;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity = 40;
            this.timer2.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.StartPosition = FormStartPosition.CenterScreen;
            Global.SetFormRoundRectRgn(this, 10);
            this.TopMost = true;
        }
    }
}