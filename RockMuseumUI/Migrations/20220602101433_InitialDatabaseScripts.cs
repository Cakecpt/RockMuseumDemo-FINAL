using System;
using Microsoft.EntityFrameworkCore.Migrations;
// SEBASTIAN
namespace RockMuseumUI.Migrations
{
    public partial class InitialDatabaseScripts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExhibitionCollection",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Length = table.Column<int>(nullable: false),
                    Releasedate = table.Column<DateTime>(nullable: false),
                    Rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExhibitionCollection", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExhibitionCollection");
        }
    }
}
