using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppProject8.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FootballTeams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperbowlAppearances = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballTeams", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FootballTeams",
                columns: new[] { "Id", "City", "Name", "SuperbowlAppearances" },
                values: new object[] { 1, "Buffalo", "Bills", 4 });

            migrationBuilder.InsertData(
                table: "FootballTeams",
                columns: new[] { "Id", "City", "Name", "SuperbowlAppearances" },
                values: new object[] { 2, "San Francisco", "49ers", 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FootballTeams");
        }
    }
}
