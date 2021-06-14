using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleDotnet.Core.Models;

namespace DotnetCards.Data.Configurations
{
    class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            //To determine primary key of table
            builder.HasKey(x => x.Id);
            // To increase the ID column one by one
            builder.Property(x => x.Id).UseIdentityColumn();
            // To specify any limit and determine field required
            builder.Property(x => x.Title).IsRequired().HasMaxLength(200);
            // To specify one-directional (also called unidirectional) relationship
            builder.HasOne(x => x.Parent).WithMany(b => b.Children).HasForeignKey(b => b.ParentPostID);
        }
    }
}
