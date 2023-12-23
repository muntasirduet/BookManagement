using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class publish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Publisher_Id",
                table: "tb_Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Book_Publisher_Id",
                table: "tb_Book",
                column: "Publisher_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Book_Publishers_Publisher_Id",
                table: "tb_Book",
                column: "Publisher_Id",
                principalTable: "Publishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Book_Publishers_Publisher_Id",
                table: "tb_Book");

            migrationBuilder.DropIndex(
                name: "IX_tb_Book_Publisher_Id",
                table: "tb_Book");

            migrationBuilder.DropColumn(
                name: "Publisher_Id",
                table: "tb_Book");
        }
    }
}
