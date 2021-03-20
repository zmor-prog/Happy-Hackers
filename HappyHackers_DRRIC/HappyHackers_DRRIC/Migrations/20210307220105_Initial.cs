using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHackers_DRRIC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BadReport",
                columns: table => new
                {
                    uid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CoinAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BadReport", x => x.uid);
                });

            migrationBuilder.InsertData(
                table: "BadReport",
                columns: new[] { "uid", "CoinAddress", "DOB", "FirstName", "Hash", "IPAddress", "LastName" },
                values: new object[] { "113177321", "rwU8rAiE2eyEPz3sikfbHuqCuiAtdXqa2v", "10/17/1994", "Zac", "i9zzz3zz0m37mzi90704330990mz99443b2z03b7z7220073bi49b7m0z347b923", "192.0.7.8", "Wellmer" });

            migrationBuilder.InsertData(
                table: "BadReport",
                columns: new[] { "uid", "CoinAddress", "DOB", "FirstName", "Hash", "IPAddress", "LastName" },
                values: new object[] { "107672511", "r3mZvvHVLPtRWAujzBsAoXqH11jhwQZvzY", "3/2/1971", "Anabel", "24ii22zz44432i9260b26960i393b69007z6z737b0224074z209940399zz9973", "192.0.6.1", "Asare" });

            migrationBuilder.InsertData(
                table: "BadReport",
                columns: new[] { "uid", "CoinAddress", "DOB", "FirstName", "Hash", "IPAddress", "LastName" },
                values: new object[] { "106820062", "rNwgkFj6QadEXUyS1jgTD2XEsi8HanKzDX", "9/4/1974", "Jess", "00063zmmz667293973327002i7307779707mb977b0i9z9b4ib3bz77mb33zm3i3", "192.0.2.1", "Mann" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BadReport");
        }
    }
}
