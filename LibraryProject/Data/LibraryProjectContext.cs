using Microsoft.EntityFrameworkCore;
using LibraryProject.Data.Models;

namespace LibraryProject.Data
{
    public class LibraryProjectContext : DbContext
    {
        public LibraryProjectContext(DbContextOptions<LibraryProjectContext> options)
            : base(options)
        {

        }

        public DbSet<Book> Book { get; set; } = default!;

        public DbSet<CD>? CD { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book()
                {
                    id = 1,
                    title = "After She Left",
                    description = "Man gets pissed and goes into a rampage after his wife leaves him.",
                    coverImage = "after-she-left.jpg",
                    price = 15.99M,
                    Created = DateTime.Now,
                    author = "Felix Sanford",
                    ISBN = 9856471234L,
                    publishingYear = 2020,
                    genre = "Mystery, Thriller"
                },

                new Book()
                {
                    id = 2,
                    title = "Piece Of Light",
                    description = "Middle-aged woman embarks on a journey to rediscover her self-worth after having been in an abusive marriage for 15 years.",
                    coverImage = "piece-of-light.jpg",
                    price = 8.95M,
                    Created = DateTime.Now,
                    author = "Aurelia Hemmingway",
                    ISBN = 9658947231L,
                    publishingYear = 1998,
                    genre = "Self-Care, Guides"
                },

                new Book()
                {
                    id = 3,
                    title = "Springbook",
                    description = "A collection of cute short poems about the spring season.",
                    coverImage = "springbook.jpg",
                    price = 3.99M,
                    Created = DateTime.Now,
                    author = "Jeanine Guberman",
                    ISBN = 9856471234L,
                    publishingYear = 2022,
                    genre = "Poetry"
                },

                new Book()
                {
                    id = 4,
                    title = "Take Back Your Time",
                    description = "A guide to help you manage your time in a more efficient way.",
                    coverImage = "take-back-your-time.jpg",
                    price = 20.95M,
                    Created = DateTime.Now,
                    author = "John Smith II",
                    ISBN = 9635214987L,
                    publishingYear = 2005,
                    genre = "Guide, Help"
                },

                new Book()
                {
                    id = 5,
                    title = "The Girl Who Never",
                    description = "A book about Celia St. James, a reclusive 16-year-old girl who has had a very sheltered upbringing.",
                    coverImage = "the-girl-who-never.jpg",
                    price = 25.95M,
                    Created = DateTime.Now,
                    author = "Johanne Triston",
                    ISBN = 96587412365L,
                    publishingYear = 2007,
                    genre = "Fiction, Comtemporary"
                });

            modelBuilder.Entity<CD>().HasData(

                new CD()
                {
                    id = 1,
                    name = "Chroma",
                    singer = "Harry P. Diddy",
                    coverImage = "chroma.jpg",
                    price = 35.99M,
                    Created = DateTime.Now,
                    album = "Into The Void",
                    releaseYear = 1989
                },

                  new CD()
                  {
                      id = 2,
                      name = "Entheos",
                      singer = "Joss Moss",
                      coverImage = "entheos.jpg",
                      price = 39.95M,
                      Created = DateTime.Now,
                      album = "Here In the Woodlands",
                      releaseYear = 1997
                  },

                   new CD()
                   {
                       id = 3,
                       name = "Forbidden Sound",
                       singer = "Swool",
                       coverImage = "forbidden-sound.jpg",
                       price = 17.95M,
                       Created = DateTime.Now,
                       album = "Mayhem",
                       releaseYear = 2016
                   },

                    new CD()
                    {
                        id = 4,
                        name = "Summer of Love",
                        singer = "Love To",
                        coverImage = "summeroflove.png",
                        price = 24.95M,
                        Created = DateTime.Now,
                        album = "Lovers at Dawn",
                        releaseYear = 2022

                    }
             );
        }
    }
}