using DotnetCards.Core.Models;
using System.Threading.Tasks;

namespace DotnetCards.Core.Repositories
{
	public interface IPostDetailRepository
	{
		Task<PostDetail> GetWithPostByIdAsync(int postDetailId);
	}
}
