using System.Data;
using WebApplication1.Model;
using WebApplication1.Shared;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Data.SqlClient;

namespace WebApplication1.SQL
{
    public class SQL_TableA
    {
        public static void Transaction1(TableA insertTableA)
        {
            using (var conn = new SqlConnection(SharedData.ConnectionString))
            {
                conn.Open();

                using (var tran = conn.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        var tableAList = Select(conn, tran);

                        Insert(conn, tran, insertTableA);

                        var tableAList2 = Select(conn, tran);

                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        public static IEnumerable<TableA> Select(SqlConnection conn, SqlTransaction tran)
        {
            return conn.Query<TableA>("spTableA_Select", null, tran, commandType: CommandType.StoredProcedure);
        }

        public static void Insert(SqlConnection conn, SqlTransaction tran, TableA insertTableA)
        {
            var sqlParam = new
            {
                id = insertTableA.Id,
                code = insertTableA.Code,
                valueString = insertTableA.ValueString,
                valueDate = insertTableA.ValueDate
            };

            conn.Execute("spTableA_Insert", sqlParam, tran, commandType: CommandType.StoredProcedure);
        }
    }

}
