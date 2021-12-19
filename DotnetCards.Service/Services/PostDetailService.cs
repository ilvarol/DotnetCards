using DotnetCards.Core.Models;
using DotnetCards.Core.Repositories;
using DotnetCards.Core.Services;
using DotnetCards.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DotnetCards.Service.Services
{
    public class PostDetailService : Service<PostDetail>, IPostDetailService
    {
        public PostDetailService(IUnitOfWork unitOfWork, IRepository<PostDetail> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<PostDetail> GetWithPostByIdAsync(int postDetailId)
        {
            return await _unitOfWork.PostDetails.GetWithPostByIdAsync(postDetailId);
        }
    }
}