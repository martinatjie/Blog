using AutoMapper;
using Blog.Core.DTO;
using Blog.Core.Entities;

namespace Blog.Api.Resolvers
{
    public class CommentResolver : IMemberValueResolver<Post, PostDto, ICollection<Comment>, List<string>>
    {
        public List<string> Resolve(Post source, PostDto destination, ICollection<Comment> sourceMember, List<string> destMember, ResolutionContext context)
        {
            return sourceMember.Select(c => c.Content).ToList();
        }
    }
}
