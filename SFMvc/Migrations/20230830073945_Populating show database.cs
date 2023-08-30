using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SFMvc.Migrations
{
    /// <inheritdoc />
    public partial class Populatingshowdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Description", "Format", "ImageUrl", "LogoUrl", "Title" },
                values: new object[,]
                {
                    { 4, "In a uniquely hilarious odyssey of self-discovery and cultural observation", "Serie", "https://s2.dmcdn.net/v/UNvgl1ZRLtcvhWl5m/x480", "https://images.ctfassets.net/4cd45et68cgf/Rx83JoRDMkYNlMC9MKzcB/2b14d5a59fc3937afd3f03191e19502d/Netflix-Symbol.png?w=700&h=456", "How To with John Wilson" },
                    { 5, "In a uniquely hilarious odyssey of self-discovery and cultural observation", "Serie", "https://s2.dmcdn.net/v/UNvgl1ZRLtcvhWl5m/x480", "https://images.ctfassets.net/4cd45et68cgf/Rx83JoRDMkYNlMC9MKzcB/2b14d5a59fc3937afd3f03191e19502d/Netflix-Symbol.png?w=700&h=456", "How To with John Wilson" },
                    { 6, "En dramaserie från HBO i fem delar som följer händelserna kring kärnkraftsolyckan i Tjernobyl...", "Miniserie", "https://s2.dmcdn.net/v/UNvgl1ZRLtcvhWl5m/x480", "/wwwroot/Images/hbo.jfif", "Chernobyl" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
