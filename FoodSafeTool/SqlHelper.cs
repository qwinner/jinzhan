using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JinZhan
{
    public static class SqlHelper
    {
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);//读取INI配置文件
        [DllImport("kernel32")]
        public static extern int WritePrivateProfileString(string section, string key, string val, string filePath);//写INI配置文件

        public static string AppPath;
        public static string sqlconstr;
       // public static bool conet;
        public static bool connectsql()
        {
            bool conet = false;
            AppPath = System.Windows.Forms.Application.StartupPath;
            StringBuilder temp = new StringBuilder(255);
            string path = AppPath + @"\Myconfig.ini";
            try
            {
                GetPrivateProfileString("MyConnectionStr", "sqlstr", "error", temp, 255, path);//读取数据库连接字符串
                sqlconstr = temp.ToString();

                SqlConnection sqlcon = new SqlConnection(sqlconstr);
                sqlcon.Open();
                sqlcon.Close();
                conet = true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("连接数据库失败，请查看网络连接是否正常！", "JinZhan", MessageBoxButtons.OK);
                conet = false;
            }
            return conet;
        }

        public static SqlDataReader reader(string sqlstr)
        {
            SqlDataReader dr = null;
            SqlConnection sqlcon = new SqlConnection(sqlconstr);
            try
            {
                SqlCommand sqlcommand = sqlcon.CreateCommand();
                sqlcon.Open();
                sqlcommand.CommandText = sqlstr;
                dr = sqlcommand.ExecuteReader();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return dr;
        }

        public static void excuteSql(string sqlstr)
        {
            SqlConnection sqlcon = new SqlConnection(sqlconstr);
            SqlCommand sqlcommand = sqlcon.CreateCommand();
            try
            {
                sqlcon.Open();
                sqlcommand.CommandText = sqlstr;
                sqlcommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sqlcommand.Dispose();
                sqlcon.Close();
            }
        }

        private static void AttachParameters(SqlCommand command, SqlParameter[] commandParameters)
        {
            if (command == null) throw new ArgumentNullException("command");
            if (commandParameters != null)
            {
                foreach (SqlParameter p in commandParameters)
                {
                    if (p != null)
                    {
                        // 检查未分配值的输出参数,将其分配以DBNull.Value. 
                        if ((p.Direction == ParameterDirection.InputOutput || p.Direction == ParameterDirection.Input) &&
                            (p.Value == null))
                        {
                            p.Value = DBNull.Value;
                        }
                        command.Parameters.Add(p);
                    }
                }
            }
        }

        public static DataTable dataTable(string sqlstr)
        {
            DataTable dt = new DataTable();
            SqlConnection sql = new SqlConnection(sqlconstr);
            try
            {
                sql.Open();
                SqlDataAdapter da = new SqlDataAdapter(sqlstr, sql);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sql.Close();
            }
            return dt;
        }
    }
}
