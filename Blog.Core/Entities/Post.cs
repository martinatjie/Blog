﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Blog.Core.Entities
{
    /// <summary>
    /// Post model: This model would represent a blog post. It would have properties for the title, content, author, date, and like count.
    /// </summary>
    public class Post : IBlogLikeItem, IBlogCommentItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }

        [NotMapped]
        public int LikeCount { get; set; }
        public DateTime LastUpdated { get; set; } = DateTime.Now;
        public DateTime Created { get; set; } = DateTime.Now;
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Like>? Likes { get; set; }
    }
}
