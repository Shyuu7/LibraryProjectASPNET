using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryProject.Migrations
{
    public partial class changingImageCoverPropriety : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "coverImage",
                table: "CD",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "coverImage",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 12, 16, 10, 33, 14, 472, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 12, 16, 10, 33, 14, 472, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 12, 16, 10, 33, 14, 472, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 12, 16, 10, 33, 14, 472, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 12, 16, 10, 33, 14, 472, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "CD",
                keyColumn: "id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 12, 16, 10, 33, 14, 472, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "CD",
                keyColumn: "id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 12, 16, 10, 33, 14, 472, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "CD",
                keyColumn: "id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 12, 16, 10, 33, 14, 472, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "CD",
                keyColumn: "id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 12, 16, 10, 33, 14, 472, DateTimeKind.Local).AddTicks(952));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "coverImage",
                table: "CD",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "coverImage",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 12, 16, 10, 11, 34, 498, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 12, 16, 10, 11, 34, 498, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 12, 16, 10, 11, 34, 498, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 12, 16, 10, 11, 34, 498, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 12, 16, 10, 11, 34, 498, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "CD",
                keyColumn: "id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 12, 16, 10, 11, 34, 498, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "CD",
                keyColumn: "id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 12, 16, 10, 11, 34, 498, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "CD",
                keyColumn: "id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 12, 16, 10, 11, 34, 498, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "CD",
                keyColumn: "id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 12, 16, 10, 11, 34, 498, DateTimeKind.Local).AddTicks(7673));
        }
    }
}
