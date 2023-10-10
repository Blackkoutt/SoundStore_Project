using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projekt_.NET.Migrations
{
    /// <inheritdoc />
    public partial class new6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAECI4J0+GRyFS4lpvu51BKprBUWbbqqJRSCGPFI+a3iqz55NzqPs0MLB/hYbOFKEFSQ==");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 2, "AQAAAAIAAYagAAAAECJaf8AH+ljXgmB+KpvNANG0K0mqO7WxRPz2LRVNJOcSw20vVSYGxGunovySx1tLuA==", "user", "user" },
                    { 3, "AQAAAAIAAYagAAAAEPTexRyp7PcBbOi77O0IZRYyWp6gSa9GWU11tZqMuftwYmzMnNUC822KogT2/0AZpg==", "moderator", "moderator" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEGROUn/Hlp+S0pvdjgkHuIIUrQFySxsjRG3Tz1mg6qoCWK/F/K4PSotJvdEGWodWjw==");
        }
    }
}
