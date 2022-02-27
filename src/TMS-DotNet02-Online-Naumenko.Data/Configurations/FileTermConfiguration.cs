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
    public class FileTermConfiguration : IEntityTypeConfiguration<FileTerm>
    {
        public void Configure(EntityTypeBuilder<FileTerm> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.HasOne(fileTerm => fileTerm.File)
                .WithMany(file => file.FileTerms)
                .HasForeignKey(fileTerm => fileTerm.FileId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(fileTerm => fileTerm.Term)
                .WithMany(term => term.FileTerms)
                .HasForeignKey(fileTerm => fileTerm.TermId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
