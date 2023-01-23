using Microsoft.EntityFrameworkCore.Migrations;

namespace isteksikayet.Data.Migrations
{
    public partial class CancelledDepoaetmantuserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Departments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
