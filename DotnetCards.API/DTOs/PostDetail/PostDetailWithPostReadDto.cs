using DotnetCards.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCards.API.DTOs
{
    public class PostDetailWithPostReadDto : PostDetailReadDto
    {
        public PostReadDto Post { get; set; }
    }
}