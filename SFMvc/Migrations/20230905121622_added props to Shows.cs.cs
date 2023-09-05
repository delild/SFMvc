using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SFMvc.Migrations
{
    /// <inheritdoc />
    public partial class addedpropstoShowscs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.AddColumn<string>(
                name: "Cast",
                table: "Shows",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Creators",
                table: "Shows",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Shows",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genres",
                table: "Shows",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImdbLink",
                table: "Shows",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cast", "Creators", "Description", "Director", "Genres", "ImdbLink" },
                values: new object[] { "Amy Poehler, Jim O'Heir, Nick Offerman, Chris Pratt, Aubrey Plaza, Aziz Ansari, Retta, Rashida Jones, Adam Scott, Rob Lowe, Jay Jackson, Paul Schneider, Ben Schwartz, Mo Collins, Yvans Jourdain, Jon Glaser, Billy Eichner, James Greene", "Greg Daniels, Michael Schur", "Leslie Knope, a mid-level bureaucrat in an Indiana Parks and Recreation Department, hopes to beautify her town (and boost her own career) by helping local nurse Ann Perkins turn an abandoned construction site into a community park. However, what should be a fairly simple project is stymied at every turn by oafish bureaucrats, selfish neighbors, governmental red tape, and a myriad of other challenges. Leslie's colleague Tom Haverford, who delights in exploiting his position for personal gain, is as likely to undermine her efforts as to help her, while her boss, Ron Swanson, is adamantly opposed to government in any form, even though he's a bureaucrat.", null, "Comedy", "https://www.imdb.com/title/tt1266020/" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cast",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "Creators",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "Director",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "Genres",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "ImdbLink",
                table: "Shows");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Följ de offentliga tjänstemännen i staden Pawnee...");

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Description", "Format", "ImageUrl", "LengthInMinutes", "LogoUrl", "NumberOfEpisodes", "NumberOfSeasons", "StreamingUrl", "Title", "Year" },
                values: new object[,]
                {
                    { 2, "I detta drama skildras politiskt maktspel och romantik...", "Serie", "thecrown.jpg", null, "netflix.png", 60, 5, "https://www.netflix.com/se/", "The Crown", 2016 },
                    { 3, "20 år efter att ett muterat svampspor-virus förvandlat större delen av...", "Serie", "thelastofus.webp", null, "hbo.jfif", 10, 1, "https://www.hbomax.com/se/sv", "The Last of us", 2023 },
                    { 4, "In a uniquely hilarious odyssey of self-discovery and cultural observation", "Serie", "howtowithjohnwilson.jpg", null, "hbo.jfif", 18, 3, "https://www.hbomax.com/se/sv", "How To with John Wilson", 2020 },
                    { 5, "Beväpnad med bara ett ord - \"Tenet\" - reser protagonisten i en skuggvärld...", "Film", "tenet.jpg", 150, "hbo.jfif", null, null, "https://www.hbomax.com/se/sv", "Tenet", 2020 },
                    { 6, "En dramaserie från HBO i fem delar som följer händelserna kring kärnkraftsolyckan i Tjernobyl...", "Miniserie", "chernobyl.webp", null, "hbo.jfif", 5, null, "https://www.hbomax.com/se/sv", "Chernobyl", 2019 },
                    { 7, "Efter att hans bror har tagit livet av sig tar stjärnkocken Carmy...", "Serie", "thebear.webp", null, "disney.png", 18, 2, "https://www.disneyplus.com/en-se", "The Bear", 2022 },
                    { 8, "Peter Quill, som fortfarande sörjer förlusten av Gamora, måste ...", "Film", "guardiansvol3.jpg", 150, "disney.png", null, null, "https://www.disneyplus.com/en-se", "Guardians of the Galaxy Vol. 3", 2023 },
                    { 9, "Äventyraren Peter Quill stjäl en eftertraktad himlakropp från Ronan, s...", "Film", "guardians.jfif", 122, "disney.png", null, null, "https://www.disneyplus.com/en-se", "Guardians of the Galaxy", 2014 }
                });
        }
    }
}
