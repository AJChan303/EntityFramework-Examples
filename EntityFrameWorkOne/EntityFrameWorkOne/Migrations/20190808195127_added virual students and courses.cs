using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameWorkOne.Migrations
{
    public partial class addedvirualstudentsandcourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                table: "Schedules",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                table: "Schedules",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
