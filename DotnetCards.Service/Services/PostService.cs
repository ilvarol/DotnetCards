using DotnetCards.Core.Models;
using DotnetCards.Core.Repositories;
using DotnetCards.Core.Services;
using DotnetCards.Core.UnitOfWorks;
using System.Threading.Tasks;

namespace dotnetcards.service.Services
{
    class PostService : Service<Post>, IPostService
    {
        public PostService(IUnitOfWork unitOfWork, IRepository<Post> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Post> GetWithNavigationPropertiesByIdAsync(int postId)
        {
            return await _unitOfWork.Posts.GetWithNavigationPropertiesByIdAsync(postId);
        }
    }
}