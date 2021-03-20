using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHackers_DRRIC.Migrations
{
    public partial class AddingCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cryptocurrency",
                keyColumn: "CurrencyID",
                keyValue: "B");

            migrationBuilder.DeleteData(
                table: "Cryptocurrency",
                keyColumn: "CurrencyID",
                keyValue: "E");

            migrationBuilder.DeleteData(
                table: "Cryptocurrency",
                keyColumn: "CurrencyID",
                keyValue: "X");

            migrationBuilder.AddColumn<string>(
                name: "CategoryID",
                table: "BadReport",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Crime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Crime" },
                values: new object[,]
                {
                    { "CE1", "Child Explotation" },
                    { "HT1", "Human Tracking" },
                    { "TF1", "Terror Financing" }
                });

            migrationBuilder.InsertData(
                table: "Cryptocurrency",
                columns: new[] { "CurrencyID", "Code" },
                values: new object[,]
                {
                    { "E1", "ETH" },
                    { "X2", "XRP" },
                    { "B3", "BTC" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BadReport_CategoryID",
                table: "BadReport",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_BadReport_Category_CategoryID",
                table: "BadReport",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BadReport_Category_CategoryID",
                table: "BadReport");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_BadReport_CategoryID",
                table: "BadReport");

            migrationBuilder.DeleteData(
                table: "Cryptocurrency",
                keyColumn: "CurrencyID",
                keyValue: "B3");

            migrationBuilder.DeleteData(
                table: "Cryptocurrency",
                keyColumn: "CurrencyID",
                keyValue: "E1");

            migrationBuilder.DeleteData(
                table: "Cryptocurrency",
                keyColumn: "CurrencyID",
                keyValue: "X2");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "BadReport");

            migrationBuilder.InsertData(
                table: "Cryptocurrency",
                columns: new[] { "CurrencyID", "Code" },
                values: new object[] { "E", "ETH" });

            migrationBuilder.InsertData(
                table: "Cryptocurrency",
                columns: new[] { "CurrencyID", "Code" },
                values: new object[] { "X", "XRP" });

            migrationBuilder.InsertData(
                table: "Cryptocurrency",
                columns: new[] { "CurrencyID", "Code" },
                values: new object[] { "B", "BTC" });
        }
    }
}
