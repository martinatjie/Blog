using Blog.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {

        private readonly ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPost")]
        public IEnumerable<Post> Get()
        {
            throw new NotImplementedException();
        }
    }
}