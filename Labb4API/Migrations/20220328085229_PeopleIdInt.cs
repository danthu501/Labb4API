using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb4API.Migrations
{
    public partial class PeopleIdInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interests_Peoples_PeopleId",
                table: "Interests");

            migrationBuilder.AlterColumn<int>(
                name: "PeopleId",
                table: "Interests",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_Peoples_PeopleId",
                table: "Interests",
                column: "PeopleId",
                principalTable: "Peoples",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interests_Peoples_PeopleId",
                table: "Interests");

            migrationBuilder.AlterColumn<int>(
                name: "PeopleId",
                table: "Interests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_Peoples_PeopleId",
                table: "Interests",
                column: "PeopleId",
                principalTable: "Peoples",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
