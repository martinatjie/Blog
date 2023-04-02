using System.ComponentModel.DataAnnotations;

namespace Blog.Core.Entities
{
    /// <summary>
    /// Like model: This model would represent a like on a post or comment. It would have properties for the user ID, post/comment ID, and a boolean flag for whether it is a like or dislike.
    /// </summary>
    public class Like
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
