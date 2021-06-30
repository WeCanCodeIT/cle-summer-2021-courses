using Microsoft.EntityFrameworkCore.Migrations;

namespace Courses.Migrations
{
    public partial class AddedProfilePics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePic",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePic",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePic",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ProfilePic",
                table: "Instructors");
        }
    }
}
