using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace prueba_juan_patino.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PacienteDetalles",
                columns: table => new
                {
                    PacienteDetalleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDocumento = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    FechaNacimiento = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    EstadoAfiliado = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacienteDetalles", x => x.PacienteDetalleId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PacienteDetalles");
        }
    }
}
