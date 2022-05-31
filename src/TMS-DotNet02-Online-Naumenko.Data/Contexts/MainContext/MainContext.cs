using Microsoft.EntityFrameworkCore;
using TMS_DotNet02_Online_Naumenko.Data.Contexts.MainContext.Configurations;
using TMS_DotNet02_Online_Naumenko.Data.Models;

namespace TMS_DotNet02_Online_Naumenko.Data.Contexts.MainContext
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
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// DbSet for User Roles.
        /// </summary>
        public DbSet<UserRole> UserRoles { get; set; }

        /// <summary>
        /// DbSet for Terms.
        /// </summary>
        public DbSet<Term> Terms { get; set; }

        /// <summary>
        /// DbSet for Terms.
        /// </summary>
        public DbSet<PostTerm> PostTerms { get; set; }

        /// <summary>
        /// DbSet for Posts.
        /// </summary>
        public DbSet<Post> Posts { get; set; }

        /// <summary>
        /// DbSet for Options.
        /// </summary>
        public DbSet<Option> Options { get; set; }

        /// <summary>
        /// DbSet for File Extensions.
        /// </summary>
        public DbSet<FileExtension> FileExtensions { get; set; }

        /// <summary>
        /// DbSet for Files.
        /// </summary>
        public DbSet<Models.File> Files { get; set; }

        /// <summary>
        /// DbSet for Files.
        /// </summary>
        public DbSet<FileTerm> FileTerms { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ApplyConfiguration(new FileConfiguration());
            builder.ApplyConfiguration(new FileTermConfiguration());
            builder.ApplyConfiguration(new PostConfiguration());
            builder.ApplyConfiguration(new PostTermConfiguration());
            builder.ApplyConfiguration(new TermConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());

            builder.Entity<UserRole>().HasData(
                new UserRole[]
                {
                    new UserRole() {Id = 1, Name = "admin"},
                    new UserRole() {Id = 2, Name = "editor"}
                });

            builder.Entity<User>().HasData(
                new User[]
                {
                    new User() {
                        Id = 1, 
                        Login = "admin", 
                        PasswordHash = "$2a$11$hmfTa1iFuPbr4O83CClksurk83/oDbXi5WEMP/yqgqpKLbZ0dF93.", 
                        Email = "test@test.test", 
                        Name = "Super User",
                        RegisteredAt = DateTime.UtcNow,
                        UserRoleId = 1,
                    }
                });

            builder.Entity<FileExtension>().HasData(
                new FileExtension[]
                {
                    new FileExtension() { Id = 1, Name = "jpg"},
                    new FileExtension() { Id = 2, Name = "png"}
                });

            builder.Entity<Models.File>().HasData(
                new Models.File[]
                {
                    new Models.File() { 
                        Id = 1, 
                        Date = DateTime.UtcNow, 
                        ModificationDate = DateTime.UtcNow,
                        Name = "Bitcoin",
                        Slug = "bitcoin",
                        Path = "https://static.euronews.com/articles/stories/06/70/41/64/1100x619_cmsv2_5f541c98-76be-5006-884a-6aeb44d3ea5d-6704164.jpg",
                        FileExtensionId = 1,
                        UserId = 1,
                    },
                    new Models.File() {
                        Id = 2,
                        Date = DateTime.UtcNow,
                        ModificationDate = DateTime.UtcNow,
                        Name = "Bayraktar drone",
                        Slug = "bayraktar-drone",
                        Path = "https://static.euronews.com/articles/stories/06/73/86/18/773x435_cmsv2_21a9e255-64c6-5f6d-b2b7-6cb91ffd959c-6738618.jpg",
                        FileExtensionId = 1,
                        UserId = 1,
                    },
                    new Models.File() {
                        Id = 3,
                        Date = DateTime.UtcNow,
                        ModificationDate = DateTime.UtcNow,
                        Name = "Russian troops",
                        Slug = "russian-troops",
                        Path = "https://static.euronews.com/articles/stories/06/73/98/06/773x435_cmsv2_3bca83fd-4dfd-55c1-abee-d0e4a5ce92ce-6739806.jpg",
                        FileExtensionId = 1,
                        UserId = 1,
                    },
                    new Models.File() {
                        Id = 4,
                        Date = DateTime.UtcNow,
                        ModificationDate = DateTime.UtcNow,
                        Name = "Liverpool fans",
                        Slug = "liverpool-fans",
                        Path = "https://static.euronews.com/articles/stories/06/73/99/06/773x435_cmsv2_28e39cf9-5c2e-5180-bc01-527de916c93c-6739906.jpg",
                        FileExtensionId = 1,
                        UserId = 1,
                    },
                });

                builder.Entity<Option>().HasData(
                    new Option[]
                    {
                        new Option() { Id = 1, Name = "Site name", Value = "News Portal"},
                    });

                builder.Entity<Term>().HasData(
                    new Term[]
                    {
                            new Term() { Id = 1, Name = "Money", Slug = "Money", Parent = 0, UserId = 1, TermTypeId = (Models.Enums.TermType)1},
                            new Term() { Id = 2, Name = "Politic", Slug = "Politic", Parent = 0, UserId = 1, TermTypeId = (Models.Enums.TermType)1},
                            new Term() { Id = 3, Name = "Bitcoin", Slug = "Bitcoin", Parent = 1, UserId = 1, TermTypeId = (Models.Enums.TermType)1},
                    });

                builder.Entity<Post>().HasData(
                    new Post[]
                    {
                            new Post() { 
                                Id = 1, 
                                TypeId = 1, 
                                Title = "Bitcoin slips back below $30,000 as European regulators renew crypto warnings after Terra Luna crash", 
                                Slug = "bitcoin-slips-back-below-30000-as-european-regulators-renew-crypto-warnings-after-terra-luna-crash",
                                Content = "Cryptocurrencies resumed their slide on Monday, giving up the gains they had eked out over the weekend as regulators continued to circle.European officials reiterated warnings of risks posed by cryptocurrencies.Bitcoin fell 5 per cent to around $29,700 (€28,500) on Monday in Asian trade, sliding alongside stocks because of worries about high inflation and rising interest rates.The world's largest cryptocurrency has lost around a fifth of its value so far this month, as the spectacular collapse of TerraUSD, a so-called stablecoin, has roiled crypto markets already falling amid a broad selling of risky investments.",
                                Excerpt = "Cryptocurrencies resumed their slide on Monday, giving up the gains they had eked out over the weekend as regulators continued to circle.European officials reiterated warnings of risks posed by cryptocurrencies.Bitcoin fell 5 per cent to around $29,700 (€28,500) on Monday in Asian trade, sliding alongside stocks because of worries about high inflation and rising interest rates.The world's largest cryptocurrency has lost around a fifth of its value so far this month, as the spectacular collapse of TerraUSD, a so-called stablecoin, has roiled crypto markets already falling amid a broad selling of risky investments.",
                                ReadingTime = "2 min",
                                Date = DateTime.UtcNow,
                                ModificationDate = DateTime.UtcNow,
                                PostStatusId = (Models.Enums.PostStatus)1,
                                UserId = 1,
                                FileId = 1,
                            },
                            new Post() {
                                Id = 2,
                                TypeId = 1,
                                Title = "Russian troops storm Sievierodonetsk as Donbas suffers heavy bombardment",
                                Slug = "russian-troops-storm-sievierodonetsk-as-donbas-suffers-heavy-bombardment",
                                Content = "Russian and Ukrainian troops engaged in close-quarter combat in an eastern Ukraine city on Sunday as Moscow's soldiers, supported by intense shelling, attempted to gain a strategic foothold in the region while facing fierce Ukrainian resistance.",
                                Excerpt = "Russian and Ukrainian troops engaged in close-quarter combat in an eastern Ukraine city on Sunday as Moscow's soldiers, supported by intense shelling, attempted to gain a strategic foothold in the region while facing fierce Ukrainian resistance.",
                                ReadingTime = "2 min",
                                Date = DateTime.UtcNow,
                                ModificationDate = DateTime.UtcNow,
                                PostStatusId = (Models.Enums.PostStatus)1,
                                UserId = 1,
                                FileId = 3,
                            },
                            new Post() {
                                Id = 3,
                                TypeId = 1,
                                Title = "Liverpool fans pepper-sprayed by French police in stadium entry chaos",
                                Slug = "liverpool-fans-pepper-sprayed-by-french-police-in-stadium-entry-chaos",
                                Content = "Riot police fired tear gas and pepper spray at Liverpool supporters forced to endure long waits to get into the Champions League final amid logistical chaos on Saturday.The start of the showpiece game of the European football season, in which Liverpool lost 1-0 to Real Madrid, was delayed for 37 minutes and kicked off as security was still struggling with the flow of frustrated supporters into the Stade de France.UEFA claimed there were thousands of ticketless fans trying to gain access to the 80, 000 - plus capacity French national stadium but it did not identify where they were from.French Interior Minister Gérald Darmanin claimed stewards were assaulted by the supporters of the English side who forced entry without tickets or with counterfeit tickets.",
                                Excerpt = "Riot police fired tear gas and pepper spray at Liverpool supporters forced to endure long waits to get into the Champions League final amid logistical chaos on Saturday.The start of the showpiece game of the European football season, in which Liverpool lost 1-0 to Real Madrid, was delayed for 37 minutes and kicked off as security was still struggling with the flow of frustrated supporters into the Stade de France.UEFA claimed there were thousands of ticketless fans trying to gain access to the 80, 000 - plus capacity French national stadium but it did not identify where they were from.French Interior Minister Gérald Darmanin claimed stewards were assaulted by the supporters of the English side who forced entry without tickets or with counterfeit tickets.",
                                ReadingTime = "1 min",
                                Date = DateTime.UtcNow,
                                ModificationDate = DateTime.UtcNow,
                                PostStatusId = (Models.Enums.PostStatus)1,
                                UserId = 1,
                                FileId = 4,
                            },
                            new Post() {
                                Id = 4,
                                TypeId = 1,
                                Title = "Norway's energy sales growth spurs accusations of profiting from war, demands for help",
                                Slug = "norways-energy-sales-growth-spurs-accusations-of-profiting-from-war-demands-for-help",
                                Content = "Europe's frantic search for alternatives to Russian energy has dramatically increased the demand — and price — for Norway's oil and gas.But the continent's second-biggest natural gas supplier is now fending off accusations that it is profiting from the war in Ukraine.Polish Prime Minister Mateusz Morawiecki, who is looking to the Scandinavian country to replace some of the gas Poland used to get from Russia, said Norway's 'gigantic' oil and gas profits are 'indirectly preying on the war'. He urged Norway to use that windfall to support the hardest-hit countries, mainly Ukraine.The comments last week touched a nerve, even as some Norwegians wonder whether they're doing enough to combat Kremlin's war by increasing economic aid to Ukraine and helping neighbouring countries end their dependence on Russian energy.",
                                Excerpt = "Europe's frantic search for alternatives to Russian energy has dramatically increased the demand — and price — for Norway's oil and gas.But the continent's second-biggest natural gas supplier is now fending off accusations that it is profiting from the war in Ukraine.Polish Prime Minister Mateusz Morawiecki, who is looking to the Scandinavian country to replace some of the gas Poland used to get from Russia, said Norway's 'gigantic' oil and gas profits are 'indirectly preying on the war'. He urged Norway to use that windfall to support the hardest-hit countries, mainly Ukraine.The comments last week touched a nerve, even as some Norwegians wonder whether they're doing enough to combat Kremlin's war by increasing economic aid to Ukraine and helping neighbouring countries end their dependence on Russian energy.",
                                ReadingTime = "1 min",
                                Date = DateTime.UtcNow,
                                ModificationDate = DateTime.UtcNow,
                                PostStatusId = (Models.Enums.PostStatus)1,
                                UserId = 1,
                                FileId = 2,
                            },
                            new Post() {
                                Id = 5,
                                TypeId = 1,
                                Title = "Test news",
                                Slug = "test-news",
                                Content = "test content",
                                Excerpt = "test content",
                                ReadingTime = "1 min",
                                Date = DateTime.UtcNow,
                                ModificationDate = DateTime.UtcNow,
                                PostStatusId = (Models.Enums.PostStatus)1,
                                UserId = 1,
                                FileId = 1,
                            },
                    });

                builder.Entity<PostTerm>().HasData(
                    new PostTerm[]
                    {
                        new PostTerm() { Id = 1, PostId = 2, TermId = 1},
                        new PostTerm() { Id = 2, PostId = 2, TermId = 3},
                        new PostTerm() { Id = 3, PostId = 1, TermId = 1},
                        new PostTerm() { Id = 4, PostId = 1, TermId = 2},
                        new PostTerm() { Id = 5, PostId = 3, TermId = 2},
                        new PostTerm() { Id = 6, PostId = 4, TermId = 2},
                        new PostTerm() { Id = 7, PostId = 4, TermId = 3},
                    });

            base.OnModelCreating(builder);
        }
    }
}
