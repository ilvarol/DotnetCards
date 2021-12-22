using DotnetCards.Core.Models;
using System.Threading.Tasks;

namespace DotnetCards.Core.Repositories
{
	public interface IPostRepository : IRepository<Post>
	{
		Task<Post> GetWithDetailsByIdAsync(int postId);
	}
}