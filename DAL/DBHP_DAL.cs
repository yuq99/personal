using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBHP_DAL
    {
        public static string str = System.Configuration.ConfigurationManager.AppSettings["cs"].ToString();//连接的数据库
        private static SqlConnection coon = null;
        public static DataTable dtb(string sql)//查询
        {
            coon = new SqlConnection(str);
            SqlDataAdapter dpt = new SqlDataAdapter(sql, coon);
            DataTable dt = new DataTable();
            dpt.Fill(dt);
            return dt;
        }

        public static bool eqy(string sql)//三个(增删改)
        {
            coon = new SqlConnection(str);
            coon.Open();
            SqlCommand md = new SqlCommand(sql, coon);
            int row = md.ExecuteNonQuery();
            if (row > 0)
                return true;
            else
                return false;
        }

        public static bool IsConnected()//与数据库连接成功与否
        {
            SqlConnection connection = new SqlConnection(str);
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
