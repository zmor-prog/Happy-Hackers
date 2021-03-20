using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHackers_DRRIC.Migrations
{
    public partial class AddingCryptocurrency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "BadReport",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "IPAddress",
                table: "BadReport",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "BadReport",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DOB",
                table: "BadReport",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CoinAddress",
                table: "BadReport",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CryptocurrencyCurrencyID",
                table: "BadReport",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrencyID",
                table: "BadReport",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Cryptocurrency",
                columns: table => new
                {
                    CurrencyID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cryptocurrency", x => x.CurrencyID);
                });

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
                name: "IX_BadReport_CryptocurrencyCurrencyID",
                table: "BadReport",
                column: "CryptocurrencyCurrencyID");

            migrationBuilder.AddForeignKey(
                name: "FK_BadReport_Cryptocurrency_CryptocurrencyCurrencyID",
                table: "BadReport",
                column: "CryptocurrencyCurrencyID",
                principalTable: "Cryptocurrency",
                principalColumn: "CurrencyID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BadReport_Cryptocurrency_CryptocurrencyCurrencyID",
                table: "BadReport");

            migrationBuilder.DropTable(
                name: "Cryptocurrency");

            migrationBuilder.DropIndex(
                name: "IX_BadReport_CryptocurrencyCurrencyID",
                table: "BadReport");

            migrationBuilder.DropColumn(
                name: "CryptocurrencyCurrencyID",
                table: "BadReport");

            migrationBuilder.DropColumn(
                name: "CurrencyID",
                table: "BadReport");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "BadReport",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IPAddress",
                table: "BadReport",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "BadReport",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DOB",
                table: "BadReport",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoinAddress",
                table: "BadReport",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
