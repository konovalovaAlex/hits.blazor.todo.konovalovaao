using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 1,
                column: "CratedDate",
                value: new DateTime(2024, 9, 23, 11, 49, 44, 881, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 2,
                column: "CratedDate",
                value: new DateTime(2024, 9, 23, 11, 49, 44, 881, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 3,
                column: "CratedDate",
                value: new DateTime(2024, 9, 23, 11, 49, 44, 881, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 4,
                column: "CratedDate",
                value: new DateTime(2024, 9, 23, 11, 49, 44, 881, DateTimeKind.Local).AddTicks(5202));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 1,
                column: "CratedDate",
                value: new DateTime(2024, 9, 16, 22, 55, 42, 167, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 2,
                column: "CratedDate",
                value: new DateTime(2024, 9, 16, 22, 55, 42, 167, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 3,
                column: "CratedDate",
                value: new DateTime(2024, 9, 16, 22, 55, 42, 167, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "ID",
                keyValue: 4,
                column: "CratedDate",
                value: new DateTime(2024, 9, 16, 22, 55, 42, 167, DateTimeKind.Local).AddTicks(8544));
        }
    }
}
