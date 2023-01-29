using System.Data;
using WebApplication1.Model;
using WebApplication1.Shared;
using Dapper;
using Microsoft.Extensions.Logging;
using Oracle.ManagedDataAccess.Client;

namespace WebApplication1.SQL
{
    public class SQL_TABLE1
    {
        public static void Transaction1(TABLE1 insertTABLE1)
        {
            using (var conn = new OracleConnection(SharedData.ConnectionString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        var table1List = Select(conn);

                        Insert(conn, tran, insertTABLE1);

                        var table1List2 = Select(conn);

                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        public static IEnumerable<TABLE1> Select(OracleConnection conn)
        {
            return conn.Query<TABLE1>("SP_TABLE1_SELECT", null, commandType: CommandType.StoredProcedure);
        }

        public static void Insert(OracleConnection conn, OracleTransaction tran, TABLE1 insertTABLE1)
        {
            var sqlParam = new
            {
                id = insertTABLE1.ID,
                code = insertTABLE1.CODE,
                value_string = insertTABLE1.VALUE_STRING,
                value_date = insertTABLE1.VALUE_DATE
            };

            conn.Execute("SP_TABLE1_INSERT", sqlParam, tran, commandType: CommandType.StoredProcedure);
        }
    }

}
