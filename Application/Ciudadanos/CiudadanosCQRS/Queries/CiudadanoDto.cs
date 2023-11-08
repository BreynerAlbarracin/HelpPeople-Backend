using hp_prueba_backend.Dominio.Entities;

namespace hp_prueba_backend.Application.Ciudadanos.CiudadanosCQRS.Queries
{
    public class CiudadanoDto
    {
        public Guid Id { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
        public int Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Profesion { get; set; }
        public int AspiracionSalarial { get; set; }
        public string CorreoElectronico { get; set; }
    }
}
