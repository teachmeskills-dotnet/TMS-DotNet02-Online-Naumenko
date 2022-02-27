using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Configurations
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

            builder.HasOne(fileTerm => fileTerm.Term)
                .WithMany(term => term.PostTerms)
                .HasForeignKey(fileTerm => fileTerm.TermId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
