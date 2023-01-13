using System.Data;
using WebApplication1.Model;
using WebApplication1.Shared;
using Dapper;
using Microsoft.Extensions.Logging;
using Npgsql;

namespace WebApplication1.SQL
{
    public class SQL_m_table_a
    {
        public static void Transaction1(m_table_a insert_m_table_a)
        {
            using (var conn = new NpgsqlConnection(SharedData.ConnectionString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        var List_m_table_a1 = Select(conn);

                        Insert(conn, insert_m_table_a);

                        var List_m_table_a2 = Select(conn);

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

        public static IEnumerable<m_table_a> Select(NpgsqlConnection conn)
        {
            const string sql =
                " SELECT " +
                "  id, " +
                "  code, " +
                "  value_string, " +
                "  value_date " +
                " FROM " +
                "  test_schema.m_table_a ";

            return conn.Query<m_table_a>(sql);
        }

        public static void Insert(NpgsqlConnection conn, m_table_a _m_table_a)
        {
            const string sql =
                " INSERT INTO test_schema.m_table_a( " +
                "   id,  " +
                "   value_string,  " +
                "   value_date, " +
                "   code " +
                " ) VALUES ( " +
                "   @id,  " +
                "   @value_string,  " +
                "   @value_date, " +
                "   @code " +
                " ); ";

            var sqlParam = new
            {
                id = _m_table_a.id,
                code = _m_table_a.code,
                value_string = _m_table_a.value_string,
                value_date = _m_table_a.value_date
            };

            conn.Execute(sql, sqlParam);
        }
    }

}
