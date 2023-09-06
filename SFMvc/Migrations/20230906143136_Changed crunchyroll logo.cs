using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SFMvc.Migrations
{
    /// <inheritdoc />
    public partial class Changedcrunchyrolllogo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                column: "LogoUrl",
                value: "Crunchyroll_logo_2.png");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "LogoUrl",
                value: "Crunchyroll_logo_2.png");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "LogoUrl",
                value: "Crunchyroll_logo_2.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                column: "LogoUrl",
                value: "crunchyroll-logo.png");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "LogoUrl",
                value: "crunchyroll-logo.png");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "LogoUrl",
                value: "crunchyroll-logo.png");
        }
    }
}
