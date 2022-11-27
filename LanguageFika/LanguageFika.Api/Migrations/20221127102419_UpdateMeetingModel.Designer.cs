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
    [Migration("20221127102419_UpdateMeetingModel")]
    partial class UpdateMeetingModel
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
                            Id = new Guid("0a689097-ea4d-40a0-a70f-e725347ac579"),
                            Date = new DateTime(2022, 12, 10, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 1",
                            Language = "Finnish",
                            Location = "Test location 1"
                        },
                        new
                        {
                            Id = new Guid("1f6dbe0c-83f1-4228-b6a9-22c2db668c34"),
                            Date = new DateTime(2022, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 2",
                            Language = "Chinese",
                            Location = "Test location 2"
                        },
                        new
                        {
                            Id = new Guid("42d29ec1-d9e1-4b29-b08e-a694b4fcd697"),
                            Date = new DateTime(2022, 12, 12, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 3",
                            Language = "Japanese",
                            Location = "Test location 3"
                        },
                        new
                        {
                            Id = new Guid("5244ab65-0976-4ac8-968b-d9fad513759e"),
                            Date = new DateTime(2022, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 4",
                            Language = "Portuguese",
                            Location = "Test location 4"
                        },
                        new
                        {
                            Id = new Guid("01c083f1-1896-4ec8-9459-fb12cffc8057"),
                            Date = new DateTime(2022, 12, 14, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 5",
                            Language = "Swedish",
                            Location = "Test location 5"
                        },
                        new
                        {
                            Id = new Guid("44210c4f-c375-4e1c-a883-36583bd6f4c8"),
                            Date = new DateTime(2022, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 6",
                            Language = "English",
                            Location = "Test location 6"
                        },
                        new
                        {
                            Id = new Guid("79979c24-854c-4923-a065-ce21aece4c99"),
                            Date = new DateTime(2022, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 7",
                            Language = "French",
                            Location = "Test location 7"
                        },
                        new
                        {
                            Id = new Guid("912b6ab7-be67-40d8-8559-4f4802635c60"),
                            Date = new DateTime(2022, 12, 17, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 8",
                            Language = "German",
                            Location = "Test location 8"
                        },
                        new
                        {
                            Id = new Guid("456a23b3-8cb6-435f-a1a3-1d4058c5d40c"),
                            Date = new DateTime(2022, 12, 18, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 9",
                            Language = "Swedish",
                            Location = "Test location 9"
                        },
                        new
                        {
                            Id = new Guid("ef50eb82-ef19-4d6a-b327-bc2273f0c4f4"),
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

                    b.ToTable("Participant");
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
