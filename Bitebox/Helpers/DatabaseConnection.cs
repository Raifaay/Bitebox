//KURANG EKSEKUSI, SKALAR, ACTION, SELECT
using Npgsql;

namespace Bitebox.Helpers
{
    internal class DatabaseConnection
    {
        private static readonly string _connectionString =
            "Host=localhost;" +
            "Port=5432;" +
            "Database=bitebox;" +
            "Username=postgres;" +
            "Password=0402";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}