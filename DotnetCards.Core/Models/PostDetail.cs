namespace DotnetCards.Core.Models
{
    public class PostDetail
    {
        public int Id { get; set; }
        public int PostID { get; set; }
        public string PostText { get; set; }
        public virtual Post Post { get; set; }
    }
}