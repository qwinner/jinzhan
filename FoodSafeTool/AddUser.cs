using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JinZhan
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton[] rb = { radioButton8, radioButton7 };
            if ((!string.IsNullOrEmpty(textBox1.Text))
                && (!string.IsNullOrEmpty(textBox2.Text))
                    && (!string.IsNullOrEmpty(textBox3.Text)))
            {
                if (HasSameName() == false)
                {
                    if (textBox2.Text == textBox3.Text)
                    {
                        string strSql = "Insert Into T_User values( '" + textBox1.Text + "','" + textBox2.Text + "','" + Global.rbcheck(rb) + "')";
                        SqlHelper.excuteSql(strSql);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("两次密码不相同，请重新输入！");
                    }
                }
                else
                {
                    MessageBox.Show("用户名已存在！");
                }
            }
            else
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
        }

        private bool HasSameName()
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
    }
}
