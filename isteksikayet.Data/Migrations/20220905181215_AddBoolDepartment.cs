using Microsoft.EntityFrameworkCore.Migrations;

namespace isteksikayet.Data.Migrations
{
    public partial class AddBoolDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Root",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Root",
                table: "AspNetUsers");
        }
    }
}
