using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Core.Entities
{
    /// <summary>
    /// Comment model: This model would represent a comment on a blog post. It would have properties for the content, author, date, post ID, and like count.
    /// </summary>
    public class Comment : IBlogLikeItem, IBlogCommentItem
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        [NotMapped]
        public int LikeCount { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public DateTime Created { get; set; }
        public ICollection<Like> Likes { get; set; }
    }
}
