using AutoMapper;
using DotnetCards.API.DTOs;
using DotnetCards.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCards.API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Post, PostCreateDto>().ReverseMap();
            CreateMap<Post, PostReadDto>().ReverseMap();
            CreateMap<Post, PostUpdateDto>().ReverseMap();
            CreateMap<Post, PostWithDetailsReadDto>().ReverseMap();

            CreateMap<PostDetail, PostDetailCreateDto>().ReverseMap();
            CreateMap<PostDetail, PostDetailReadDto>().ReverseMap();
            CreateMap<PostDetail, PostDetailUpdateDto>().ReverseMap();
            CreateMap<PostDetail, PostDetailWithPostReadDto>().ReverseMap();
        }
    }
}
