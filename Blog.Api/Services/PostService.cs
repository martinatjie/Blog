using Blog.Core.Entities;
using Blog.Core.Repositories;
using Blog.Core.Services;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Api.Services
{
    internal class PostService : IPostService
    {
        private IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<Post> CreatePostAsync(Post post)
        {
            var result = await _postRepository.CreatePostAsync(post);
            return result;
        }

        public async Task<Post> GetPostAsync(int postId)
        {
            //throw new NotImplementedException();
            return new Post
            {
                Id = postId,
                Title = "bla",
                Content = "blabla",
                User = new User { Id = 1, Name = "Blablabla" }
            };
        }

        public async Task<List<Post>> GetPostsAsync()
        {
            var result = await _postRepository.GetPostsAsync();
            return result;
        }
    }
}
