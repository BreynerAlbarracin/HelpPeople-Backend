using hp_prueba_backend.Dominio.General;
using hp_prueba_backend.Infraestructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace hp_prueba_backend.Application.Ciudadanos.CiudadanosCQRS.Queries
{
    public class GetCitizens : IRequest<ResponseHandler<List<CiudadanoDto>>>
    {
    }

    public class GetCitizensHandler : IRequestHandler<GetCitizens, ResponseHandler<List<CiudadanoDto>>>
    {
        private readonly DbEntities _context;

        public GetCitizensHandler(DbEntities context)
        {
            _context = context;
        }

        public async Task<ResponseHandler<List<CiudadanoDto>>> Handle(GetCitizens request, CancellationToken cancellationToken)
        {
            try
            {
                var citizens = _context.Ciudadano.AsNoTracking().Where(w => w.Activo).Select(s => new CiudadanoDto
                {
                    Id = s.Id,
                    TipoDocumento = s.TipoDocumento,
                    Cedula = s.Cedula,
                    Nombres = s.Nombres,
                    Apellidos = s.Apellidos,
                    FechaNacimiento = s.FechaNacimiento,
                    Profesion = s.Profesion,
                    AspiracionSalarial = s.AspiracionSalarial,
                    CorreoElectronico = s.CorreoElectronico,
                }).ToList();

                return new ResponseHandler<List<CiudadanoDto>>(citizens);
            }
            catch (Exception ex)
            {
                return new ResponseHandler<List<CiudadanoDto>>(ex.InnerException.ToString());
            }
        }
    }
}