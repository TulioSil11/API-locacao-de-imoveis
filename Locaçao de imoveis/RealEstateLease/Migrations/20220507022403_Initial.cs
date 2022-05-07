using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateLease.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Imoveis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Proprietario = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cep = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Endereço = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorDoAluguel = table.Column<double>(type: "double", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imoveis", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Imoveis",
                columns: new[] { "Id", "Cep", "Endereço", "Proprietario", "Telefone", "ValorDoAluguel" },
                values: new object[,]
                {
                    { 1, "33845100", "Rua: Safira n° 352, Belo Horizonte - Mg", "Alex", "31995654123", 500.0 },
                    { 2, "3392256", "Rua: Esmeralda n° 560, Contagem - Mg", "Lily", "31955623789", 800.0 },
                    { 3, "75562456", "Rua: Calafates  n° 750, Diamantina - Mg", "Joao", "33975645627", 1100.0 },
                    { 4, "55946023", "Rua: Tupi n° 955, Ribeirao das Neves - Mg", "Elisa", "31995698123", 1500.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imoveis");
        }
    }
}
