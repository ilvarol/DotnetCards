using SimpleDotnet.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDotnet.Core.UnitOfWorks
{
    interface IUnitOfWork
    {
        IPostRepository Posts { get; }
        IPostDeailRepository PostDetails { get; }

        Task CommitAsync();
        void Commit();
    }
}
