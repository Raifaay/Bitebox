using Npgsql;

public class Database
{
    private string _connString;

    public Database(string connString)
    {
        _connString = connString;
    }

    public NpgsqlConnection GetConnection()
    {
        return new NpgsqlConnection(_connString);
    }
}
public static class Config
{
    public static string ConnString =
        "Host=localhost;" +
        "Port=5432;" +
        "Database=praktikum-pbo;" +
        "Username=postgres;" +
        "Password=Password";
}
class Program
{
    static void Main(string[] args)
    {
        try
        {
            using (var conn = new Database().GetConnection())
            {
                conn.Open();
                Console.WriteLine("Koneksi berhasil!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }