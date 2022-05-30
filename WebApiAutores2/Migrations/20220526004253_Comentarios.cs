using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiAutores2.Migrations
{
    public partial class Comentarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Comentarios",
                table: "Comentarios",
                newName: "Contenido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contenido",
                table: "Comentarios",
                newName: "Comentarios");
        }
    }
}
