using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaWeb.Data.Migrations
{
    public partial class ImagenProducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlImagen",
                table: "Productos",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlImagen",
                table: "Productos");
        }
    }
}
