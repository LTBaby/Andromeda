using Dapper;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Betelguese.Interfaces;

namespace Betelguese.Database
{
    public class DatabaseAccess : IDatabaseAccess
    {
        private readonly IConfiguration _config;

        public DatabaseAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

            return await connection.QueryAsync<T>(storedProcedure, parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task SaveData<T>(string storedProcedure, T parameters, string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

            await connection.ExecuteAsync(storedProcedure, parameters,
                commandType: CommandType.StoredProcedure);
        }

        public  List<T> LoadAll<T>(string connectionId = "Default")
        {
            Type typeParameterType = typeof(T);
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
            string sql = "SELECT * FROM " + "[" + typeParameterType.Name + "]";
            var ttt = connection.Query<T>(sql).ToList();
            return ttt;

           
        }
    }
}
