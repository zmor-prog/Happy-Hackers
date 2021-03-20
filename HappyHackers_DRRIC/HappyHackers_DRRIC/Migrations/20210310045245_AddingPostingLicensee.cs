using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHackers_DRRIC.Migrations
{
    public partial class AddingPostingLicensee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CurrencyID",
                table: "BadReport",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "LicenseeID",
                table: "BadReport",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostingLicenseeLicenseeID",
                table: "BadReport",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PostingLicensee",
                columns: table => new
                {
                    LicenseeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LicenseeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostingLicensee", x => x.LicenseeID);
                });

            migrationBuilder.UpdateData(
                table: "BadReport",
                keyColumn: "uid",
                keyValue: "106820062",
                columns: new[] { "CurrencyID", "LicenseeID" },
                values: new object[] { "X2", "Pax03" });

            migrationBuilder.UpdateData(
                table: "BadReport",
                keyColumn: "uid",
                keyValue: "107672511",
                columns: new[] { "CurrencyID", "LicenseeID" },
                values: new object[] { "X2", "Gem02" });

            migrationBuilder.UpdateData(
                table: "BadReport",
                keyColumn: "uid",
                keyValue: "113177321",
                columns: new[] { "CurrencyID", "LicenseeID" },
                values: new object[] { "X2", "Coin01" });

            migrationBuilder.InsertData(
                table: "PostingLicensee",
                columns: new[] { "LicenseeID", "LicenseeName" },
                values: new object[,]
                {
                    { "Coin01", "Coinbase" },
                    { "Gem02", "Gemini" },
                    { "Pax03", "Paxos" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BadReport_PostingLicenseeLicenseeID",
                table: "BadReport",
                column: "PostingLicenseeLicenseeID");

            migrationBuilder.AddForeignKey(
                name: "FK_BadReport_PostingLicensee_PostingLicenseeLicenseeID",
                table: "BadReport",
                column: "PostingLicenseeLicenseeID",
                principalTable: "PostingLicensee",
                principalColumn: "LicenseeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BadReport_PostingLicensee_PostingLicenseeLicenseeID",
                table: "BadReport");

            migrationBuilder.DropTable(
                name: "PostingLicensee");

            migrationBuilder.DropIndex(
                name: "IX_BadReport_PostingLicenseeLicenseeID",
                table: "BadReport");

            migrationBuilder.DropColumn(
                name: "LicenseeID",
                table: "BadReport");

            migrationBuilder.DropColumn(
                name: "PostingLicenseeLicenseeID",
                table: "BadReport");

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyID",
                table: "BadReport",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BadReport",
                keyColumn: "uid",
                keyValue: "106820062",
                column: "CurrencyID",
                value: "XRP");

            migrationBuilder.UpdateData(
                table: "BadReport",
                keyColumn: "uid",
                keyValue: "107672511",
                column: "CurrencyID",
                value: "XRP");

            migrationBuilder.UpdateData(
                table: "BadReport",
                keyColumn: "uid",
                keyValue: "113177321",
                column: "CurrencyID",
                value: "XRP");
        }
    }
}
