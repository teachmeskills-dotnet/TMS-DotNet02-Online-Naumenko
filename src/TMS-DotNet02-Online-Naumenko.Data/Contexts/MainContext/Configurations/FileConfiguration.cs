using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TMS_DotNet02_Online_Naumenko.Data.Constants;

namespace TMS_DotNet02_Online_Naumenko.Data.Contexts.MainContext.Configurations
{
    public class FileConfiguration : IEntityTypeConfiguration<Models.File>
    {
        public void Configure(EntityTypeBuilder<Models.File> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(Table.Files, Schema.File)
                .HasKey(file => file.Id);

            builder.HasOne(file => file.User)
                .WithMany(users => users.Files)
                .HasForeignKey(post => post.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
