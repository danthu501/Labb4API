using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb4API.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_Interests_InterestIntrestId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_InterestIntrestId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "InterestIntrestId",
                table: "Links");

            migrationBuilder.AddColumn<int>(
                name: "InterestId",
                table: "Links",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Links",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Links_InterestId",
                table: "Links",
                column: "InterestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Interests_InterestId",
                table: "Links",
                column: "InterestId",
                principalTable: "Interests",
                principalColumn: "IntrestId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_Interests_InterestId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_InterestId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "InterestId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Links");

            migrationBuilder.AddColumn<int>(
                name: "InterestIntrestId",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Links_InterestIntrestId",
                table: "Links",
                column: "InterestIntrestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Interests_InterestIntrestId",
                table: "Links",
                column: "InterestIntrestId",
                principalTable: "Interests",
                principalColumn: "IntrestId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
