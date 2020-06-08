using Microsoft.EntityFrameworkCore.Migrations;

namespace frontfilma.Migrations
{
    public partial class ChatHistoryMovieForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Topic",
                table: "ChatHistories");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "ChatHistories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ChatHistories_MovieId",
                table: "ChatHistories",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatHistories_Movies_MovieId",
                table: "ChatHistories",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatHistories_Movies_MovieId",
                table: "ChatHistories");

            migrationBuilder.DropIndex(
                name: "IX_ChatHistories_MovieId",
                table: "ChatHistories");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "ChatHistories");

            migrationBuilder.AddColumn<int>(
                name: "Topic",
                table: "ChatHistories",
                type: "int",
                nullable: true);
        }
    }
}
