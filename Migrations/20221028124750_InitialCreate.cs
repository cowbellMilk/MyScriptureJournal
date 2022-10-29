using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyScriptureJournal.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scripture",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Book = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Chapter = table.Column<int>(type: "INTEGER", nullable: false),
                    Verses = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Notes = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scripture", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scripture");
        }
    }
}
