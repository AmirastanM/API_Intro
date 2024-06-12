using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Intro_HomeTask.Migrations
{
    public partial class createdBookCategorytables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categpries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categpries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CreatedDate", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 13, 0, 50, 53, 307, DateTimeKind.Local).AddTicks(748), "Harry Potter", 121m },
                    { 2, new DateTime(2024, 6, 13, 0, 50, 53, 307, DateTimeKind.Local).AddTicks(752), "Don Quixote", 140m },
                    { 3, new DateTime(2024, 6, 13, 0, 50, 53, 307, DateTimeKind.Local).AddTicks(754), "In Search of Lost Time", 180m }
                });

            migrationBuilder.InsertData(
                table: "Categpries",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 13, 0, 50, 53, 307, DateTimeKind.Local).AddTicks(648), "UI UX" },
                    { 2, new DateTime(2024, 6, 13, 0, 50, 53, 307, DateTimeKind.Local).AddTicks(650), "Backend" },
                    { 3, new DateTime(2024, 6, 13, 0, 50, 53, 307, DateTimeKind.Local).AddTicks(651), "Frontend" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categpries");
        }
    }
}
