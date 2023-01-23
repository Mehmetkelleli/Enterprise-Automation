using Microsoft.EntityFrameworkCore.Migrations;

namespace isteksikayet.Data.Migrations
{
    public partial class AddingTaskUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedUserId",
                table: "Tasks",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileUrl",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaskUserId",
                table: "Tasks",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CreatedUserId",
                table: "Tasks",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskUserId",
                table: "Tasks",
                column: "TaskUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_AspNetUsers_CreatedUserId",
                table: "Tasks",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_AspNetUsers_TaskUserId",
                table: "Tasks",
                column: "TaskUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_AspNetUsers_CreatedUserId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_AspNetUsers_TaskUserId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_CreatedUserId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_TaskUserId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "FileUrl",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TaskUserId",
                table: "Tasks");
        }
    }
}
