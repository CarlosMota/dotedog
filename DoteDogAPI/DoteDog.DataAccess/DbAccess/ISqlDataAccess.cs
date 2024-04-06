using System.Data;

namespace DoteDog.DataAccess.DataAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure
        , U parameters,
        CommandType commandType = CommandType.Text, // Assume Text por padrão
        int? commandTimeout = null
        );

        Task SaveData<T>(string storedProcedure, T parameters);
    }
}