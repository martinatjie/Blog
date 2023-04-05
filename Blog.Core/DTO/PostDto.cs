using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Blog.Core.DTO
{
    public class PostDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }
        public int UserId { get; set; }

        //public int LikeCount { get; set; }

        public DateTime LastUpdated { get; set; } = DateTime.Now;
        public DateTime Created { get; set; } = DateTime.Now;
        public ICollection<string> CommentContents { get; set; } = new List<string>();
        //public ICollection<Like>? Likes { get; set; }

        /// <summary>
        /// returns an excerpt of the content. If less than 100 characters, it returns the full content.
        /// </summary>
        public string Excerpt
        {
            get
            {
                return Content[..Math.Min(Content.Length, 100)];
            }
        }

        public string Url { get; set; }
    }
}
