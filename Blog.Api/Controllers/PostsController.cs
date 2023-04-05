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

        //todo: write a more specific call so that api doesn't have to fetch entire list of posts from db, but rather only a post that matches a URL



        [HttpGet]
        [Produces("application/json")]
        public async Task<IActionResult> GetPosts()
        {
            try
            {
                var posts = await _postService.GetPostsAsync();
                return Ok(posts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "an API error occurred");
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost([FromBody] Post post)
        {
            var createdPost = await _postService.CreatePostAsync(post);

            //return CreatedAtAction(nameof(GetPost), new { id = post.Id }, post);
            return Ok(createdPost);
        }

    }
}