using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SFMvc.Migrations
{
    /// <inheritdoc />
    public partial class Populatingshowdatabase3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "LogoUrl" },
                values: new object[] { "parksandrecreation.jfif", "netflix.png" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "LogoUrl",
                value: "netflix.png");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "LogoUrl" },
                values: new object[] { "thelastofus.webp", "hbo.jfif" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "LogoUrl" },
                values: new object[] { "howtowithjohnwilson.avif", "hbo.jfif" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Format", "ImageUrl", "LogoUrl", "Title" },
                values: new object[] { "Beväpnad med bara ett ord - \"Tenet\" - reser protagonisten i en skuggvärld...", "Film", "tenet.jpg", "hbo.jfif", "Tenet" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "chernobyl.web");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "LogoUrl" },
                values: new object[] { "https://s2.dmcdn.net/v/UNvgl1ZRLtcvhWl5m/x480", "https://images.ctfassets.net/4cd45et68cgf/Rx83JoRDMkYNlMC9MKzcB/2b14d5a59fc3937afd3f03191e19502d/Netflix-Symbol.png?w=700&h=456" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "LogoUrl",
                value: "https://images.ctfassets.net/4cd45et68cgf/Rx83JoRDMkYNlMC9MKzcB/2b14d5a59fc3937afd3f03191e19502d/Netflix-Symbol.png?w=700&h=456");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "LogoUrl" },
                values: new object[] { "https://s2.dmcdn.net/v/UNvgl1ZRLtcvhWl5m/x480", "https://images.ctfassets.net/4cd45et68cgf/Rx83JoRDMkYNlMC9MKzcB/2b14d5a59fc3937afd3f03191e19502d/Netflix-Symbol.png?w=700&h=456" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "LogoUrl" },
                values: new object[] { "https://s2.dmcdn.net/v/UNvgl1ZRLtcvhWl5m/x480", "https://images.ctfassets.net/4cd45et68cgf/Rx83JoRDMkYNlMC9MKzcB/2b14d5a59fc3937afd3f03191e19502d/Netflix-Symbol.png?w=700&h=456" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Format", "ImageUrl", "LogoUrl", "Title" },
                values: new object[] { "In a uniquely hilarious odyssey of self-discovery and cultural observation", "Serie", "https://s2.dmcdn.net/v/UNvgl1ZRLtcvhWl5m/x480", "https://images.ctfassets.net/4cd45et68cgf/Rx83JoRDMkYNlMC9MKzcB/2b14d5a59fc3937afd3f03191e19502d/Netflix-Symbol.png?w=700&h=456", "How To with John Wilson" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://s2.dmcdn.net/v/UNvgl1ZRLtcvhWl5m/x480");
        }
    }
}
