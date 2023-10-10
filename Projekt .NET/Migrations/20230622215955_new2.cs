using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projekt_.NET.Migrations
{
    /// <inheritdoc />
    public partial class new2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Distributors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sony Music Entertainment" },
                    { 2, "Universal Music Polska" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Distributors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Distributors",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
