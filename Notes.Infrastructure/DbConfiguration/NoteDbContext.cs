using Notes.Application.Services;
using Npgsql;
namespace Notes.Infrastructure.DbConfiguration;
public class NoteDbContext : INoteDbContext
{
    const string connectionString = "Server=::1; Port=5433; Database=NoteDb; User Id=postgres; Password=postgres;";
    NpgsqlConnection connection = new(connectionString);
    public async Task<int> ExecuteCommandAsync(string command)
    {
        using(connection) 
            
        connection.Open();
        NpgsqlCommand npgsqlCommand = new(command, connection);
        int effectedRows =await npgsqlCommand.ExecuteNonQueryAsync();
        return effectedRows;
    }

    public async Task<NpgsqlDataReader> ExecuteQueryAsync(string query)
    {
        using (connection) 
        connection.Open();
        NpgsqlCommand npgsqlCommand = new(query, connection);
        NpgsqlDataReader reader =await npgsqlCommand.ExecuteReaderAsync();
        connection.Close();
        return reader;
    }
}
