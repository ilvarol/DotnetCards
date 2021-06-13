using SimpleDotnet.Core.Models;
using System.Threading.Tasks;

namespace SimpleDotnet.Core.Repositories
{
	interface IPostService: IService<Post> 
	{
		Task<Post> GetWithPostDetailsByIdAsync(int postId);
	}
}
