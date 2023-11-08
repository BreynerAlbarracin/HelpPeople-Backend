using hp_prueba_backend.Dominio.General;
using hp_prueba_backend.Infraestructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace hp_prueba_backend.Application.Ciudadanos.CiudadanosCQRS.Queries
{
    public class GetListCitizens : IRequest<ResponseHandler<List<ListValue>>>
    {
    }

    public class GetListCitizensHandler : IRequestHandler<GetListCitizens, ResponseHandler<List<ListValue>>>
    {
        private readonly DbEntities _context;

        public GetListCitizensHandler(DbEntities context)
        {
            _context = context;
        }

        public async Task<ResponseHandler<List<ListValue>>> Handle(GetListCitizens request, CancellationToken cancellationToken)
        {
            try
            {
                var citizens = _context.Ciudadano.AsNoTracking()
                    .Where(w => w.Activo && !_context.CiudadanoVacante.AsNoTracking().Select(s => s.CiudadanoId).Contains(w.Id))
                    .Select(s => new ListValue
                    {
                        Value = s.Id.ToString().ToLower(),
                        Label = s.Nombres,
                    }).ToList();

                return new ResponseHandler<List<ListValue>>(citizens);
            }
            catch (Exception ex)
            {
                return new ResponseHandler<List<ListValue>>(ex.InnerException.ToString());
            }
        }
    }
}