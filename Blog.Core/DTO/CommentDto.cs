using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Core.DTO
{
    /// <summary>
    /// Comment model: This model would represent a comment on a blog post. It would have properties for the content, author, date, post ID, and like count.
    /// </summary>
    public class CommentDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "comment is too long.")]
        public string Content { get; set; }
        public int UserId { get; set; }

        public int LikeCount { get; set; }
        public int PostId { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        //public ICollection<Like>? Likes { get; set; }
    }
}
