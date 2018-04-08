using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三周作业_201511190114_任春哲
{
    class BaseDb
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["NSdpWebConnectionString"].ToString();
        /// <summary>
        /// 查询 -- 执行存储过程返回数据集
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="tableName">DataSet结果中的表名</param>
        /// <returns>DataSet</returns>
        public static DataSet RunProcedureForQuery(string storedProcName, IDataParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                DataSet dataSet = new DataSet();
                try
                {
                    connection.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter();
                    sqlDA.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);
                    sqlDA.Fill(dataSet);
                    connection.Close();
                    return dataSet;
                }
                catch (Exception ex)
                {
                    //返回为空时代表数据库访问出现异常,界面调用方根据返回信息给用友户好提示。
                    Debug.Print(ex.ToString());
                    return null;
                }
            }
        }

        public static DataSet RunSQLForQuery(string sql)
        {
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                DataSet dataSet = new DataSet();
                try
                {
                    connection.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter();
                    sqlDA.SelectCommand = new SqlCommand(sql, connection);
                    sqlDA.Fill(dataSet);
                    connection.Close();
                    return dataSet;
                }
                catch (Exception ex)
                {
                    //返回为空时代表数据库访问出现异常,界面调用方根据返回信息给用户友好提示。
                    Debug.Print(ex.ToString());
                    return null;
                }
            }
        }

        //只需要进行操作不需要返回
        public static void RunSQLForNoQuery(string sql)
        {
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                try
                {
                    connection.Open();
                    SqlCommand sc = new SqlCommand(sql, connection);
                    sc.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    //返回为空时代表数据库访问出现异常,界面调用方根据返回信息给用户友好提示。
                    Debug.Print(ex.ToString());
                }
            }
        }

        /// <summary>
        /// 更新--执行存储过程，返回影响的行数        
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns></returns>
        public static int RunProcedureForUpdate(string storedProcName, IDataParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                int rowsAffected = 0;
                try
                {
                    connection.Open();
                    SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Debug.Print(ex.ToString());
                }
                return rowsAffected;
            }
        }

        /// <summary>
        /// 构建 SqlCommand 对象(用来返回一个结果集，而不是一个整数值)
        /// </summary>
        /// <param name="connection">数据库连接</param>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand</returns>
        private static SqlCommand BuildQueryCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(storedProcName, connection);
            command.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }
            }
            return command;
        }

        internal DataSet UserLogin(string strManagerName, string strManagerPWD)
        {
            throw new NotImplementedException();
        }
    }
}
