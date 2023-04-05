using Blog.Core.DTO;
using Blog.Core.Entities;

namespace Blog.Core.Services
{
    /// <summary>
    /// PostService: This service would handle CRUD operations for posts, as well as validation to ensure that titles are unique.
    /// </summary>
    public interface IPostService
    {
        //void ValidatePost(Post post); //especially title
        //void SavePostAsDraft(Post post);
        //void PublishPost(Post post);
        Task<Post> CreatePostAsync(Post post);
        //void DeletePost(Post post);
        //void GetAllPosts();
        //void GetPost(string postTitle);
        //void GetPost(int postId);

        Task<Post> GetPostAsync(int postId);
        Task<List<PostDto>> GetPostsAsync();
        //void UpdatePost(Post post);
    }
}
