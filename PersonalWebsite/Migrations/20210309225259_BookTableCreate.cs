using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalWebsite.Migrations
{
    public partial class BookTableCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    PK_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(100)", nullable: false),
                    Author = table.Column<string>(type: "varchar(50)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "date", nullable: false),
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
