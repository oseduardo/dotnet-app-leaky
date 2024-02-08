using System.Threading.Tasks;
using app_leaky.Models;

namespace app_leaky.Repositories
{
    public interface IAuthorsRepository
    {
        Task<PostResponse> AddAuthor(string name);
    }
}