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
            const string sql =
                " SELECT " +
                "  id, " +
                "  code, " +
                "  value_string, " +
                "  value_date " +
                " FROM " +
                "  testuser1.table1 ";

            return conn.Query<TABLE1>(sql);
        }

        public static void Insert(OracleConnection conn, OracleTransaction tran, TABLE1 insertTABLE1)
        {
            const string sql =
                " INSERT INTO testuser1.table1( " +
                "   id,  " +
                "   value_string,  " +
                "   value_date, " +
                "   code " +
                " ) VALUES ( " +
                "   :id,  " +
                "   :value_string,  " +
                "   :value_date, " +
                "   :code " +
                " ) ";

            var sqlParam = new
            {
                id = insertTABLE1.ID,
                code = insertTABLE1.CODE,
                value_string = insertTABLE1.VALUE_STRING,
                value_date = insertTABLE1.VALUE_DATE
            };

            conn.Execute(sql, sqlParam, tran);
        }
    }

}
