using MySql.Data.MySqlClient;

public class Database
{
    private static string connectionString = "Server=localhost;Database=ComputerAccessories;Uid=root;Pwd=123456;";
    public static MySqlConnection GetConnection()
    {
        var conn = new MySqlConnection(connectionString);
        conn.Open();
        return conn;
    }
}
