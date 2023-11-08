using hp_prueba_backend.Application.Exceptions;
using hp_prueba_backend.Dominio.General;
using hp_prueba_backend.Infraestructure;
using MediatR;

namespace hp_prueba_backend.Application.Ciudadanos.CiudadanosCQRS.Delete
{
    public class UpdateCitizen : IRequest<ResponseHandler<bool>>
    {
        public Guid Id { get; set; }
        public Guid TipoDocumento { get; set; }
        public int Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Profesion { get; set; }
        public int AspiracionSalarial { get; set; }
        public string CorreoElectronico { get; set; }
    }

    public class UpdateCitizenHandler : IRequestHandler<UpdateCitizen, ResponseHandler<bool>>
    {
        private readonly DbEntities _context;

        public UpdateCitizenHandler(DbEntities context)
        {
            _context = context;
        }

        public async Task<ResponseHandler<bool>> Handle(UpdateCitizen request, CancellationToken cancellationToken)
        {
            try
            {
                var citizen = _context.Ciudadano.FirstOrDefault(f => f.Id == request.Id);

                if (citizen == null)
                {
                    throw new CitizenNotFound();
                }

                citizen.Id = request.Id;
                citizen.TipoDocumentoId = request.TipoDocumento;
                citizen.Cedula = request.Cedula;
                citizen.Nombres = request.Nombres;
                citizen.Apellidos = request.Apellidos;
                citizen.FechaNacimiento = request.FechaNacimiento;
                citizen.Profesion = request.Profesion;
                citizen.AspiracionSalarial = request.AspiracionSalarial;
                citizen.CorreoElectronico = request.CorreoElectronico;

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
