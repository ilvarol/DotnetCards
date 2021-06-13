using System;
using System.Collections.Generic;

namespace SimpleDotnet.Core.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public DateTime PostDate { get; set; }
        public bool IsDeleted { get; set; }
        public int MainPostID { get; set; }

        //Note: Adding this collection property for EF
        public ICollection<PostDetail> PostDetails { get; set; }
    }
}
