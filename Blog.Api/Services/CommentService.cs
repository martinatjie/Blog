using Blog.Core.DTO;
using Blog.Core.Entities;
using Blog.Core.Repositories;
using Blog.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Api.Services
{
    internal class CommentService : ICommentService
    {
        private ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public async Task<Comment> CreateCommentAsync(CommentDto comment)
        {
            var mappedComment = new Comment
            {
                Content = comment.Content,
                UserId = comment.UserId,
                PostId = comment.PostId
            };
            var result = await _commentRepository.CreateCommentAsync(mappedComment);
            return result;
        }
    }
}
