using DotnetCards.Core.Models;
using DotnetCards.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DotnetCards.Data.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        private AppDbContext AppDbContext { get => _context as AppDbContext; }

        public PostRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Post> GetWithDetailsByIdAsync(int postId)
        {
            return await 
                AppDbContext.Posts
                .Include(x => x.PostDetails)
                .SingleOrDefaultAsync(x => x.Id == postId);
        }
    }
}