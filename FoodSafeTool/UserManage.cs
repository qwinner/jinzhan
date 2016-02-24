using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JinZhan
{
    public partial class UserManage : Form
    {
        public UserManage()
        {
            InitializeComponent();
        }

        private void UserManage_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private DataTable ParsingData(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                dr.BeginEdit();
                dr[2] = ParsingAuthority(dr[2].ToString());
                dr.EndEdit();

            }
            if (Global.authority == Authority.Manager)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][2].ToString() == "管理者")
                    {
                        dt.Rows.RemoveAt(i);
                        i = i - 1;
                    }
                }
            }
            return dt;
        }

        private string ParsingAuthority(string data)
        {
            string Ret = string.Empty;
            if (data == "1")
            {
                Ret = "普通用户";
            }
            else if (data == "2")
            {
                Ret = "管理者";
            }
            else
            { }
            return Ret;
        }

        private void BindData()
        {
            string strSql = "Select * From T_User";
            DataTable dt = SqlHelper.dataTable(strSql);
            dt = ParsingData(dt);
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Columns[0].HeaderText = "用户名";
            this.dataGridView1.Columns[0].Width = 100;
            this.dataGridView1.Columns[1].HeaderText = "密码";
            this.dataGridView1.Columns[1].Width = 100;
            this.dataGridView1.Columns[2].HeaderText = "权限";
            this.dataGridView1.Columns[2].Width = 90;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除此用户？", "JinZhan", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string strName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string strSql = "Delete from T_User where [User] = '" + strName + "'";
                SqlHelper.excuteSql(strSql);
                BindData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser dlg = new AddUser();
            dlg.ShowDialog();
            BindData();
        }

    }
}
