using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalWebsite.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    PK_Id = table.Column<short>(type: "smallint", nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", nullable: true),
                    Author = table.Column<string>(type: "varchar(50)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Genre = table.Column<string>(type: "varchar(50)", nullable: true),
                    Series = table.Column<string>(type: "varchar(100)", nullable: true),
                    WikipediaLink = table.Column<string>(type: "varchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Id", x => x.PK_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
