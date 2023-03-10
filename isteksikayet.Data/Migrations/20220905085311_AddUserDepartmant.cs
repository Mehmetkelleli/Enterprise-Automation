using Microsoft.EntityFrameworkCore.Migrations;

namespace isteksikayet.Data.Migrations
{
    public partial class AddUserDepartmant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Departments");
        }
    }
}
