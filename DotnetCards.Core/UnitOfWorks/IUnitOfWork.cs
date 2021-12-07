using DotnetCards.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCards.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IPostRepository Posts { get; }
        IPostDetailRepository PostDetails { get; }

        Task CommitAsync();
        void Commit();
    }
}
