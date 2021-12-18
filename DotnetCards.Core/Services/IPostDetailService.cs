using DotnetCards.Core.Models;
using System.Threading.Tasks;

namespace DotnetCards.Core.Services
{
	public interface IPostDetailService : IService<PostDetail>
	{
		Task<PostDetail> GetWithPostByIdAsync(int postDetailId);
	}
}