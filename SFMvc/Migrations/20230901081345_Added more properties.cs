using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SFMvc.Migrations
{
    /// <inheritdoc />
    public partial class Addedmoreproperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LengthInMinutes",
                table: "Shows",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfEpisodes",
                table: "Shows",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfSeasons",
                table: "Shows",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Shows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LengthInMinutes", "NumberOfEpisodes", "NumberOfSeasons", "Year" },
                values: new object[] { null, 124, 7, 2009 });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LengthInMinutes", "NumberOfEpisodes", "NumberOfSeasons", "Year" },
                values: new object[] { null, 60, 5, 2016 });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LengthInMinutes", "NumberOfEpisodes", "NumberOfSeasons", "StreamingUrl", "Year" },
                values: new object[] { null, 10, 1, "https://www.hbomax.com/se/sv", 2023 });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LengthInMinutes", "NumberOfEpisodes", "NumberOfSeasons", "StreamingUrl", "Year" },
                values: new object[] { null, 18, 3, "https://www.hbomax.com/se/sv", 2020 });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LengthInMinutes", "NumberOfEpisodes", "NumberOfSeasons", "StreamingUrl", "Year" },
                values: new object[] { 150, null, null, "https://www.hbomax.com/se/sv", 2020 });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LengthInMinutes", "NumberOfEpisodes", "NumberOfSeasons", "StreamingUrl", "Year" },
                values: new object[] { null, 5, null, "https://www.hbomax.com/se/sv", 2019 });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LengthInMinutes", "NumberOfEpisodes", "NumberOfSeasons", "StreamingUrl", "Year" },
                values: new object[] { null, 18, 2, "https://www.disneyplus.com/en-se", 2022 });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "LengthInMinutes", "NumberOfEpisodes", "NumberOfSeasons", "StreamingUrl", "Year" },
                values: new object[] { 150, null, null, "https://www.disneyplus.com/en-se", 2023 });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "LengthInMinutes", "NumberOfEpisodes", "NumberOfSeasons", "StreamingUrl", "Year" },
                values: new object[] { 122, null, null, "https://www.disneyplus.com/en-se", 2014 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LengthInMinutes",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "NumberOfEpisodes",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "NumberOfSeasons",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Shows");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "StreamingUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "StreamingUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "StreamingUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "StreamingUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "StreamingUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "StreamingUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "StreamingUrl",
                value: null);
        }
    }
}
