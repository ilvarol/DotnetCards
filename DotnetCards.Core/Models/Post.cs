using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetCards.Core.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int? ParentPostId { get; set; }

        public virtual Post Parent { get; set; }
        public virtual ICollection<Post> Children { get; set; }
        public virtual ICollection<PostDetail> PostDetails { get; set; }
    }
}
