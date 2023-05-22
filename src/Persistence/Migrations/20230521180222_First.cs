using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba.Persistence.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "CL_Cliente",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tipoIdentificacion = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: true),
                    identificacion = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    nombres = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    apellidos = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    direccion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    celular = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    correo = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime", nullable: true),
                    genero = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: true),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    servicioActivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CL_Cliente", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CL_Cliente",
                schema: "dbo");
        }
    }
}
