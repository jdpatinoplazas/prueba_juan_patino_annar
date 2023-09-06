using Microsoft.EntityFrameworkCore;

namespace prueba_juan_patino.Models
{
    public class PacienteDetalleContext : DbContext
    {
        public PacienteDetalleContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PacienteDetalle> PacienteDetalles { get; set; }    
    }
}
