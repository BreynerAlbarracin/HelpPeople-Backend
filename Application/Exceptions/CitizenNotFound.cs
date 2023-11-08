namespace hp_prueba_backend.Application.Exceptions
{
    public class CitizenNotFound : Exception
    {
        public CitizenNotFound() : base("El ciudadano no existe")
        {
        }
    }
}
