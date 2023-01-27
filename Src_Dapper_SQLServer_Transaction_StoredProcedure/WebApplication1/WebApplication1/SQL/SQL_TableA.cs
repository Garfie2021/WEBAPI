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
            const string sql =
                " SELECT " +
                "  Id, " +
                "  Code, " +
                "  ValueString, " +
                "  ValueDate " +
                " FROM " +
                "  dbo.TableA ";

            return conn.Query<TableA>(sql, null, tran);
        }

        public static void Insert(SqlConnection conn, SqlTransaction tran, TableA _TableA)
        {
            const string sql =
                " INSERT INTO dbo.TableA( " +
                "   Id,  " +
                "   Code, " +
                "   ValueString,  " +
                "   ValueDate " +
                " ) VALUES ( " +
                "   @id,  " +
                "   @code, " +
                "   @valueString,  " +
                "   @valueDate " +
                " ); ";

            var sqlParam = new
            {
                id = _TableA.Id,
                code = _TableA.Code,
                valueString = _TableA.ValueString,
                valueDate = _TableA.ValueDate
            };

            conn.Execute(sql, sqlParam, tran);
        }
    }

}
