﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRM_Plus.Migrations
{
    public partial class CreacionTipoTransaccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoTransaccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipoTransaccíon = table.Column<string>(type: "varchar(50)", nullable: false),
                    DescripcionTipoTransaccion = table.Column<string>(type: "varchar(50)", nullable: false),
                    isActivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTransaccion", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoTransaccion");
        }
    }
}
