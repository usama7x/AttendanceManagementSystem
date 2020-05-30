using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AttendanceManagementSystem.Migrations
{
    public partial class introducednewcolumnStampinStudentEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Semester",
                table: "Students");

            migrationBuilder.AddColumn<DateTime>(
                name: "Stamp",
                table: "Students",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stamp",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "Semester",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
