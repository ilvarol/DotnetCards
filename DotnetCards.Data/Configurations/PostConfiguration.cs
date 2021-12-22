using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DotnetCards.Core.Models;

namespace DotnetCards.Data.Configurations
{
    internal class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn();

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.HasOne(x => x.Parent)
                .WithMany(b => b.Children)
                .HasForeignKey(b => b.ParentPostId);

            builder.ToTable("Posts");
        }
    }
}
