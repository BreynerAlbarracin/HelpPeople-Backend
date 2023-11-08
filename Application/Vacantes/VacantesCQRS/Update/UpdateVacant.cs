using hp_prueba_backend.Application.Exceptions;
using hp_prueba_backend.Dominio.Entities;
using hp_prueba_backend.Dominio.General;
using hp_prueba_backend.Infraestructure;
using MediatR;

namespace hp_prueba_backend.Application.Ciudadanos.CiudadanosCQRS.Delete
{
    public class UpdateVacant : IRequest<ResponseHandler<bool>>
    {
        public Guid CiudadanoId { get; set; }
        public Guid VacanteId { get; set; }
    }

    public class UpdateVacantHandler : IRequestHandler<UpdateVacant, ResponseHandler<bool>>
    {
        private readonly DbEntities _context;

        public UpdateVacantHandler(DbEntities context)
        {
            _context = context;
        }

        public async Task<ResponseHandler<bool>> Handle(UpdateVacant request, CancellationToken cancellationToken)
        {
            try
            {
                var citizen = _context.Ciudadano.FirstOrDefault(f => f.Id == request.CiudadanoId);

                if (citizen == null)
                {
                    throw new CitizenNotFound();
                }

                var vacant = _context.Vacante.FirstOrDefault(f => f.Id == request.VacanteId && f.Disponibilidad);

                if (vacant == null)
                {
                    throw new VacantNotFound();
                }

                vacant.Disponibilidad = false;
                vacant.UpdateTime = DateTime.Now;

                var citizenVacant = new CiudadanoVacante
                {
                    Id = Guid.NewGuid(),
                    CiudadanoId = citizen.Id,
                    VacanteId = vacant.Id,
                    CreateBy = "",
                    UpdateBy = "",
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now
                };

                _context.CiudadanoVacante.Add(citizenVacant);

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
