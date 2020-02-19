using Microsoft.EntityFrameworkCore.Migrations;

namespace AlmacenX_Remix.Migrations.Producto
{
    public partial class ThirdCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProduct = table.Column<string>(type: "varchar(30)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(50)", nullable: true),
                    stock = table.Column<int>(type: "int", nullable: false),
                    PrecioProd = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
