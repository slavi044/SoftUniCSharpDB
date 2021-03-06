﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MySocialMediaDB.Data;

namespace MySocialMediaDB.Migrations
{
    [DbContext(typeof(MySocialMediaDbContext))]
    [Migration("20201029233152_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MySocialMediaDB.Data.Models.Comment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<string>("PostId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("MySocialMediaDB.Data.Models.Country", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("MySocialMediaDB.Data.Models.CoverPhoto", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Picture")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("CoverPhoto");
                });

            modelBuilder.Entity("MySocialMediaDB.Data.Models.Page", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CoverPhotoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CoverPhotoId");

                    b.HasIndex("UserId");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("MySocialMediaDB.Data.Models.Photo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("PageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("Picture")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PageId");

                    b.HasIndex("UserId");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("MySocialMediaDB.Data.Models.Post", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<string>("PageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PhotoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PageId");

                    b.HasIndex("PhotoId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("MySocialMediaDB.Data.Models.ProfilePicture", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Picture")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("ProfilePictures");
                });

            modelBuilder.Entity("MySocialMediaDB.Data.Models.Reply", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CommentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CommentId");

                    b.ToTable("Replies");
                });

            modelBuilder.Entity("MySocialMediaDB.Data.Models.Town", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TownName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("MySocialMediaDB.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CountryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CoverPhotoId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CretedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("PageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilPictureId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("TownId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("PageId");

                    b.HasIndex("TownId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MySocialMediaDB.Data.Models.Comment", b =>
                {
                    b.HasOne("MySocialMediaDB.Data.Models.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MySocialMediaDB.Data.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("MySocialMediaDB.Data.Models.CoverPhoto", b =>
                {
                    b.HasOne("MySocialMediaDB.Data.Models.User", "User")
                        .WithOne("CoverPhoto")
                        .HasForeignKey("MySocialMediaDB.Data.Models.CoverPhoto", "UserId");
                });

            modelBuilder.Entity("MySocialMediaDB.Data.Models.Page", b =>
                {
                    b.HasOne("MySocialMediaDB.Data.Models.CoverPhoto", "CoverPhoto")
                        .WithMany()
                        .HasForeignKey("CoverPhotoId");

                    b.HasOne("MySocialMediaDB.Data.Models.User", "User")
                        .WithMany("Pages")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MySocialMediaDB.Data.Models.Photo", b =>
                {
                    b.HasOne("MySocialMediaDB.Data.Models.Page", "Page")
                        .WithMany("Photos")
                        .HasForeignKey("PageId");

                    b.HasOne("MySocialMediaDB.Data.Models.User", "User")
                        .WithMany("Photos")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MySocialMediaDB.Data.Models.Post", b =>
                {
                    b.HasOne("MySocialMediaDB.Data.Models.User", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MySocialMediaDB.Data.Models.Page", null)
                        .WithMany("Posts")
                        .HasForeignKey("PageId");

                    b.HasOne("MySocialMediaDB.Data.Models.Photo", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId");
                });

            modelBuilder.Entity("MySocialMediaDB.Data.Models.ProfilePicture", b =>
                {
                    b.HasOne("MySocialMediaDB.Data.Models.User", "User")
                        .WithOne("ProfilePicture")
                        .HasForeignKey("MySocialMediaDB.Data.Models.ProfilePicture", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MySocialMediaDB.Data.Models.Reply", b =>
                {
                    b.HasOne("MySocialMediaDB.Data.Models.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MySocialMediaDB.Data.Models.Comment", null)
                        .WithMany("Replies")
                        .HasForeignKey("CommentId");
                });

            modelBuilder.Entity("MySocialMediaDB.Data.Models.User", b =>
                {
                    b.HasOne("MySocialMediaDB.Data.Models.Country", "Country")
                        .WithMany("Users")
                        .HasForeignKey("CountryId");

                    b.HasOne("MySocialMediaDB.Data.Models.Page", null)
                        .WithMany("Followers")
                        .HasForeignKey("PageId");

                    b.HasOne("MySocialMediaDB.Data.Models.Town", "Town")
                        .WithMany("Users")
                        .HasForeignKey("TownId");
                });
#pragma warning restore 612, 618
        }
    }
}
