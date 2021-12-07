using DotnetCards.Core.Repositories;
using DotnetCards.Core.UnitOfWorks;
using DotnetCards.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCards.Data.UnitofWorks
{
    public class UnitOfWorks : IUnitOfWork
    {
        private readonly AppDbContext _context;

        private PostRepository _postRepository;
        private PostDetailRepository _postDetailRepository;

        public IPostRepository Posts => _postRepository = _postRepository ?? new PostRepository(_context);

        public IPostDetailRepository PostDetails => _postDetailRepository = _postDetailRepository ?? new PostDetailRepository(_context);

        public UnitOfWorks(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
