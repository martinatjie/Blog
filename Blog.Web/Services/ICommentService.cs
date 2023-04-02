﻿using Blog.Web.Models;

namespace Blog.Web.Services
{
    /// <summary>
    /// CommentService: This service would handle CRUD operations for comments, as well as validation to ensure that comments are associated with a valid comment.
    /// </summary>
    public interface ICommentService : IBlogLikeItem, IBlogCommentItem
    {
        void ValidateComment(Comment comment);
        void AddComment(Comment comment);
        void DeleteComment(Comment comment);
        void GetAllComments(IBlogCommentItem blogCommentItem);
        void GetComment(int commentId);
        void UpdateComment(Comment comment);
    }
}
