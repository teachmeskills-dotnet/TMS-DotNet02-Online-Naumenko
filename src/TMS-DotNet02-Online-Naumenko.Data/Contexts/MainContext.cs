using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Data.Configurations;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Contexts
{
    public class MainContext : DbContext
    {
        /// <summary>
        /// Contructor with params.
        /// </summary>
        /// <param name="options">Database context options.</param>
        public MainContext(DbContextOptions<MainContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// DbSet for Users.
        /// </summary>
        public DbSet<User>? Users { get; set; }

        /// <summary>
        /// DbSet for User Roles.
        /// </summary>
        public DbSet<UserRole>? UserRoles { get; set; }

        /// <summary>
        /// DbSet for Terms.
        /// </summary>
        public DbSet<Term>? Terms { get; set; }

        /// <summary>
        /// DbSet for Terms.
        /// </summary>
        public DbSet<PostTerm>? PostTerms { get; set; }

        /// <summary>
        /// DbSet for Posts.
        /// </summary>
        public DbSet<Post>? Posts { get; set; }

        /// <summary>
        /// DbSet for Options.
        /// </summary>
        public DbSet<Option>? Options { get; set; }

        /// <summary>
        /// DbSet for File Extensions.
        /// </summary>
        public DbSet<FileExtension>? FileExtensions { get; set; }

        /// <summary>
        /// DbSet for Files.
        /// </summary>
        public DbSet<Models.File>? Files { get; set; }

        /// <summary>
        /// DbSet for Files.
        /// </summary>
        public DbSet<FileTerm>? FileTerms { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ApplyConfiguration(new FileTermConfiguration());
            builder.ApplyConfiguration(new PostTermConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
