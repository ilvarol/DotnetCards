using SimpleDotnet.Core.Models;
using System.Threading.Tasks;

namespace SimpleDotnet.Core.Repositories
{
	interface IPostDeailService : IService<PostDetail>
	{
		Task<Post> GetWithPostByIdAsync(int postDetailId);
	}
}
