using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryProject.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "id", "Created", "ISBN", "author", "coverImage", "description", "genre", "price", "publishingYear", "title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 16, 10, 11, 34, 498, DateTimeKind.Local).AddTicks(7573), 9856471234L, "Felix Sanford", "after-she-left.jpg", "Man gets pissed and goes into a rampage after his wife leaves him.", "Mystery, Thriller", 15.99m, 2020, "After She Left" },
                    { 2, new DateTime(2023, 12, 16, 10, 11, 34, 498, DateTimeKind.Local).AddTicks(7583), 9658947231L, "Aurelia Hemmingway", "piece-of-light.jpg", "Middle-aged woman embarks on a journey to rediscover her self-worth after having been in an abusive marriage for 15 years.", "Self-Care, Guides", 8.95m, 1998, "Piece Of Light" },
                    { 3, new DateTime(2023, 12, 16, 10, 11, 34, 498, DateTimeKind.Local).AddTicks(7584), 9856471234L, "Jeanine Guberman", "springbook.jpg", "A collection of cute short poems about the spring season.", "Poetry", 3.99m, 2022, "Springbook" },
                    { 4, new DateTime(2023, 12, 16, 10, 11, 34, 498, DateTimeKind.Local).AddTicks(7586), 9635214987L, "John Smith II", "take-back-your-time.jpg", "A guide to help you manage your time in a more efficient way.", "Guide, Help", 20.95m, 2005, "Take Back Your Time" },
                    { 5, new DateTime(2023, 12, 16, 10, 11, 34, 498, DateTimeKind.Local).AddTicks(7586), 96587412365L, "Johanne Triston", "the-girl-who-never.jpg", "A book about Celia St. James, a reclusive 16-year-old girl who has had a very sheltered upbringing.", "Fiction, Comtemporary", 25.95m, 2007, "The Girl Who Never" }
                });

            migrationBuilder.InsertData(
                table: "CD",
                columns: new[] { "id", "Created", "album", "coverImage", "name", "price", "releaseYear", "singer" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 16, 10, 11, 34, 498, DateTimeKind.Local).AddTicks(7669), "Into The Void", "chroma.jpg", "Chroma", 35.99m, 1989, "Harry P. Diddy" },
                    { 2, new DateTime(2023, 12, 16, 10, 11, 34, 498, DateTimeKind.Local).AddTicks(7671), "Here In the Woodlands", "entheos.jpg", "Entheos", 39.95m, 1997, "Joss Moss" },
                    { 3, new DateTime(2023, 12, 16, 10, 11, 34, 498, DateTimeKind.Local).AddTicks(7672), "Mayhem", "forbidden-sound.jpg", "Forbidden Sound", 17.95m, 2016, "Swool" },
                    { 4, new DateTime(2023, 12, 16, 10, 11, 34, 498, DateTimeKind.Local).AddTicks(7673), "Lovers at Dawn", "summeroflove.png", "Summer of Love", 24.95m, 2022, "Love To" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CD",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CD",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CD",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CD",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
