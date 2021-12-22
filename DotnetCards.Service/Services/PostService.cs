using DotnetCards.Core.Models;
using DotnetCards.Core.Repositories;
using DotnetCards.Core.Services;
using DotnetCards.Core.UnitOfWorks;
using System.Threading.Tasks;

namespace DotnetCards.Service.Services
{
    public class PostService : Service<Post>, IPostService
    {
        public PostService(IUnitOfWork unitOfWork, IRepository<Post> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Post> GetWithDetailsByIdAsync(int postId)
        {
            return await _unitOfWork.Posts.GetWithDetailsByIdAsync(postId);
        }
    }
}