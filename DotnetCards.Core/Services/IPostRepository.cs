using DotnetCards.Core.Models;
using System.Threading.Tasks;


namespace DotnetCards.Core.Repositories
{
	interface IPostService: IService<Post> 
	{
		Task<Post> GetWithPostDetailsByIdAsync(int postId);
	}
}
