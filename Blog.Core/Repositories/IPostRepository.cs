using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Repositories
{
    public interface IPostRepository
    {
        Task<Post> CreatePostAsync(Post post);
        Task<List<Post>> GetPostsAsync();
    }
}
