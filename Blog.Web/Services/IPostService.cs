using Blog.Web.Models;

namespace Blog.Web.Services
{
    /// <summary>
    /// PostService: This service would handle CRUD operations for posts, as well as validation to ensure that titles are unique.
    /// </summary>
    public interface IPostService : IBlogLikeItem, IBlogCommentItem
    {
        void ValidatePost(Post post); //especially title
        void SavePostAsDraft(Post post);
        void PublishPost(Post post);
        void DeletePost(Post post);
        void GetAllPosts();
        //void GetPost(string postTitle);
        void GetPost(int postId);
        void UpdatePost(Post post);
    }
}
