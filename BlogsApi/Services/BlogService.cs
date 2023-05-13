using BlogsApi.Data;
using BlogsApi.Entities;
using BlogsApi.Model;
using Microsoft.EntityFrameworkCore;

namespace BlogsApi.Services
{
    public class BlogService : IBlogService
    {
        private readonly DataContext _blogDbContext;

        public BlogService(DataContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }

        public BlogModel CreateBlog(BlogModel blog)
        {
            blog.Id = Convert.ToString(Guid.NewGuid());

            try
            {
                _blogDbContext.Add(blog);
                return blog;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public BlogModel? GetBlog(string id)
        {
            var blogs = _blogDbContext.Blogs;
            return blogs.FirstOrDefault(b => b.Id == id);
        }

        public async Task<List<BlogModel>> GetAllBlogs()
        {
            var blogs = _blogDbContext.Blogs.ToListAsync();

            return await blogs;
        }
    }
}
