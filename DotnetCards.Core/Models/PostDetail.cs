namespace DotnetCards.Core.Models
{
    public class PostDetail
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string PostText { get; set; }
        public virtual Post Post { get; set; }
    }
}