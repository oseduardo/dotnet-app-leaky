using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace app_leaky.Repositories
{
    public class SqlDbConnectionFactory : IDbConnectionFactory
    {
        public async Task<IDbConnection> CreateConnectionAsync()
        {
            // TODO:: Put in appsettings.json
            var connectionString = "YOUR_CONNECTION_STRING";
            
            var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();
            return connection;
        }
    }
}