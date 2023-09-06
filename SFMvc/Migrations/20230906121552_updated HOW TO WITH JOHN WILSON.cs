using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SFMvc.Migrations
{
    /// <inheritdoc />
    public partial class updatedHOWTOWITHJOHNWILSON : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Creators", "Director" },
                values: new object[] { "John Wilson", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Creators", "Director" },
                values: new object[] { null, "John Wilson" });
        }
    }
}
