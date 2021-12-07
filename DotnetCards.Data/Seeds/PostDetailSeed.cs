using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DotnetCards.Core.Models;
using System;

namespace DotnetCards.Data.Seeds
{
    internal class PostDetailSeed : IEntityTypeConfiguration<PostDetail>
    {
        private readonly int[] _ids;
        public PostDetailSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<PostDetail> builder)
        {
            builder.HasData(
                new PostDetail { Id = 1, PostID = _ids[0], PostText = "Post Detail 1" },
                new PostDetail { Id = 2, PostID = _ids[1], PostText = "Post Detail 2" }
            );
        }
    }
}
