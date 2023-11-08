namespace hp_prueba_backend.Application.Exceptions
{
    public class VacantNotFound : Exception
    {
        public VacantNotFound() : base("La vacante no existe o no esta disponible")
        {
        }
    }
}
