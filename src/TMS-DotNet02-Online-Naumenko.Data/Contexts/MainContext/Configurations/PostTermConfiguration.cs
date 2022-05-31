using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Contexts.MainContext.Configurations
{
    public class PostTermConfiguration : IEntityTypeConfiguration<PostTerm>
    {
        public void Configure(EntityTypeBuilder<PostTerm> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.HasOne(postTerm => postTerm.Post)
                .WithMany(post => post.PostTerms)
                .HasForeignKey(postTerm => postTerm.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(postTerm => postTerm.Term)
                .WithMany(term => term.PostTerms)
                .HasForeignKey(postTerm => postTerm.TermId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
