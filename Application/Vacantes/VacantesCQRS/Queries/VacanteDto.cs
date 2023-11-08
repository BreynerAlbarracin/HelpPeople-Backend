using hp_prueba_backend.Dominio.Entities;

namespace hp_prueba_backend.Application.Ciudadanos.CiudadanosCQRS.Queries
{
    public class VacanteDto
    {
        public Guid Id { get; set; }
        public string Codigo { get; set; }
        public string Cargo { get; set; }
        public string Descripcion { get; set; }
        public string Empresa { get; set; }
        public int Salario { get; set; }
        public bool Disponibilidad { get; set; }
    }
}
