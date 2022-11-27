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
    [Migration("20221127113130_UpdateMeetingModel5")]
    partial class UpdateMeetingModel5
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
                            Id = new Guid("00373933-d97b-4f8d-b2c1-2b81133bfe34"),
                            Date = new DateTime(2022, 12, 10, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 1",
                            Language = "Finnish",
                            Location = "Test location 1"
                        },
                        new
                        {
                            Id = new Guid("cf818dcd-082c-4ac9-8a5f-be7a3ffe16a8"),
                            Date = new DateTime(2022, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 2",
                            Language = "Chinese",
                            Location = "Test location 2"
                        },
                        new
                        {
                            Id = new Guid("8905383a-86c0-487d-b6b2-292cd3dcba25"),
                            Date = new DateTime(2022, 12, 12, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 3",
                            Language = "Japanese",
                            Location = "Test location 3"
                        },
                        new
                        {
                            Id = new Guid("63956d05-ffb8-4f01-95e0-288ffda024fb"),
                            Date = new DateTime(2022, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 4",
                            Language = "Portuguese",
                            Location = "Test location 4"
                        },
                        new
                        {
                            Id = new Guid("ea67bf50-58dd-4df0-9095-0579e47e646d"),
                            Date = new DateTime(2022, 12, 14, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 5",
                            Language = "Swedish",
                            Location = "Test location 5"
                        },
                        new
                        {
                            Id = new Guid("92a086ba-1518-4b02-9c3c-9fae47f77199"),
                            Date = new DateTime(2022, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 6",
                            Language = "English",
                            Location = "Test location 6"
                        },
                        new
                        {
                            Id = new Guid("29463ac6-8b84-41ba-a2fd-48f8ea29b89b"),
                            Date = new DateTime(2022, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 7",
                            Language = "French",
                            Location = "Test location 7"
                        },
                        new
                        {
                            Id = new Guid("0db9f314-4d8a-41d2-959e-3c65ba708317"),
                            Date = new DateTime(2022, 12, 17, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 8",
                            Language = "German",
                            Location = "Test location 8"
                        },
                        new
                        {
                            Id = new Guid("f4d78e58-b43e-401a-b1ca-4f90568c5f84"),
                            Date = new DateTime(2022, 12, 18, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 9",
                            Language = "Swedish",
                            Location = "Test location 9"
                        },
                        new
                        {
                            Id = new Guid("ee4b5c20-39b0-49e2-b76f-3a0a5d9ed52d"),
                            Date = new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 10",
                            Language = "Greek",
                            Location = "Test location 10"
                        });
                });

            modelBuilder.Entity("LanguageFika.Api.Models.Participant", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("MeetingId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MeetingId");

                    b.ToTable("Participants");
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

            modelBuilder.Entity("LanguageFika.Api.Models.Participant", b =>
                {
                    b.HasOne("LanguageFika.Api.Models.Meeting", null)
                        .WithMany("Participants")
                        .HasForeignKey("MeetingId");
                });

            modelBuilder.Entity("LanguageFika.Api.Models.Meeting", b =>
                {
                    b.Navigation("Participants");
                });
#pragma warning restore 612, 618
        }
    }
}
