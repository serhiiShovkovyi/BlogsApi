using BlogsApi.Model;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace BlogsApi.Data
{
    public class DataContext : DbContext
    {
        IConfiguration _configuration;

        public DataContext(DbContextOptions<DataContext> options,
            IConfiguration confguration): base(options)
        {
            _configuration = confguration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("dev"));
        }

        public DbSet<BlogModel>  Blogs { get; set; }
    }
}
