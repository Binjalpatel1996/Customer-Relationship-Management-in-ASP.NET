using System;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class DBInteraction
    {
       /* public DataSet GetDataN(String s)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataSet ds = new DataSet();
            conn.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["Con"].ToString();
            cmd.Connection = conn;
            cmd.CommandText = s;
            cmd.CommandType = CommandType.Text;
            adpt.SelectCommand = cmd;
            adpt.Fill(ds);
            return ds;
        }*/
        public DataSet GetData(String s)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adpt = new SqlDataAdapter();
            DataSet ds = new DataSet();
#pragma warning disable CS0618 // Type or member is obsolete
            conn.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["Con"].ToString();
#pragma warning restore CS0618 // Type or member is obsolete
            cmd.Connection = conn;
            cmd.CommandText = s;
            cmd.CommandType = CommandType.StoredProcedure;
            adpt.SelectCommand = cmd;
            adpt.Fill(ds);
            return ds;
        }

       public DataSet GetDataPara(String s, SqlParameter[] ParaColl)
        {
            SqlConnection conn = new SqlConnection();
            SqlDataAdapter adpt = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
#pragma warning disable CS0618 // Type or member is obsolete
            conn.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["Con"].ToString();
#pragma warning restore CS0618 // Type or member is obsolete
            cmd.Connection = conn;
            cmd.CommandText = s;
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < ParaColl.Length; i++)
            {
                cmd.Parameters.Add(ParaColl[i]);
            }
            adpt.SelectCommand = cmd;
            adpt.Fill(ds);
            return ds;
        }

        public void ExecQryPara(String s, SqlParameter[] ParaColl)
        {
            SqlConnection conn = new SqlConnection();
            // SqlDataAdapter adpt = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            //DataSet ds = new DataSet();
#pragma warning disable CS0618 // Type or member is obsolete
            conn.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["Con"].ToString();
#pragma warning restore CS0618 // Type or member is obsolete
            cmd.Connection = conn;
            cmd.CommandText = s;
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < ParaColl.Length; i++)
            {
                cmd.Parameters.Add(ParaColl[i]);
            }
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void ExecQry(String s)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
#pragma warning disable CS0618 // Type or member is obsolete
            conn.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["Con"].ToString();
#pragma warning restore CS0618 // Type or member is obsolete
            cmd.Connection = conn;
            cmd.CommandText = s;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
