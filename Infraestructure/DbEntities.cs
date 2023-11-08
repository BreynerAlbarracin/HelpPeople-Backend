using hp_prueba_backend.Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace hp_prueba_backend.Infraestructure
{
    public class DbEntities: DbContext
    {
        public virtual DbSet<Ciudadano> Ciudadano { get; set; }
        public virtual DbSet<CiudadanoVacante> CiudadanoVacante { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual DbSet<UsuariosSistema> UsuariosSistema { get; set; }
        public virtual DbSet<Vacante> Vacante { get; set; }

        public DbEntities(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
