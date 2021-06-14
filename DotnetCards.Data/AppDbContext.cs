using Microsoft.EntityFrameworkCore;

namespace DotnetCards.Data
{
    class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public int Posts { get; set; }
        public int PostDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Note: Look again later!
            base.OnModelCreating(modelBuilder);
        }
    }
}
