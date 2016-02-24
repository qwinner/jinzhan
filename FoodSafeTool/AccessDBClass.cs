using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.OleDb;


/// <summary>
/// AccessHelper ��ժҪ˵��
/// </summary>
public class AccessHelper
{
    protected static OleDbConnection conn = new OleDbConnection();
    protected static OleDbCommand comm = new OleDbCommand();

    public AccessHelper()
    {
        //
        // TODO: �ڴ˴���ӹ��캯���߼�
        //
    }

    /// <summary>
    /// �����ݿ�
    /// </summary>
    private static void openConnection()
    {
        if (conn.State == ConnectionState.Closed)
        {
            string strPath = System.Windows.Forms.Application.StartupPath;
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+strPath+"\\Chartlet.mdb";
            comm.Connection = conn;
            try
            {
                conn.Open();
            }
            catch (Exception e)
            { throw new Exception(e.Message); }

        }

    }
    /// <summary>
    /// �ر����ݿ�
    /// </summary>
    private static void closeConnection()
    {
        if (conn.State == ConnectionState.Open)
        {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
        }
    }
    /// <summary>
    /// ִ��sql���
    /// </summary>
    /// <param name="sqlstr"></param>
    public static void excuteSql(string sqlstr)
    {
        try
        {
            openConnection();
            comm.CommandType = CommandType.Text;
            comm.CommandText = sqlstr;
            comm.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
        finally
        { closeConnection(); }
    }
    /// <summary>
    /// ����ָ��sql����OleDbDataReader����ʹ��ʱ��ע��ر��������
    /// </summary>
    /// <param name="sqlstr"></param>
    /// <returns></returns>
    public static OleDbDataReader dataReader(string sqlstr)
    {
        OleDbDataReader dr = null;
        try
        {
            openConnection();
            comm.CommandText = sqlstr;
            comm.CommandType = CommandType.Text;

            dr = comm.ExecuteReader(CommandBehavior.CloseConnection);
        }
        catch
        {
            try
            {
                dr.Close();
                closeConnection();
            }
            catch { }
        }
        return dr;
    }
    /// <summary>
    /// ����ָ��sql����OleDbDataReader����,ʹ��ʱ��ע��ر�
    /// </summary>
    /// <param name="sqlstr"></param>
    /// <param name="dr"></param>
    public static void dataReader(string sqlstr, ref OleDbDataReader dr)
    {
        try
        {
            openConnection();
            comm.CommandText = sqlstr;
            comm.CommandType = CommandType.Text;
            dr = comm.ExecuteReader(CommandBehavior.CloseConnection);
        }
        catch
        {
            try
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
            }
            catch
            {
            }
            finally
            {
                closeConnection();
            }
        }
    }
    /// <summary>
    /// ����ָ��sql����dataset
    /// </summary>
    /// <param name="sqlstr"></param>
    /// <returns></returns>
    public static DataSet dataSet(string sqlstr)
    {
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        try
        {
            openConnection();
            comm.CommandType = CommandType.Text;
            comm.CommandText = sqlstr;
            da.SelectCommand = comm;
            da.Fill(ds);

        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
        finally
        {
            closeConnection();
        }
        return ds;
    }
    /// <summary>
    /// ����ָ��sql����dataset
    /// </summary>
    /// <param name="sqlstr"></param>
    /// <param name="ds"></param>
    public static void dataSet(string sqlstr, ref DataSet ds)
    {
        OleDbDataAdapter da = new OleDbDataAdapter();
        try
        {
            openConnection();
            comm.CommandType = CommandType.Text;
            comm.CommandText = sqlstr;
            da.SelectCommand = comm;
            da.Fill(ds);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
        finally
        {
            closeConnection();
        }
    }
    /// <summary>
    /// ����ָ��sql����datatable
    /// </summary>
    /// <param name="sqlstr"></param>
    /// <returns></returns>
    public static DataTable dataTable(string sqlstr)
    {
        DataTable dt = new DataTable();
        OleDbDataAdapter da = new OleDbDataAdapter();
        try
        {
            openConnection();
            comm.CommandType = CommandType.Text;
            comm.CommandText = sqlstr;
            da.SelectCommand = comm;
            da.Fill(dt);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
        finally
        {
            closeConnection();
        }
        return dt;
    }
    /// <summary>
    /// ����ָ��sql����datatable
    /// </summary>
    /// <param name="sqlstr"></param>
    /// <param name="dt"></param>
    public static void dataTable(string sqlstr, ref DataTable dt)
    {
        OleDbDataAdapter da = new OleDbDataAdapter();
        try
        {
            openConnection();
            comm.CommandType = CommandType.Text;
            comm.CommandText = sqlstr;
            da.SelectCommand = comm;
            da.Fill(dt);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
        finally
        {
            closeConnection();
        }
    }
    /// <summary>
    /// ����ָ��sql����dataview
    /// </summary>
    /// <param name="sqlstr"></param>
    /// <returns></returns>
    public static DataView dataView(string sqlstr)
    {
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataView dv = new DataView();
        DataSet ds = new DataSet();
        try
        {
            openConnection();
            comm.CommandType = CommandType.Text;
            comm.CommandText = sqlstr;
            da.SelectCommand = comm;
            da.Fill(ds);
            dv = ds.Tables[0].DefaultView;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
        finally
        {
            closeConnection();
        }
        return dv;
    }
}