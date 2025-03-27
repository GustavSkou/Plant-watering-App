using Npgsql;
using System.Threading.Tasks;

namespace Data;

public class DataHandler
{
    private static DataHandler instance = new DataHandler();
    public static DataHandler Instance { get { return instance; } }

    private NpgsqlConnection connection;
    private NpgsqlCommand command;

    private DataHandler()
    {
        connection = new NpgsqlConnection 
        (
            $"Server=localhost;" +
            $"Port=5432;" +
            $"User Id={UserCredentials.Name};" +
            $"Password={UserCredentials.Password};" +
            $"Database=postgres;"
        );
        connection.Open ();

        command = new NpgsqlCommand ();
        command.Connection = connection;
    }

    public static async Task<NpgsqlDataReader> GetReader ( string query )
    {
        instance.command.CommandText = query;
        return await instance.command.ExecuteReaderAsync ();
    }
}