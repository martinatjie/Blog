using AutoMapper;
using Blog.Core.DTO;
using Blog.Core.Entities;

namespace Blog.Api.Resolvers
{
    public class CommentResolver : IMemberValueResolver<Post, PostDto, ICollection<CommentDto>, List<string>>
    {
        public List<string> Resolve(Post source, PostDto destination, ICollection<CommentDto> sourceMember, List<string> destMember, ResolutionContext context)
        {
            return sourceMember.Select(c => c.Content).ToList();
        }
    }
}
