using Microsoft.EntityFrameworkCore.Migrations;

namespace isteksikayet.Data.Migrations
{
    public partial class AddLocalNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LocalNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocalNumber",
                table: "AspNetUsers");
        }
    }
}
