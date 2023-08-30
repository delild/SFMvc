using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SFMvc.Migrations
{
    /// <inheritdoc />
    public partial class Populatingshowdatabase4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "thecrown.jpg");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "howtowithjohnwilson.jpg");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "chernobyl.webp");

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Description", "Format", "ImageUrl", "LogoUrl", "Title" },
                values: new object[,]
                {
                    { 7, "Efter att hans bror har tagit livet av sig tar stjärnkocken Carmy...", "Serie", "thebear.webp", "disney.jfif", "The Bear" },
                    { 8, "Peter Quill, som fortfarande sörjer förlusten av Gamora, måste ...", "Film", "guardiansvol3.jpg", "disney.jfif", "Guardians of the Galaxy Vol. 3" },
                    { 9, "Äventyraren Peter Quill stjäl en eftertraktad himlakropp från Ronan, s...", "Film", "guardians.jfif", "disney.jfif", "Guardians of the Galaxy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://s2.dmcdn.net/v/UNvgl1ZRLtcvhWl5m/x480");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "howtowithjohnwilson.avif");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "chernobyl.web");
        }
    }
}
