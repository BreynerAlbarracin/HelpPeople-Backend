using hp_prueba_backend.Dominio.General;
using hp_prueba_backend.Infraestructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace hp_prueba_backend.Application.Ciudadanos.CiudadanosCQRS.Queries
{
    public class GetDocumentTypes : IRequest<ResponseHandler<List<ListValue>>>
    {
    }

    public class GetDocumentTypesHandler : IRequestHandler<GetDocumentTypes, ResponseHandler<List<ListValue>>>
    {
        private readonly DbEntities _context;

        public GetDocumentTypesHandler(DbEntities context)
        {
            _context = context;
        }

        public async Task<ResponseHandler<List<ListValue>>> Handle(GetDocumentTypes request, CancellationToken cancellationToken)
        {
            try
            {
                var documentTypes = _context.TipoDocumento.AsNoTracking().Where(w => w.Activo).Select(s => new ListValue
                {
                    Label = s.Tipo,
                    Value = s.Id.ToString().ToLower()
                }).OrderBy(o => o.Label).ToList();

                return new ResponseHandler<List<ListValue>>(documentTypes);
            }
            catch (Exception ex)
            {
                return new ResponseHandler<List<ListValue>>(ex.InnerException.ToString());
            }
        }
    }
}