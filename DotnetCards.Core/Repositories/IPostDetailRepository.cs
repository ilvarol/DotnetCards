using SimpleDotnet.Core.Models;
using System.Threading.Tasks;

namespace SimpleDotnet.Core.Repositories
{
	interface IPostDeailRepository : IRepository<PostDetail>
	{
		Task<Post> GetWithPostByIdAsync(int postDetailId);
	}
}
