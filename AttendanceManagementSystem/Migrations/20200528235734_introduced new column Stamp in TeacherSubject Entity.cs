using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AttendanceManagementSystem.Migrations
{
    public partial class introducednewcolumnStampinTeacherSubjectEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Stamp",
                table: "TeacherSubject",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stamp",
                table: "TeacherSubject");
        }
    }
}
