﻿// <auto-generated />
using System;
using LibraryProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryProject.Migrations
{
    [DbContext(typeof(LibraryProjectContext))]
    partial class LibraryProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LibraryProject.Data.Models.Book", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<long>("ISBN")
                        .HasColumnType("bigint");

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("coverImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("publishingYear")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Created = new DateTime(2023, 12, 16, 10, 33, 14, 472, DateTimeKind.Local).AddTicks(826),
                            ISBN = 9856471234L,
                            author = "Felix Sanford",
                            coverImage = "after-she-left.jpg",
                            description = "Man gets pissed and goes into a rampage after his wife leaves him.",
                            genre = "Mystery, Thriller",
                            price = 15.99m,
                            publishingYear = 2020,
                            title = "After She Left"
                        },
                        new
                        {
                            id = 2,
                            Created = new DateTime(2023, 12, 16, 10, 33, 14, 472, DateTimeKind.Local).AddTicks(835),
                            ISBN = 9658947231L,
                            author = "Aurelia Hemmingway",
                            coverImage = "piece-of-light.jpg",
                            description = "Middle-aged woman embarks on a journey to rediscover her self-worth after having been in an abusive marriage for 15 years.",
                            genre = "Self-Care, Guides",
                            price = 8.95m,
                            publishingYear = 1998,
                            title = "Piece Of Light"
                        },
                        new
                        {
                            id = 3,
                            Created = new DateTime(2023, 12, 16, 10, 33, 14, 472, DateTimeKind.Local).AddTicks(837),
                            ISBN = 9856471234L,
                            author = "Jeanine Guberman",
                            coverImage = "springbook.jpg",
                            description = "A collection of cute short poems about the spring season.",
                            genre = "Poetry",
                            price = 3.99m,
                            publishingYear = 2022,
                            title = "Springbook"
                        },
                        new
                        {
                            id = 4,
                            Created = new DateTime(2023, 12, 16, 10, 33, 14, 472, DateTimeKind.Local).AddTicks(837),
                            ISBN = 9635214987L,
                            author = "John Smith II",
                            coverImage = "take-back-your-time.jpg",
                            description = "A guide to help you manage your time in a more efficient way.",
                            genre = "Guide, Help",
                            price = 20.95m,
                            publishingYear = 2005,
                            title = "Take Back Your Time"
                        },
                        new
                        {
                            id = 5,
                            Created = new DateTime(2023, 12, 16, 10, 33, 14, 472, DateTimeKind.Local).AddTicks(838),
                            ISBN = 96587412365L,
                            author = "Johanne Triston",
                            coverImage = "the-girl-who-never.jpg",
                            description = "A book about Celia St. James, a reclusive 16-year-old girl who has had a very sheltered upbringing.",
                            genre = "Fiction, Comtemporary",
                            price = 25.95m,
                            publishingYear = 2007,
                            title = "The Girl Who Never"
                        });
                });

            modelBuilder.Entity("LibraryProject.Data.Models.CD", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("album")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("coverImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("releaseYear")
                        .HasColumnType("int");

                    b.Property<string>("singer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("CD");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Created = new DateTime(2023, 12, 16, 10, 33, 14, 472, DateTimeKind.Local).AddTicks(949),
                            album = "Into The Void",
                            coverImage = "chroma.jpg",
                            name = "Chroma",
                            price = 35.99m,
                            releaseYear = 1989,
                            singer = "Harry P. Diddy"
                        },
                        new
                        {
                            id = 2,
                            Created = new DateTime(2023, 12, 16, 10, 33, 14, 472, DateTimeKind.Local).AddTicks(950),
                            album = "Here In the Woodlands",
                            coverImage = "entheos.jpg",
                            name = "Entheos",
                            price = 39.95m,
                            releaseYear = 1997,
                            singer = "Joss Moss"
                        },
                        new
                        {
                            id = 3,
                            Created = new DateTime(2023, 12, 16, 10, 33, 14, 472, DateTimeKind.Local).AddTicks(951),
                            album = "Mayhem",
                            coverImage = "forbidden-sound.jpg",
                            name = "Forbidden Sound",
                            price = 17.95m,
                            releaseYear = 2016,
                            singer = "Swool"
                        },
                        new
                        {
                            id = 4,
                            Created = new DateTime(2023, 12, 16, 10, 33, 14, 472, DateTimeKind.Local).AddTicks(952),
                            album = "Lovers at Dawn",
                            coverImage = "summeroflove.png",
                            name = "Summer of Love",
                            price = 24.95m,
                            releaseYear = 2022,
                            singer = "Love To"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
