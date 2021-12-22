using DotnetCards.Core.Models;
using System.Threading.Tasks;


namespace DotnetCards.Core.Services
{
    public interface IPostService : IService<Post>
    {
        Task<Post> GetWithDetailsByIdAsync(int postId);
    }
}