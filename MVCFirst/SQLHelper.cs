using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MVCFirst
{
    public static class SqlHelper
    {
        public static readonly string connstr =
            ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        public static SqlConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            return conn;
        }

        public static int ExecuteNonQuery(string cmdText,
            params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                return ExecuteNonQuery(conn, cmdText, parameters);
            }
        }

        public static object ExecuteScalar(string cmdText,
            params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                return ExecuteScalar(conn, cmdText, parameters);
            }
        }

        public static DataTable ExecuteDataTable(string cmdText,
            params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                return ExecuteDataTable(conn, cmdText, parameters);
            }
        }

        public static int ExecuteNonQuery(SqlConnection conn, string cmdText,
           params SqlParameter[] parameters)
        {
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = cmdText;
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(SqlConnection conn, string cmdText,
            params SqlParameter[] parameters)
        {
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = cmdText;
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            }
        }

        public static DataTable ExecuteDataTable(SqlConnection conn, string cmdText,
            params SqlParameter[] parameters)
        {
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = cmdText;
                if(parameters!=null) cmd.Parameters.AddRange(parameters);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static object ToDBValue(this object value)
        {
            return value == null ? DBNull.Value : value;
        }

        public static object FromDBValue(this object dbValue)
        {
            return dbValue == DBNull.Value ? null : dbValue;
        }


    }


    public static class SQLHelp
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["contr"].ToString();

        public static SqlConnection OpenConnection()
        {
            SqlConnection sqlcon = new SqlConnection(ConnectionString);

            sqlcon.Open();

            return sqlcon;
        }


        /// <summary>
        /// 
        /// 执行SQL脚本并返回影响的行数
        /// 
        /// </summary>
        /// <param name="cmdtext"></param>
        /// <param name="parametes"></param>
        /// <returns></returns>

        public static int ExucetQueryNoneString(string cmdtext,params SqlParameter[] parametes)
        {

            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {

                sqlcon.Open();

                using (SqlCommand cmd = sqlcon.CreateCommand())
                {
                    cmd.CommandText = cmdtext;

                    cmd.Parameters.AddRange(parametes);

                    return cmd.ExecuteNonQuery();
                }             

            }         
 
        }


        /// <summary>
        /// 
        /// 执行查询
        /// 
        /// </summary>
        /// <param name="cmdtext"></param>
        /// <param name="sqlparameters"></param>
        /// <returns></returns>

        public static DataTable ExcuteDataTable(string cmdtext, params SqlParameter[] sqlparameters)
        {

            

            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {

                sqlcon.Open();

                using (SqlCommand sqcmd = sqlcon.CreateCommand())
                {
                    sqcmd.CommandText = cmdtext;

                    if (sqlparameters != null) sqcmd.Parameters.AddRange(sqlparameters);

                    using (SqlDataAdapter sqlad = new SqlDataAdapter(sqcmd))
                    {
                        DataTable dt = new DataTable();

                        sqlad.Fill(dt);

                        return dt;

                    }
                }
            }
            

           
        }


        /// <summary>
        /// 
        /// 执行SQL脚本返回第一行第一列
        /// 
        /// </summary>
        /// <param name="cmdtext"></param>
        /// <param name="sqlparamters"></param>
        /// <returns></returns>

        public static object ExcuteScalar(string cmdtext, params SqlParameter[] sqlparamters)
        {
            using (SqlConnection sqlconnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand scmd = sqlconnection.CreateCommand())
                {
                    scmd.CommandText = cmdtext;

                    scmd.Parameters.AddRange(sqlparamters);

                   return scmd.ExecuteScalar();

                }
            }
        }


    }

}
