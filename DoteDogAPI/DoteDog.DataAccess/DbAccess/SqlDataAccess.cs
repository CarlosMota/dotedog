using System.Data;
using Dapper;

namespace DoteDog.DataAccess.DataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IDbConnection _conn;

        public SqlDataAccess(IDbConnection conn)
        {
            _conn = conn;
        }

        public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure
        , U parameters,
        CommandType commandType = CommandType.Text, // Assume Text por padrão
        int? commandTimeout = null
        ) =>
            await _conn.QueryAsync<T>(storedProcedure, parameters, commandType: commandType, commandTimeout: commandTimeout);

        public async Task SaveData<T>(string storedProcedure, T parameters) =>
            await _conn.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }
}