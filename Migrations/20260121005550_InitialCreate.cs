using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArtArchive.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artworks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Artist = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Medium = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IssuingAuthority = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artworks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "Id", "Artist", "CreatedAt", "IssuingAuthority", "Medium", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Vincent van Gogh", new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Art Archive & Provenance Ltd.", "Oil on canvas", "Starry Night", 1889 },
                    { 2, "Gustav Klimt", new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Art Archive & Provenance Ltd.", "Oil and gold leaf on canvas", "This Kiss", 1908 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artworks");
        }
    }
}
