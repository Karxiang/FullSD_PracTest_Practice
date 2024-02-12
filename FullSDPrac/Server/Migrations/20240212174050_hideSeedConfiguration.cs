using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullSDPrac.Server.Migrations
{
    /// <inheritdoc />
    public partial class hideSeedConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "TaskName",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaskName",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "TaskItems",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DueDate", "IsCompleted", "TaskName", "UsersId" },
                values: new object[] { 1, "James", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Shower", null });
        }
    }
}
