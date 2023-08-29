using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Services;
public interface INoteDbContext
{
    Task<int> ExecuteCommandAsync(string command);
    Task<NpgsqlDataReader> ExecuteQueryAsync(string getAllQuery);
}
