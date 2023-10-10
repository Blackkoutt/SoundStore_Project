using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_.NET.Migrations
{
    /// <inheritdoc />
    public partial class new5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEGROUn/Hlp+S0pvdjgkHuIIUrQFySxsjRG3Tz1mg6qoCWK/F/K4PSotJvdEGWodWjw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEKMfYmvO8ZbqYiejeiLr+G0JY3+LSanMiPtDsP2IeJuFIxPltRKOsAx6tTPpsfdtmw==");
        }
    }
}
