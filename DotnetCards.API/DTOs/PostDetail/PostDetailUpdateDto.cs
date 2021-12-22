using DotnetCards.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCards.API.DTOs
{
    public class PostDetailUpdateDto
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string PostText { get; set; }
    }
}
