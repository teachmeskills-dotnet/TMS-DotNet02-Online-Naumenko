using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public DbSet<UserRole>? UserRole { get; set; }

        /// <summary>
        /// DbSet for Terms.
        /// </summary>
        public DbSet<Term>? Terms { get; set; }

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NewsPortal.db");
        }
    }
}
