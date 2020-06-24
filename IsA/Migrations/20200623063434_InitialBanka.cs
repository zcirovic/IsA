using Microsoft.EntityFrameworkCore.Migrations;

namespace IsA.Migrations
{
    public partial class InitialBanka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banka",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    naziv = table.Column<string>(maxLength: 255, nullable: false),
                    mesto = table.Column<string>(maxLength: 255, nullable: false),
                    adresa = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banka", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Banka",
                columns: new[] { "id", "adresa", "mesto", "naziv" },
                values: new object[,]
                {
                    { 1, "", "Београд", "ALPHA Bank" },
                    { 20, "", "Београд", "Меридијан банка" },
                    { 21, "", "Параћин", "Национална штедионица" },
                    { 22, "", "Београд", "НБС" },
                    { 23, "", "Ниш", "Нишка банка" },
                    { 24, "", "Београд", "Поштанска штедионица а.д." },
                    { 25, "", "Београд", "Привредна банка" },
                    { 19, "", "Београд", "Комерцијална банка а.д." },
                    { 26, "", "Београд", "СИМ банка" },
                    { 28, "", "Београд", "Универзал банка" },
                    { 29, "", "Чачак", "Чачанска банка" },
                    { 30, "", "Београд", "Марфин банка" },
                    { 31, "", "Београд", "Уникредит банка" },
                    { 32, "", "Београд", "Аик банка" },
                    { 33, "", "Beograd", "Piraeus banka" },
                    { 27, "", "Београд", "Српска банка" },
                    { 34, "", "Novi Sad", "Erste bank a.d." },
                    { 18, "", "Београд", "Војвођанска банка" },
                    { 16, "", "Београд", "Агробанка" },
                    { 2, "", "Београд", "Banca INTESA" },
                    { 3, "", "Крагујевац", "CREDI Bank" },
                    { 4, "", "Београд", "EFG  Eurobank" },
                    { 5, "", "Београд", "Addiko bank" },
                    { 6, "", "Београд", "HVB Bank" },
                    { 7, "", "Београд", "LHB bank" },
                    { 17, "", "Београд", "Атлас банка" },
                    { 8, "", "Нови Сад", "Metals bank" },
                    { 10, "", "Нови сад", "OTP banka" },
                    { 11, "", "Београд", "Pro Credi Bank" },
                    { 12, "", "Београд", "Raiffeisen banka a.d." },
                    { 13, "", "Београд", "Societe Generale Bank" },
                    { 14, "", "Београд", "Sber bank" },
                    { 15, "", "Београд", "ZEPTER bank" },
                    { 9, "", "Београд", "Mikro finance bank" },
                    { 35, "", "Београд", "Теленор банка" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banka");
        }
    }
}
