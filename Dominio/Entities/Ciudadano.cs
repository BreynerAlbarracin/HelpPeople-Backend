using hp_prueba_backend.Dominio.General;

namespace hp_prueba_backend.Dominio.Entities
{
    public class Ciudadano : MasterEntity
    {
        public Guid TipoDocumentoId { get; set; }
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
