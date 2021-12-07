using DotnetCards.Core.Models;
using System.Threading.Tasks;

namespace DotnetCards.Core.Repositories
{
	public interface IPostRepository
	{
		Task<Post> GetWithPostDetailsByIdAsync(int postId);
	}
}
