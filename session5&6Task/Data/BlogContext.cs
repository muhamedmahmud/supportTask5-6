using Microsoft.EntityFrameworkCore;
using session5_6Task.Models;

namespace session5_6Task.Data
{
    public class BlogContext : DbContext
    {
        // EF Core constructor (no base call needed)
        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogType> BlogTypes { get; set; }
    }
}