using hp_prueba_backend.Dominio.General;

namespace hp_prueba_backend.Dominio.Entities
{
    public class CiudadanoVacante : MasterEntity
    {
        public virtual Guid CiudadanoId { get; set; }
        public virtual Ciudadano Ciudadano { get; set; }
        public virtual Guid VacanteId { get; set; }
        public virtual Vacante Vacante { get; set; }
    }
}
