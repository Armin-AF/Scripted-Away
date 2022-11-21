﻿// <auto-generated />
using System;
using LanguageFika.Api.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LanguageFika.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221121094159_UpdateLang")]
    partial class UpdateLang
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LanguageFika.Api.Models.Meeting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Meetings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f0742dbc-2714-42ec-af34-a510f3c8af3a"),
                            Date = new DateTime(2022, 12, 10, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 1",
                            Language = "French",
                            Location = "Test location 1"
                        },
                        new
                        {
                            Id = new Guid("de3ff426-b836-457c-9fa5-6739f6a45dd4"),
                            Date = new DateTime(2022, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 2",
                            Language = "English",
                            Location = "Test location 2"
                        },
                        new
                        {
                            Id = new Guid("22bfc63b-0c98-42a7-8a2a-82a49761bc65"),
                            Date = new DateTime(2022, 12, 12, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 3",
                            Language = "Spanish",
                            Location = "Test location 3"
                        },
                        new
                        {
                            Id = new Guid("8aaae329-09e8-44e0-98bd-e9cb796bebd2"),
                            Date = new DateTime(2022, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 4",
                            Language = "German",
                            Location = "Test location 4"
                        },
                        new
                        {
                            Id = new Guid("9884b342-9bc3-4ec5-a159-923d12036a51"),
                            Date = new DateTime(2022, 12, 14, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 5",
                            Language = "French",
                            Location = "Test location 5"
                        },
                        new
                        {
                            Id = new Guid("ce3e4836-e5e2-4534-a8e8-2332c072527b"),
                            Date = new DateTime(2022, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 6",
                            Language = "Swedish",
                            Location = "Test location 6"
                        },
                        new
                        {
                            Id = new Guid("edf0a9f3-e9fc-43db-a478-f43d95c99915"),
                            Date = new DateTime(2022, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 7",
                            Language = "Spanish",
                            Location = "Test location 7"
                        },
                        new
                        {
                            Id = new Guid("9f3ad127-79ef-4d9d-a268-497994795f2a"),
                            Date = new DateTime(2022, 12, 17, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 8",
                            Language = "German",
                            Location = "Test location 8"
                        },
                        new
                        {
                            Id = new Guid("7b571aec-bd4a-40f7-887b-db2d4fea6a5e"),
                            Date = new DateTime(2022, 12, 18, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 9",
                            Language = "French",
                            Location = "Test location 9"
                        },
                        new
                        {
                            Id = new Guid("ca4aab6e-6738-4cef-b46e-3b15a9fd18cf"),
                            Date = new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 10",
                            Language = "Swedish",
                            Location = "Test location 10"
                        });
                });

            modelBuilder.Entity("LanguageFika.Api.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageToLearn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageToTeach")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
