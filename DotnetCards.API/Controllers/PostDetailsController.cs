using AutoMapper;
using DotnetCards.API.DTOs;
using DotnetCards.Core.Models;
using DotnetCards.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotnetCards.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostDetailsController : ControllerBase
    {
        private readonly IPostDetailService _postDetailService;
        private readonly IMapper _mapper;

        public PostDetailsController(IPostDetailService postDetailDetailService, IMapper mapper)
        {
            _postDetailService = postDetailDetailService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var postDetails = await _postDetailService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<PostDetailReadDto>>(postDetails));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var postDetail = await _postDetailService.GetByIdAsync(id);

            return Ok(_mapper.Map<PostDetailReadDto>(postDetail));
        }

        [HttpGet("{id}/post")]
        public async Task<IActionResult> GetWithPostById(int id)
        {
            var postDetail = await _postDetailService.GetWithPostByIdAsync(id);

            return Ok(_mapper.Map<PostDetailWithPostReadDto>(postDetail));
        }

        [HttpPost]
        public async Task<IActionResult> Save(PostDetailCreateDto postDetailDto)
        {
            var newPost = await _postDetailService.AddAsync(_mapper.Map<PostDetail>(postDetailDto));

            return Created(string.Empty, _mapper.Map<PostDetailReadDto>(newPost));
        }

        [HttpPut]
        public IActionResult Update(PostDetailUpdateDto postDetailDto)
        {
            var postDetail = _postDetailService.Update(_mapper.Map<PostDetail>(postDetailDto));

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var postDetail = _postDetailService.GetByIdAsync(id).Result;
            _postDetailService.Remove(postDetail);

            return NoContent();
        }
    }
}