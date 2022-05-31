using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMS_DotNet02_Online_Naumenko.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "file");

            migrationBuilder.EnsureSchema(
                name: "post");

            migrationBuilder.EnsureSchema(
                name: "term");

            migrationBuilder.EnsureSchema(
                name: "user");

            migrationBuilder.CreateTable(
                name: "FileExtensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileExtensions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "user",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UserRoles_UserRoleId",
                        column: x => x.UserRoleId,
                        principalTable: "UserRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                schema: "file",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileExtensionId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Files_FileExtensions_FileExtensionId",
                        column: x => x.FileExtensionId,
                        principalTable: "FileExtensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Files_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "user",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Terms",
                schema: "term",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parent = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TermTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Terms_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "user",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                schema: "post",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Excerpt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReadingTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostStatusId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Files_FileId",
                        column: x => x.FileId,
                        principalSchema: "file",
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "user",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FileTerms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId = table.Column<int>(type: "int", nullable: false),
                    TermId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileTerms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileTerms_Files_FileId",
                        column: x => x.FileId,
                        principalSchema: "file",
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FileTerms_Terms_TermId",
                        column: x => x.TermId,
                        principalSchema: "term",
                        principalTable: "Terms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostTerms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    TermId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTerms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostTerms_Posts_PostId",
                        column: x => x.PostId,
                        principalSchema: "post",
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostTerms_Terms_TermId",
                        column: x => x.TermId,
                        principalSchema: "term",
                        principalTable: "Terms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "FileExtensions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "jpg" },
                    { 2, "png" }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[] { 1, "Site name", "News Portal" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "admin" },
                    { 2, "editor" }
                });

            migrationBuilder.InsertData(
                schema: "user",
                table: "Users",
                columns: new[] { "Id", "Email", "Login", "Name", "PasswordHash", "RegisteredAt", "UserRoleId" },
                values: new object[] { 1, "test@test.test", "admin", "Super User", "$2a$11$hmfTa1iFuPbr4O83CClksurk83/oDbXi5WEMP/yqgqpKLbZ0dF93.", new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3110), 1 });

            migrationBuilder.InsertData(
                schema: "file",
                table: "Files",
                columns: new[] { "Id", "Date", "FileExtensionId", "ModificationDate", "Name", "Path", "Slug", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3139), 1, new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3140), "Bitcoin", "https://static.euronews.com/articles/stories/06/70/41/64/1100x619_cmsv2_5f541c98-76be-5006-884a-6aeb44d3ea5d-6704164.jpg", "bitcoin", 1 },
                    { 2, new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3142), 1, new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3142), "Bayraktar drone", "https://static.euronews.com/articles/stories/06/73/86/18/773x435_cmsv2_21a9e255-64c6-5f6d-b2b7-6cb91ffd959c-6738618.jpg", "bayraktar-drone", 1 },
                    { 3, new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3143), 1, new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3143), "Russian troops", "https://static.euronews.com/articles/stories/06/73/98/06/773x435_cmsv2_3bca83fd-4dfd-55c1-abee-d0e4a5ce92ce-6739806.jpg", "russian-troops", 1 },
                    { 4, new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3145), 1, new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3145), "Liverpool fans", "https://static.euronews.com/articles/stories/06/73/99/06/773x435_cmsv2_28e39cf9-5c2e-5180-bc01-527de916c93c-6739906.jpg", "liverpool-fans", 1 }
                });

            migrationBuilder.InsertData(
                schema: "term",
                table: "Terms",
                columns: new[] { "Id", "Name", "Parent", "Slug", "TermTypeId", "UserId" },
                values: new object[,]
                {
                    { 1, "Money", 0, "Money", 1, 1 },
                    { 2, "Politic", 0, "Politic", 1, 1 },
                    { 3, "Bitcoin", 1, "Bitcoin", 1, 1 }
                });

            migrationBuilder.InsertData(
                schema: "post",
                table: "Posts",
                columns: new[] { "Id", "Content", "Date", "Excerpt", "FileId", "ModificationDate", "PostStatusId", "ReadingTime", "Slug", "Title", "TypeId", "UserId" },
                values: new object[,]
                {
                    { 1, "Cryptocurrencies resumed their slide on Monday, giving up the gains they had eked out over the weekend as regulators continued to circle.European officials reiterated warnings of risks posed by cryptocurrencies.Bitcoin fell 5 per cent to around $29,700 (€28,500) on Monday in Asian trade, sliding alongside stocks because of worries about high inflation and rising interest rates.The world's largest cryptocurrency has lost around a fifth of its value so far this month, as the spectacular collapse of TerraUSD, a so-called stablecoin, has roiled crypto markets already falling amid a broad selling of risky investments.", new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3190), "Cryptocurrencies resumed their slide on Monday, giving up the gains they had eked out over the weekend as regulators continued to circle.European officials reiterated warnings of risks posed by cryptocurrencies.Bitcoin fell 5 per cent to around $29,700 (€28,500) on Monday in Asian trade, sliding alongside stocks because of worries about high inflation and rising interest rates.The world's largest cryptocurrency has lost around a fifth of its value so far this month, as the spectacular collapse of TerraUSD, a so-called stablecoin, has roiled crypto markets already falling amid a broad selling of risky investments.", 1, new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3190), 1, "2 min", "bitcoin-slips-back-below-30000-as-european-regulators-renew-crypto-warnings-after-terra-luna-crash", "Bitcoin slips back below $30,000 as European regulators renew crypto warnings after Terra Luna crash", 1, 1 },
                    { 2, "Russian and Ukrainian troops engaged in close-quarter combat in an eastern Ukraine city on Sunday as Moscow's soldiers, supported by intense shelling, attempted to gain a strategic foothold in the region while facing fierce Ukrainian resistance.", new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3193), "Russian and Ukrainian troops engaged in close-quarter combat in an eastern Ukraine city on Sunday as Moscow's soldiers, supported by intense shelling, attempted to gain a strategic foothold in the region while facing fierce Ukrainian resistance.", 3, new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3193), 1, "2 min", "russian-troops-storm-sievierodonetsk-as-donbas-suffers-heavy-bombardment", "Russian troops storm Sievierodonetsk as Donbas suffers heavy bombardment", 1, 1 },
                    { 3, "Riot police fired tear gas and pepper spray at Liverpool supporters forced to endure long waits to get into the Champions League final amid logistical chaos on Saturday.The start of the showpiece game of the European football season, in which Liverpool lost 1-0 to Real Madrid, was delayed for 37 minutes and kicked off as security was still struggling with the flow of frustrated supporters into the Stade de France.UEFA claimed there were thousands of ticketless fans trying to gain access to the 80, 000 - plus capacity French national stadium but it did not identify where they were from.French Interior Minister Gérald Darmanin claimed stewards were assaulted by the supporters of the English side who forced entry without tickets or with counterfeit tickets.", new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3195), "Riot police fired tear gas and pepper spray at Liverpool supporters forced to endure long waits to get into the Champions League final amid logistical chaos on Saturday.The start of the showpiece game of the European football season, in which Liverpool lost 1-0 to Real Madrid, was delayed for 37 minutes and kicked off as security was still struggling with the flow of frustrated supporters into the Stade de France.UEFA claimed there were thousands of ticketless fans trying to gain access to the 80, 000 - plus capacity French national stadium but it did not identify where they were from.French Interior Minister Gérald Darmanin claimed stewards were assaulted by the supporters of the English side who forced entry without tickets or with counterfeit tickets.", 4, new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3195), 1, "1 min", "liverpool-fans-pepper-sprayed-by-french-police-in-stadium-entry-chaos", "Liverpool fans pepper-sprayed by French police in stadium entry chaos", 1, 1 },
                    { 4, "Europe's frantic search for alternatives to Russian energy has dramatically increased the demand — and price — for Norway's oil and gas.But the continent's second-biggest natural gas supplier is now fending off accusations that it is profiting from the war in Ukraine.Polish Prime Minister Mateusz Morawiecki, who is looking to the Scandinavian country to replace some of the gas Poland used to get from Russia, said Norway's 'gigantic' oil and gas profits are 'indirectly preying on the war'. He urged Norway to use that windfall to support the hardest-hit countries, mainly Ukraine.The comments last week touched a nerve, even as some Norwegians wonder whether they're doing enough to combat Kremlin's war by increasing economic aid to Ukraine and helping neighbouring countries end their dependence on Russian energy.", new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3196), "Europe's frantic search for alternatives to Russian energy has dramatically increased the demand — and price — for Norway's oil and gas.But the continent's second-biggest natural gas supplier is now fending off accusations that it is profiting from the war in Ukraine.Polish Prime Minister Mateusz Morawiecki, who is looking to the Scandinavian country to replace some of the gas Poland used to get from Russia, said Norway's 'gigantic' oil and gas profits are 'indirectly preying on the war'. He urged Norway to use that windfall to support the hardest-hit countries, mainly Ukraine.The comments last week touched a nerve, even as some Norwegians wonder whether they're doing enough to combat Kremlin's war by increasing economic aid to Ukraine and helping neighbouring countries end their dependence on Russian energy.", 2, new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3196), 1, "1 min", "norways-energy-sales-growth-spurs-accusations-of-profiting-from-war-demands-for-help", "Norway's energy sales growth spurs accusations of profiting from war, demands for help", 1, 1 },
                    { 5, "test content", new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3197), "test content", 1, new DateTime(2022, 5, 31, 13, 28, 7, 393, DateTimeKind.Utc).AddTicks(3198), 1, "1 min", "test-news", "Test news", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "PostTerms",
                columns: new[] { "Id", "PostId", "TermId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 2, 3 },
                    { 3, 1, 1 },
                    { 4, 1, 2 },
                    { 5, 3, 2 },
                    { 6, 4, 2 },
                    { 7, 4, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Files_FileExtensionId",
                schema: "file",
                table: "Files",
                column: "FileExtensionId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_UserId",
                schema: "file",
                table: "Files",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FileTerms_FileId",
                table: "FileTerms",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_FileTerms_TermId",
                table: "FileTerms",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_FileId",
                schema: "post",
                table: "Posts",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                schema: "post",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTerms_PostId",
                table: "PostTerms",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTerms_TermId",
                table: "PostTerms",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_Terms_UserId",
                schema: "term",
                table: "Terms",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserRoleId",
                schema: "user",
                table: "Users",
                column: "UserRoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileTerms");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "PostTerms");

            migrationBuilder.DropTable(
                name: "Posts",
                schema: "post");

            migrationBuilder.DropTable(
                name: "Terms",
                schema: "term");

            migrationBuilder.DropTable(
                name: "Files",
                schema: "file");

            migrationBuilder.DropTable(
                name: "FileExtensions");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "user");

            migrationBuilder.DropTable(
                name: "UserRoles");
        }
    }
}
