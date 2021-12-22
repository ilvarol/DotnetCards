using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DotnetCards.Core.Models;

namespace DotnetCards.Data.Configurations
{
    internal class PostDetailConfiguration : IEntityTypeConfiguration<PostDetail>
    {
        public void Configure(EntityTypeBuilder<PostDetail> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn();

            builder.Property(x => x.PostText)
                .IsRequired();

            builder.HasOne(x => x.Post)
                .WithMany(b => b.PostDetails)
                .HasForeignKey(b => b.PostId);

            builder.ToTable("PostDetails");
        }
    }
}
