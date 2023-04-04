using Blog.Core.Entities;
using Blog.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Data;
using Microsoft.EntityFrameworkCore;

namespace Blog.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private BlogDbContext _dataContext;

        public PostRepository(BlogDbContext dataContext)
        {
            _dataContext  = dataContext;
        }

        public async Task<Post> CreatePostAsync(Post post)
        {
            if (post.Id == default)
            {
                var postEntity = _dataContext.Posts.Add(post);
                await _dataContext.SaveChangesAsync();
                return postEntity.Entity;
            }
            else
            {
                _dataContext.Posts.Update(post);
                await _dataContext.SaveChangesAsync();
                return post;
            }
        }

        public async Task<List<Post>> GetPostsAsync()
        {
            return await _dataContext.Posts.ToListAsync();
        }
    }
}
