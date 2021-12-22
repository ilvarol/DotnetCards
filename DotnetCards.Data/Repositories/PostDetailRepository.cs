using DotnetCards.Core.Models;
using DotnetCards.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCards.Data.Repositories
{
    public class PostDetailRepository : Repository<PostDetail>, IPostDetailRepository
    {
        private AppDbContext AppDbContext { get => _context as AppDbContext; }

        public PostDetailRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<PostDetail> GetWithPostByIdAsync(int postDetailId)
        {
            return await AppDbContext.PostDetails
                .Include(x => x.Post)
                .SingleOrDefaultAsync(x => x.Id == postDetailId);
        }
    }
}
