using DotnetCards.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DotnetCards.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var posts = await _postService.GetAllAsync();

            return Ok(posts);
        }
    }
}