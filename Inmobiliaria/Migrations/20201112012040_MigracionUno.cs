using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Inmobiliaria.Migrations
{
    public partial class MigracionUno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inmuebles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(nullable: true),
                    imagen = table.Column<string>(nullable: true),
                    direccion = table.Column<string>(nullable: true),
                    barrio = table.Column<string>(nullable: true),
                    ambientes = table.Column<int>(nullable: false),
                    banos = table.Column<int>(nullable: false),
                    cochera = table.Column<int>(nullable: false),
                    precio = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inmuebles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publicaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    miIdInmuebe = table.Column<int>(nullable: false),
                    inmuebleId = table.Column<int>(nullable: true),
                    fechaDePublicacion = table.Column<string>(nullable: true),
                    cantidadDeVisitas = table.Column<int>(nullable: false),
                    operacion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publicaciones_Inmuebles_inmuebleId",
                        column: x => x.inmuebleId,
                        principalTable: "Inmuebles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_inmuebleId",
                table: "Publicaciones",
                column: "inmuebleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Publicaciones");

            migrationBuilder.DropTable(
                name: "Inmuebles");
        }
    }
}
