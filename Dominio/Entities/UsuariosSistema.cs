using hp_prueba_backend.Dominio.General;

namespace hp_prueba_backend.Dominio.Entities
{
    public class UsuariosSistema : MasterEntity
    {
        public string Correo { get; set; }
        public string NombreCompleto { get; set; }
        public string Contrasena { get; set; }
    }
}
