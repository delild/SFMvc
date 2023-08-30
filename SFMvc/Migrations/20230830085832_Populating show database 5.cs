using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SFMvc.Migrations
{
    /// <inheritdoc />
    public partial class Populatingshowdatabase5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "LogoUrl",
                value: "disney.png");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "LogoUrl",
                value: "disney.png");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "LogoUrl",
                value: "disney.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "LogoUrl",
                value: "disney.jfif");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "LogoUrl",
                value: "disney.jfif");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "LogoUrl",
                value: "disney.jfif");
        }
    }
}
