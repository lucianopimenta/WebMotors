using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMotorsTeste.Data.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_AnuncioWebmotors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marca = table.Column<string>(maxLength: 45, nullable: false),
                    modelo = table.Column<string>(maxLength: 45, nullable: false),
                    versao = table.Column<string>(maxLength: 45, nullable: false),
                    ano = table.Column<int>(nullable: false),
                    quilometragem = table.Column<int>(nullable: false),
                    observacao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_anuncio", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_AnuncioWebmotors");
        }
    }
}
