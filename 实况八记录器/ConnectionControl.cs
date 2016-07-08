using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace 实况八记录器
{
    public class ConnectionControl
    {
        public static SqlConnection getConnection()
        {
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            return conn;
        }
        public static SqlDataReader getDataReader(string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public static SqlCommand getSqlCommand(string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd;
        }
    }
}
