using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi2.Migrations
{
    public partial class AddPortfolios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Portfolios",
                table: "Portfolios");

            migrationBuilder.RenameTable(
                name: "Portfolios",
                newName: "MyPortfolios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyPortfolios",
                table: "MyPortfolios",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyPortfolios",
                table: "MyPortfolios");

            migrationBuilder.RenameTable(
                name: "MyPortfolios",
                newName: "Portfolios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portfolios",
                table: "Portfolios",
                column: "Id");
        }
    }
}
