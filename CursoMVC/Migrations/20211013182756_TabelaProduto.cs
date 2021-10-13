using Microsoft.EntityFrameworkCore.Migrations;

namespace CursoMVC.Migrations
{
    public partial class TabelaProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descicao",
                table: "Produtos");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Produtos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Produtos");

            migrationBuilder.AddColumn<string>(
                name: "Descicao",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
