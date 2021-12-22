using AutoMapper;
using DotnetCards.API.DTOs;
using DotnetCards.API.Filters;
using DotnetCards.Core.Models;
using DotnetCards.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotnetCards.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;

        public PostsController(IPostService postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var posts = await _postService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<PostReadDto>>(posts));
        }

        [TypeFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var post = await _postService.GetByIdAsync(id);

            return Ok(_mapper.Map<PostReadDto>(post));
        }

        [HttpGet("{id}/details")]
        public async Task<IActionResult> GetWithDetailsByIdc(int id)
        {
            var post = await _postService.GetWithDetailsByIdAsync(id);

            return Ok(_mapper.Map<PostWithDetailsReadDto>(post));
        }

        [HttpPost]
        public async Task<IActionResult> Save(PostCreateDto postDto)
        {
            var newPost = await _postService.AddAsync(_mapper.Map<Post>(postDto));

            return Created(string.Empty, _mapper.Map<PostReadDto>(newPost));
        }

        [HttpPut]
        public IActionResult Update(PostUpdateDto postDto)
        {
            var post = _postService.Update(_mapper.Map<Post>(postDto));

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var post = _postService.GetByIdAsync(id).Result;
            _postService.Remove(post);

            return NoContent();
        }
    }
}