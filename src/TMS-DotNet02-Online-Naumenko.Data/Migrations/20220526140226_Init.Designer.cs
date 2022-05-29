﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TMS_DotNet02_Online_Naumenko.Data.Contexts.MainContext;

#nullable disable

namespace TMS_DotNet02_Online_Naumenko.Data.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20220526140226_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("FileExtensionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FileExtensionId");

                    b.HasIndex("UserId");

                    b.ToTable("Files", "file");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.FileExtension", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FileExtensions");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.FileTerm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FileId")
                        .HasColumnType("int");

                    b.Property<int>("TermId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FileId");

                    b.HasIndex("TermId");

                    b.ToTable("FileTerms");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Excerpt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FileId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostStatusId")
                        .HasColumnType("int");

                    b.Property<string>("ReadingTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FileId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts", "post");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.PostTerm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("TermId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("TermId");

                    b.ToTable("PostTerms");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.Term", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Parent")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TermTypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Terms", "term");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserRoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserRoleId");

                    b.ToTable("Users", "user");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.File", b =>
                {
                    b.HasOne("TMS_DotNet02_Online_Naumenko.Data.Models.FileExtension", "FileExtension")
                        .WithMany("Files")
                        .HasForeignKey("FileExtensionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TMS_DotNet02_Online_Naumenko.Data.Models.User", "User")
                        .WithMany("Files")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FileExtension");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.FileTerm", b =>
                {
                    b.HasOne("TMS_DotNet02_Online_Naumenko.Data.Models.File", "File")
                        .WithMany("FileTerms")
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TMS_DotNet02_Online_Naumenko.Data.Models.Term", "Term")
                        .WithMany("FileTerms")
                        .HasForeignKey("TermId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("File");

                    b.Navigation("Term");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.Post", b =>
                {
                    b.HasOne("TMS_DotNet02_Online_Naumenko.Data.Models.File", "File")
                        .WithMany("Posts")
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TMS_DotNet02_Online_Naumenko.Data.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("File");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.PostTerm", b =>
                {
                    b.HasOne("TMS_DotNet02_Online_Naumenko.Data.Models.Post", "Post")
                        .WithMany("PostTerms")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TMS_DotNet02_Online_Naumenko.Data.Models.Term", "Term")
                        .WithMany("PostTerms")
                        .HasForeignKey("TermId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Term");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.Term", b =>
                {
                    b.HasOne("TMS_DotNet02_Online_Naumenko.Data.Models.User", "User")
                        .WithMany("Terms")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.User", b =>
                {
                    b.HasOne("TMS_DotNet02_Online_Naumenko.Data.Models.UserRole", "UserRole")
                        .WithMany("Users")
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.File", b =>
                {
                    b.Navigation("FileTerms");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.FileExtension", b =>
                {
                    b.Navigation("Files");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.Post", b =>
                {
                    b.Navigation("PostTerms");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.Term", b =>
                {
                    b.Navigation("FileTerms");

                    b.Navigation("PostTerms");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.User", b =>
                {
                    b.Navigation("Files");

                    b.Navigation("Posts");

                    b.Navigation("Terms");
                });

            modelBuilder.Entity("TMS_DotNet02_Online_Naumenko.Data.Models.UserRole", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}