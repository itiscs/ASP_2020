using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoApp.Migrations
{
    public partial class AddAverageMarkStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AverageMark",
                table: "Student",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageMark",
                table: "Student");
        }
    }
}
