using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DotnetCards.Core.Models;
using System;

namespace DotnetCards.Data.Seeds
{
    internal class PostSeed : IEntityTypeConfiguration<Post>
    {
        private readonly int[] _ids;
        public PostSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(
                new Post { Id = _ids[0], Title = "Post1", Date = DateTime.Now, IsDeleted = false, ParentPostID = null },
                new Post { Id = _ids[1], Title = "Post2", Date = DateTime.Now, IsDeleted = false, ParentPostID = null }
            );
        }
    }
}
