using System.Data;
using System.Data.SqlClient;

namespace dao
{
    public class DAO
    {
        public  static DataSet Qurry(string sql)
        {
            string ConStr = @"server=192.168.1.178,1433;database=APP;uid=log1;pwd=123";
            SqlConnection conn = new SqlConnection(ConStr);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();      //打开数据库  
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                adp.Fill(ds);
            }
            catch
            {
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();      //关闭数据库  
            }
            return ds;
        }

        public static int ExeSql(string sql)
        {
            string ConStr = @"server=192.168.1.178,1433;database=APP;uid=log1;pwd=123";
            SqlConnection conn = new SqlConnection(ConStr);
            int iRet=0;
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                iRet = comm.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            /*string ConStr = @"server=DESKTOP-850VHC4\SQLEXPRESS;database=APP;uid=log1;pwd=123";
            SqlConnection conn = new SqlConnection(ConStr);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            int  iRet = comm.ExecuteNonQuery();
            conn.Close();*/
            return iRet;
        }
    }
}
