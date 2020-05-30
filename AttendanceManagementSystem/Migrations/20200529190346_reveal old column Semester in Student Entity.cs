using Microsoft.EntityFrameworkCore.Migrations;

namespace AttendanceManagementSystem.Migrations
{
    public partial class revealoldcolumnSemesterinStudentEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Semester",
                table: "Students",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Semester",
                table: "Students");
        }
    }
}
