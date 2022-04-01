using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb4API.Migrations
{
    public partial class InitalMigaration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peoples",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peoples", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    IntrestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PeopleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.IntrestId);
                    table.ForeignKey(
                        name: "FK_Interests_Peoples_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "Peoples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    LinksId = table.Column<string>(nullable: false),
                    LinkAdress = table.Column<string>(nullable: true),
                    PeopleId = table.Column<int>(nullable: true),
                    InterestIntrestId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.LinksId);
                    table.ForeignKey(
                        name: "FK_Links_Interests_InterestIntrestId",
                        column: x => x.InterestIntrestId,
                        principalTable: "Interests",
                        principalColumn: "IntrestId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Links_Peoples_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "Peoples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interests_PeopleId",
                table: "Interests",
                column: "PeopleId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_InterestIntrestId",
                table: "Links",
                column: "InterestIntrestId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_PeopleId",
                table: "Links",
                column: "PeopleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Peoples");
        }
    }
}
