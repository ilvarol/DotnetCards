using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleDotnet.Core.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }
        public int? ParentPostID { get; set; }

        public virtual Post Parent { get; set; }
        public virtual ICollection<Post> Children { get; set; }

        //Note: Adding this collection property for EF
        public ICollection<PostDetail> PostDetails { get; set; }
    }
}
