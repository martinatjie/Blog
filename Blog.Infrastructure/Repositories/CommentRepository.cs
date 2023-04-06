using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Core.Entities;
using Blog.Core.Repositories;
using Blog.Data;

namespace Blog.Infrastructure.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private BlogDbContext _dataContext;

        public CommentRepository(BlogDbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Comment> CreateCommentAsync(Comment comment)
        {
            if (comment.Id == default)
            {
                var commentEntity = _dataContext.Comments.Add(comment);
                await _dataContext.SaveChangesAsync();
                return commentEntity.Entity;
            }
            else
            {
                _dataContext.Comments.Update(comment);
                await _dataContext.SaveChangesAsync();
                return comment;
            }
        }
    }
}
