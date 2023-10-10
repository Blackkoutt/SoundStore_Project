using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projekt_.NET.Migrations
{
    /// <inheritdoc />
    public partial class new3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Rap & Hip-Hop" },
                    { 2, "Rap & Hip-Hop2" }
                });

            migrationBuilder.InsertData(
                table: "Performers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Travis Scott" },
                    { 2, "Juice WRLD" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sony Music Entertainment" },
                    { 2, "Universal Music Group" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
