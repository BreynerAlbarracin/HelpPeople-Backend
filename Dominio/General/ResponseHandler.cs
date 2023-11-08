namespace hp_prueba_backend.Dominio.General
{
    public class ResponseHandler<T>
    {
        public T Result { get; private set; }

        public bool IsValidResponse => string.IsNullOrEmpty(Errors);

        public string Errors { get; }

        public ResponseHandler(T response)
        {
            Errors = string.Empty;
            Result = response;
        }

        public ResponseHandler(string errors = null)
        {
            Errors = errors;
            Result = default(T);
        }
    }
}
