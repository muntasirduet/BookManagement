using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class jkjl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Book_BookDetails_BookDetail_Id",
                table: "tb_Book");

            migrationBuilder.DropIndex(
                name: "IX_tb_Book_BookDetail_Id",
                table: "tb_Book");

            migrationBuilder.AddColumn<int>(
                name: "Book_Id",
                table: "Fluent_BookDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookIDBook",
                table: "BookDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Book_BookDetail_Id",
                table: "tb_Book",
                column: "BookDetail_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_BookDetail_Book_Id",
                table: "Fluent_BookDetail",
                column: "Book_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_BookIDBook",
                table: "BookDetails",
                column: "BookIDBook");

            migrationBuilder.AddForeignKey(
                name: "FK_BookDetails_tb_Book_BookIDBook",
                table: "BookDetails",
                column: "BookIDBook",
                principalTable: "tb_Book",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookDetail_Fluent_Books_Book_Id",
                table: "Fluent_BookDetail",
                column: "Book_Id",
                principalTable: "Fluent_Books",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Book_Fluent_BookDetail_BookDetail_Id",
                table: "tb_Book",
                column: "BookDetail_Id",
                principalTable: "Fluent_BookDetail",
                principalColumn: "BookDetail_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDetails_tb_Book_BookIDBook",
                table: "BookDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookDetail_Fluent_Books_Book_Id",
                table: "Fluent_BookDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Book_Fluent_BookDetail_BookDetail_Id",
                table: "tb_Book");

            migrationBuilder.DropIndex(
                name: "IX_tb_Book_BookDetail_Id",
                table: "tb_Book");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_BookDetail_Book_Id",
                table: "Fluent_BookDetail");

            migrationBuilder.DropIndex(
                name: "IX_BookDetails_BookIDBook",
                table: "BookDetails");

            migrationBuilder.DropColumn(
                name: "Book_Id",
                table: "Fluent_BookDetail");

            migrationBuilder.DropColumn(
                name: "BookIDBook",
                table: "BookDetails");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Book_BookDetail_Id",
                table: "tb_Book",
                column: "BookDetail_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Book_BookDetails_BookDetail_Id",
                table: "tb_Book",
                column: "BookDetail_Id",
                principalTable: "BookDetails",
                principalColumn: "BookDetail_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
