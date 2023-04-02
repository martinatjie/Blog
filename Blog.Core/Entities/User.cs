using System.ComponentModel.DataAnnotations;

namespace Blog.Core.Entities
{
    /// <summary>
    /// User model: This model would represent a user of the system. It would have properties for the user ID, name, surname, email, password, and a boolean flag for whether the user is an admin.
    /// </summary>
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsAdmin { get; set; }
        public string Email { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }
    }
}
