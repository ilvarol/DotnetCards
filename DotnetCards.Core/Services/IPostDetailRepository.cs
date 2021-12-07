using DotnetCards.Core.Models;
using System.Threading.Tasks;

namespace DotnetCards.Core.Repositories
{
	interface IPostDeailService : IService<PostDetail>
	{
		Task<Post> GetWithPostByIdAsync(int postDetailId);
	}
}
