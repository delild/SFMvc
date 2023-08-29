using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SFMvc.Migrations
{
    /// <inheritdoc />
    public partial class PopulatedShows : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Description", "Format", "ImageUrl", "LogoUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Följ de offentliga tjänstemännen i staden Pawnee...", "Serie", "https://s2.dmcdn.net/v/UNvgl1ZRLtcvhWl5m/x480", "https://images.ctfassets.net/4cd45et68cgf/Rx83JoRDMkYNlMC9MKzcB/2b14d5a59fc3937afd3f03191e19502d/Netflix-Symbol.png?w=700&h=456", "Parks and Recreation" },
                    { 2, "I detta drama skildras politiskt maktspel och romantik...", "Serie", "https://s2.dmcdn.net/v/UNvgl1ZRLtcvhWl5m/x480", "https://images.ctfassets.net/4cd45et68cgf/Rx83JoRDMkYNlMC9MKzcB/2b14d5a59fc3937afd3f03191e19502d/Netflix-Symbol.png?w=700&h=456", "The Crown" },
                    { 3, "20 år efter att ett muterat svampspor-virus förvandlat större delen av...", "Serie", "https://s2.dmcdn.net/v/UNvgl1ZRLtcvhWl5m/x480", "https://images.ctfassets.net/4cd45et68cgf/Rx83JoRDMkYNlMC9MKzcB/2b14d5a59fc3937afd3f03191e19502d/Netflix-Symbol.png?w=700&h=456", "The Last of us" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
