using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication1
{
    class DBHelper
    {
        public static SqlConnection GetConn()
        {
            String path = Application.StartupPath;
            String str = @"Data Source=.\sqlexpress;AttachDbFilename=" + path + @"\myplayer.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            return conn;
        }

        public static int AddDeleteUpdateData(SqlConnection conn,String sql,SqlParameter[] p)
        {
            conn.Open();
            SqlCommand cmd=new SqlCommand(sql,conn);
            cmd.Parameters.AddRange(p);
            int num = cmd.ExecuteNonQuery();
            conn.Close();
            return num;
        }

        public static SqlDataReader ReadData(SqlConnection conn, String sql, SqlParameter[] p)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(p);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }


        
        public static DataTable GetTable(String sql)
        {
            SqlConnection conn=GetConn();
            SqlCommand cmd=new SqlCommand(sql,conn);
            SqlDataAdapter sda=new SqlDataAdapter(cmd);
            DataSet ds=new DataSet();
            sda.Fill(ds,"st");
            DataTable dt=ds.Tables["st"];
            return dt;
        }


    }
}
