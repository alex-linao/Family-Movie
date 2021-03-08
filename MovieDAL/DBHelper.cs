using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace MovieDAL
{
    public class DBHelper
    {
        public static string constr = "Data Source=.;Initial Catalog=MovieDBnet;Integrated Security=True";
        public static SqlConnection conn = null;
        public static void init()
        {
            if (conn==null)
            {
                conn = new SqlConnection(constr);
            }
            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            if (conn.State == ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
        }
        public static DataTable GetDataTable(string sql)
        {
            init();
            SqlDataAdapter sda = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public static bool en(string sql)
        {
            init();
            SqlCommand sc = new SqlCommand(sql,conn);
            int count = sc.ExecuteNonQuery();
            conn.Close();
            return count > 0;
        }
    }
}
