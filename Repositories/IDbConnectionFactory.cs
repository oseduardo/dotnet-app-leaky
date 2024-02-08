using System.Data;
using System.Threading.Tasks;

namespace app_leaky.Repositories
{
    public interface IDbConnectionFactory
    {
        Task<IDbConnection> CreateConnectionAsync();
    }
}