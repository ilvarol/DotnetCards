using DotnetCards.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCards.API.DTOs
{
    public class PostDetailCreateDto
    {
        public int PostId { get; set; }
        public string PostText { get; set; }
    }
}
