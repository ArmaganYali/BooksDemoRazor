using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksDemoRazor.Migrations
{
    public partial class modeleYearEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublishedYear",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublishedYear",
                table: "Books");
        }
    }
}
