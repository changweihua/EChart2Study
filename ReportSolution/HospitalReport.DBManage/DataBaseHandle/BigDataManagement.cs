using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HospitalReport.Common.Log;
using System.Configuration;

namespace Genernal.DBManage.DataBaseHandle
{
    public class BigDataManagement
    {
        private static string connectString = ConfigurationManager.ConnectionStrings["ApplicationServices"].ToString();
        public static void BulkCopy(string tableName, DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection, SqlBulkCopyOptions.Default, transaction))
                        {
                            bulkCopy.BatchSize = dt.Rows.Count;
                            bulkCopy.DestinationTableName = tableName;
                            try
                            {

                                string sql = "TRUNCATE TABLE " + tableName;
                                SqlCommand cmd = new SqlCommand(sql, connection, transaction);
                                cmd.ExecuteNonQuery();
                                foreach (DataColumn column in dt.Columns)
                                {
                                    bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);
                                }
                                bulkCopy.WriteToServer(dt);
                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                //LogHelper.WriteLog(typeof(BigDataManagement), ex);
                                Logger.Error(ex);
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }
                }
            }
        }
    }
}
