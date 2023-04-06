using AutoMapper;
using Blog.Core.DTO;
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
        //private IMapper _mapper;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
            //_mapper = mapper;
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

        public async Task<List<PostDto>> GetPostsAsync()
        {
            var result = await _postRepository.GetPostsAsync();

            var postDtos = new List<PostDto>();

            if (result != default)
            {
                foreach (var item in result)
                {
                    //var mappedPost = _mapper.Map<PostDto>(item);
                    var mappedPost = new PostDto
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Content = item.Content,
                        CommentContents = item.Comments.Select(x => x.Content).ToList(),
                        UserId = item.UserId,
                        LastUpdated = item.LastUpdated,
                        Created = item.Created,
                        Url = item.Url
                    };

                    postDtos.Add(mappedPost);
                }
            }

            return postDtos;
        }
    }
}
