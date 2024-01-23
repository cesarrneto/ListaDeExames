using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamesClinpop_Lista.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exames",
                columns: table => new
                {
                    ExameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeExame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescricaoExame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecoExame = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exames", x => x.ExameId);
                });

            migrationBuilder.InsertData(
                table: "Exames",
                columns: new[] { "ExameId", "DescricaoExame", "NomeExame", "PrecoExame" },
                values: new object[] { 1, "Exame de Sangue", "V.D.R.L", 6m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exames");
        }
    }
}
