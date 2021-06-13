namespace SimpleDotnet.Core.Models
{
    public class PostDetail
    {
        public int PostDetailId { get; set; }
        public int PostID { get; set; }
        public int PostText { get; set; }

        //Note: Adding public virtual for EF
        public virtual Post Post { get; set; }
    }
}
