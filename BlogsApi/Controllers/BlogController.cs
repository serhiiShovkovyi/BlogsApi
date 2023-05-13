using BlogsApi.Entities;
using BlogsApi.Model;
using BlogsApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly ILogger<BlogController> _logger;
        private readonly IBlogService _blogService;

        public BlogController(ILogger<BlogController> logger, IBlogService blogService)
        {
            _logger = logger;
            _blogService = blogService;
        }

        [HttpPost]
        public IActionResult Post(BlogModel blog)
        {
            var res = _blogService.CreateBlog(blog);
            return Ok(res);
        }

        [HttpGet("blogs/{id}")]
        public IActionResult GetBlogAsync(string id) 
        {
            var res = _blogService.GetBlog(id);

            return Ok(res);
        }

        [HttpGet("blogs")]
        public IActionResult GetAllBlogAsync() 
        {
            var res = _blogService.GetAllBlogs();
            var result = res.Result; 

            return Ok(result);
        }
    }
}