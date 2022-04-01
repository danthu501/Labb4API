using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb4API.Migrations
{
    public partial class RemovedPeopleIntInInterest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "People",
                table: "Interests");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "People",
                table: "Interests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
