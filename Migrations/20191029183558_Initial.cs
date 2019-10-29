using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelApi.Solution.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Review = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    user_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationId);
                });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Name", "Rating", "Review", "user_name" },
                values: new object[,]
                {
                    { 1, "Seattle", 5, "It's cool", "Bob" },
                    { 2, "San Francisco", 4, "It's Busy", "Bob" },
                    { 3, "New York", 3, "Way too many people", "Joe" },
                    { 4, "Seattle", 5, "It's pretty neat", "Joe" },
                    { 5, "Seattle", 2, "It's meh", "Fred" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations");
        }
    }
}
