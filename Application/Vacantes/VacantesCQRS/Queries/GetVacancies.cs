using hp_prueba_backend.Dominio.General;
using hp_prueba_backend.Infraestructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace hp_prueba_backend.Application.Ciudadanos.CiudadanosCQRS.Queries
{
    public class GetVacancies : IRequest<ResponseHandler<List<VacanteDto>>>
    {
    }

    public class GetVacanciesHandler : IRequestHandler<GetVacancies, ResponseHandler<List<VacanteDto>>>
    {
        private readonly DbEntities _context;

        public GetVacanciesHandler(DbEntities context)
        {
            _context = context;
        }

        public async Task<ResponseHandler<List<VacanteDto>>> Handle(GetVacancies request, CancellationToken cancellationToken)
        {
            try
            {
                var citizens = _context.Vacante.AsNoTracking().Where(w => w.Activo).Select(s => new VacanteDto
                {
                    Id = s.Id,
                    Codigo = s.Codigo,
                    Cargo = s.Cargo,
                    Descripcion = s.Descripcion,
                    Empresa = s.Empresa,
                    Salario = s.Salario,
                    Disponibilidad = s.Disponibilidad,
                }).ToList();

                return new ResponseHandler<List<VacanteDto>>(citizens);
            }
            catch (Exception ex)
            {
                return new ResponseHandler<List<VacanteDto>>(ex.InnerException.ToString());
            }
        }
    }
}