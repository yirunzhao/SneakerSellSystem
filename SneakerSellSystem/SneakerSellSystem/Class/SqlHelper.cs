using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerSellSystem
{
    /// <summary>
    /// 封装有关数据库的操作,使用带参数的sql语句
    /// </summary>
    public static class SqlHelper
    {
        //为连接字符串引用配置文件
        public static readonly string conStr = ConfigurationManager.ConnectionStrings["mssqlserver"].ConnectionString;

        /// <summary>
        /// 封装ExecuteNonQuery()
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if(pms != null)
                    {
                        //把参数传入
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }

            }
        }

        /// <summary>
        /// 封装ExecuteScalar()
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql,params SqlParameter[] pms)
        {
            using(SqlConnection con = new SqlConnection(conStr))
            {
                using(SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if(pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// 封装ExecuteReader
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql,params SqlParameter[] pms)
        {
            SqlConnection con = new SqlConnection(conStr);
            using(SqlCommand cmd = new SqlCommand(sql, con))
            {
                if(pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                try
                {
                    con.Open();
                    return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
                catch
                {
                    con.Close();
                    con.Dispose();
                    throw;
                }
            }
        }
    }
}
