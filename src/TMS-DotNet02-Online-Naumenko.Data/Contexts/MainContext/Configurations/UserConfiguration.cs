using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Data.Constants;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Contexts.MainContext.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(Table.Users, Schema.User)
                .HasKey(user => user.Id);

            builder.HasOne(user => user.UserRole)
                .WithMany(userRole => userRole.Users)
                .HasForeignKey(user => user.UserRoleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
