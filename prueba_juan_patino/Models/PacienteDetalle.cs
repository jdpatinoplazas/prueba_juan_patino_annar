using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prueba_juan_patino.Models
{
    public class PacienteDetalle
    {

        [Key]
        public int PacienteDetalleId { get; set; }

        [Column(TypeName = "nvarchar(2)")]
        public string TipoDocumento { get; set; } = "";
        //CC Cedula de ciudadanía, TI Tarjeta de identidad, PA Pasaporte

        [Column(TypeName = "nvarchar(10)")]
        public string NumeroDocumento { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string Nombre { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string Apellido { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string CorreoElectronico { get; set; } = "";

        [Column(TypeName = "nvarchar(10)")]
        public string Telefono { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string FechaNacimiento { get; set; } = "";

        [Column(TypeName = "nvarchar(10)")]
        public string EstadoAfiliado { get; set; } = "";
        //activo, inactivo

    }
}
