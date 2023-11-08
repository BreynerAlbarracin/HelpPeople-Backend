using hp_prueba_backend.Dominio.General;

namespace hp_prueba_backend.Dominio.Entities
{
    public class Vacante : MasterEntity
    {
        public string Codigo { get; set; }
        public string Cargo { get; set; }
        public string Descripcion { get; set; }
        public string Empresa { get; set; }
        public int Salario { get; set; }
        public bool Disponibilidad { get; set; }
    }
}
