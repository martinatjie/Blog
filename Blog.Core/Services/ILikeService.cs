using Blog.Core.Entities;

namespace Blog.Core.Services
{
    /// <summary>
    /// LikeService: This service would handle CRUD operations for likes/dislikes, as well as validation to ensure that a user can only like a post/comment once.
    /// </summary>
    public interface ILikeService
    {
        void ToggleLike(IBlogLikeItem likeItem);
        void GetLikeCount(IBlogLikeItem likeItem);
    }
}
