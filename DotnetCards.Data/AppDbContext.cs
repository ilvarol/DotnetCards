using DotnetCards.Core.Models;
using DotnetCards.Data.Configurations;
using DotnetCards.Data.Seeds;
using Microsoft.EntityFrameworkCore;

namespace DotnetCards.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<PostDetail> PostDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new PostDetailConfiguration());

            modelBuilder.ApplyConfiguration(new PostSeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new PostDetailSeed(new int[] { 1, 2 }));

            base.OnModelCreating(modelBuilder);
        }
    }
}