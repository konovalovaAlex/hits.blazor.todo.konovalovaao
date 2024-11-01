using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class add_taskitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CratedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FInishdDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "TaskItems",
                columns: new[] { "ID", "CratedDate", "Description", "FInishdDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 16, 22, 55, 42, 167, DateTimeKind.Local).AddTicks(8530), "Описание задачи 1", null, "Задание 1" },
                    { 2, new DateTime(2024, 9, 16, 22, 55, 42, 167, DateTimeKind.Local).AddTicks(8541), "Описание задачи 2", null, "Задание 2" },
                    { 3, new DateTime(2024, 9, 16, 22, 55, 42, 167, DateTimeKind.Local).AddTicks(8543), "Описание задачи 3", null, "Задание 3" },
                    { 4, new DateTime(2024, 9, 16, 22, 55, 42, 167, DateTimeKind.Local).AddTicks(8544), "Описание задачи 4", null, "Задание 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskItems");
        }
    }
}
