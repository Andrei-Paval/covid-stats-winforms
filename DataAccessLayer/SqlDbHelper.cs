using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class SqlDbHelper
    {
        private const int EXECUTION_ERROR = 0;

        private static string connectionString = "Data Source=80.96.123.131/ora09;User Id=hr;" +
                                                 "Password=oracletest;";

        /// <summary>
        /// executes SELECT query 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="parameters"></param>
        /// <returns>returns the values received as generic object of type 'DataSet'</returns>
        public static DataSet ExecuteDataSet(string sql, CommandType cmdType,
                                             params OracleParameter[] parameters)
        {
            using (DataSet ds = new DataSet())
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.CommandType = cmdType;
                    foreach (var item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }

                    try
                    {
                        new OracleDataAdapter(cmd).Fill(ds);
                    }
                    catch (OracleException ex)
                    {
                        //
                    }

                    return ds;
                }
            }
        }

        /// <summary>
        /// executes INSERT/UPDATE/DELETE queries
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="parameters"></param>
        /// <returns> returns 'true' if the query was successful</returns>
        public static bool ExecuteNonQuery(string sql, CommandType cmdType,
                                           params OracleParameter[] parameters)
        {
            int rezult = EXECUTION_ERROR;
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.CommandType = cmdType;
                    foreach (var item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }

                    try
                    {
                        cmd.Connection.Open();
                        rezult = cmd.ExecuteNonQuery();
                    }
                    catch (OracleException ex)
                    {
                        //
                    }
                }
            }

            return Convert.ToBoolean(rezult);
        }
    }
}