using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHackers_DRRIC.Migrations
{
    public partial class fixCyptocurrencyCategoryLicenseeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BadReport_Category_CategoryID",
                table: "BadReport");

            migrationBuilder.DropForeignKey(
                name: "FK_BadReport_Cryptocurrency_CryptocurrencyCurrencyID",
                table: "BadReport");

            migrationBuilder.DropForeignKey(
                name: "FK_BadReport_PostingLicensee_PostingLicenseeLicenseeID",
                table: "BadReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostingLicensee",
                table: "PostingLicensee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cryptocurrency",
                table: "Cryptocurrency");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "PostingLicensee",
                newName: "PostingLicensees");

            migrationBuilder.RenameTable(
                name: "Cryptocurrency",
                newName: "Cryptocurrencys");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categorys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostingLicensees",
                table: "PostingLicensees",
                column: "LicenseeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cryptocurrencys",
                table: "Cryptocurrencys",
                column: "CurrencyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_BadReport_Categorys_CategoryID",
                table: "BadReport",
                column: "CategoryID",
                principalTable: "Categorys",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BadReport_Cryptocurrencys_CryptocurrencyCurrencyID",
                table: "BadReport",
                column: "CryptocurrencyCurrencyID",
                principalTable: "Cryptocurrencys",
                principalColumn: "CurrencyID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BadReport_PostingLicensees_PostingLicenseeLicenseeID",
                table: "BadReport",
                column: "PostingLicenseeLicenseeID",
                principalTable: "PostingLicensees",
                principalColumn: "LicenseeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BadReport_Categorys_CategoryID",
                table: "BadReport");

            migrationBuilder.DropForeignKey(
                name: "FK_BadReport_Cryptocurrencys_CryptocurrencyCurrencyID",
                table: "BadReport");

            migrationBuilder.DropForeignKey(
                name: "FK_BadReport_PostingLicensees_PostingLicenseeLicenseeID",
                table: "BadReport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostingLicensees",
                table: "PostingLicensees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cryptocurrencys",
                table: "Cryptocurrencys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys");

            migrationBuilder.RenameTable(
                name: "PostingLicensees",
                newName: "PostingLicensee");

            migrationBuilder.RenameTable(
                name: "Cryptocurrencys",
                newName: "Cryptocurrency");

            migrationBuilder.RenameTable(
                name: "Categorys",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostingLicensee",
                table: "PostingLicensee",
                column: "LicenseeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cryptocurrency",
                table: "Cryptocurrency",
                column: "CurrencyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_BadReport_Category_CategoryID",
                table: "BadReport",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BadReport_Cryptocurrency_CryptocurrencyCurrencyID",
                table: "BadReport",
                column: "CryptocurrencyCurrencyID",
                principalTable: "Cryptocurrency",
                principalColumn: "CurrencyID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BadReport_PostingLicensee_PostingLicenseeLicenseeID",
                table: "BadReport",
                column: "PostingLicenseeLicenseeID",
                principalTable: "PostingLicensee",
                principalColumn: "LicenseeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
