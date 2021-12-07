using DotnetCards.Core.Models;
using DotnetCards.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DotnetCards.Data.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        private AppDbContext AppDbContext { get => _context as AppDbContext; }

        public PostRepository(DbContext context) : base(context)
        {
        }

        public async Task<Post> GetWithPostDetailsByIdAsync(int postId)
        {
            return await AppDbContext.Posts.Include(x => x.Parent).SingleOrDefaultAsync(x => x.Id == postId);
        }
    }
}
