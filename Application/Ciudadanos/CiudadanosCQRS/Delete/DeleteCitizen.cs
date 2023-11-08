using hp_prueba_backend.Application.Exceptions;
using hp_prueba_backend.Dominio.General;
using hp_prueba_backend.Infraestructure;
using MediatR;

namespace hp_prueba_backend.Application.Ciudadanos.CiudadanosCQRS.Delete
{
    public class DeleteCitizen : IRequest<ResponseHandler<bool>>
    {
        public Guid Id { get; set; }
    }

    public class DeleteCitizenHandler : IRequestHandler<DeleteCitizen, ResponseHandler<bool>>
    {
        private readonly DbEntities _context;

        public DeleteCitizenHandler(DbEntities context)
        {
            _context = context;
        }

        public async Task<ResponseHandler<bool>> Handle(DeleteCitizen request, CancellationToken cancellationToken)
        {
            try
            {
                var citizen = _context.Ciudadano.FirstOrDefault(f => f.Id == request.Id);

                if(citizen == null)
                {
                    throw new CitizenNotFound();
                }

                citizen.Activo = false;
                citizen.UpdateTime = DateTime.Now;

                _context.SaveChanges();

                return new ResponseHandler<bool>(true);
            }
            catch (Exception ex)
            {
                return new ResponseHandler<bool>(ex.InnerException.ToString());
            }
        }
    }
}
