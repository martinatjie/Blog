using Blog.Core.Entities;
using Blog.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {

        private readonly ILogger<PostsController> _logger;
        private readonly IPostService _postService;

        public PostsController(ILogger<PostsController> logger, IPostService postService)
        {
            _logger = logger;
            _postService = postService;
        }

        //[HttpGet(Name = "GetPost")]
        //public IEnumerable<Post> Get()
        //{
        //    throw new NotImplementedException();
        //}

        [HttpGet]
        [Produces("application/json")]
        public async Task<IActionResult> GetPosts()
        {
            var posts = await _postService.GetPostsAsync();
            return Ok(posts);
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Post>> GetPost(int id)
        //{
        //    var post = await _postService.GetPostAsync(id);

        //    if (post == null)
        //    {
        //        return NotFound();
        //    }

        //    return post;
        //}

        [HttpPost]
        public async Task<IActionResult> CreatePost([FromBody] Post post)
        {
            var createdPost = await _postService.CreatePostAsync(post);

            //return CreatedAtAction(nameof(GetPost), new { id = post.Id }, post);
            return Ok(createdPost);
        }

    }
}