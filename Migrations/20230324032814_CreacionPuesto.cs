using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRM_Plus.Migrations
{
    public partial class CreacionPuesto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Puesto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePuesto = table.Column<string>(type: "varchar(50)", nullable: false),
                    DescripcionPuesto = table.Column<string>(type: "varchar(50)", nullable: false),
                    NivelRiesgo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalarioMinimo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalarioMaximo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    isActivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puesto", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Puesto");
        }
    }
}
