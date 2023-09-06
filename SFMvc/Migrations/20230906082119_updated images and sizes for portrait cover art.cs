using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SFMvc.Migrations
{
    /// <inheritdoc />
    public partial class updatedimagesandsizesforportraitcoverart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "howtowithjohnwilson2.jpg");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "barbie2.webp");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "the-dark-knight2.jpg");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "interstellar2.jpg");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "only-murders2.jpg");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "attack-on-titan2.jpg");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "the-office2.jpg");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "scrubs2.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "howtowithjohnwilson.jpg");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "barbie.jpg");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "the-dark-knight.jpg");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "interstellar.jpg");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "only-murders.jpg");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "attack-on-titan.jpg");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "the-office.jpg");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "scrubs.jpg");
        }
    }
}
