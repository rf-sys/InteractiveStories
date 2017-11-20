using InteractiveStories.Infrastructure.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace InteractiveStories.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext()
        {}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var configBuilder = new Config();

            optionsBuilder.UseNpgsql(configBuilder.Configuration["DatabaseConnection"]);

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
