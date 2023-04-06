using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Blog.Core.Entities
{
    /// <summary>
    /// an interface that can be used for classes for which comments can be written. This can be a post or another comment.
    /// </summary>
    public interface IBlogCommentItem
    {
        [Key]
        int Id { get; set; }
        string Content { get; set; }
        int UserId { get; set; }
        User? User { get; set; }

        [NotMapped]
        int LikeCount { get; set; }
        int PostId { get; set; }
        Post? Post { get; set; }
        DateTime Created { get; set; }
        ICollection<Like> Likes { get; set; }
    }
}