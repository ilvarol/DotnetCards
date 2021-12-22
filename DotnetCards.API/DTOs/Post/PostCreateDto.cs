using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCards.API.DTOs
{
    public class PostCreateDto
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int? ParentPostId { get; set; }
    }
}