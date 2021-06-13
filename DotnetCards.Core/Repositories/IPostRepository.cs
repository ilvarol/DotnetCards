using SimpleDotnet.Core.Models;
using System.Threading.Tasks;

namespace SimpleDotnet.Core.Repositories
{
	interface IPostRepository: IRepository<Post> 
	{
		Task<Post> GetWithPostDetailsByIdAsync(int postId);
	}
}
