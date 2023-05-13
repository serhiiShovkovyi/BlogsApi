using BlogsApi.Entities;
using BlogsApi.Model;

namespace BlogsApi.Services
{
    public interface IBlogService
    {
        public BlogModel CreateBlog(BlogModel blog);

        public BlogModel? GetBlog(string id);

        public Task<List<BlogModel>> GetAllBlogs();
    }
}
