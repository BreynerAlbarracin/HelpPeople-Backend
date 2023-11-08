using hp_prueba_backend.Dominio.Entities;
using hp_prueba_backend.Dominio.General;
using hp_prueba_backend.Infraestructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace hp_prueba_backend.Application.Ciudadanos.CiudadanosCQRS.Create
{
    public class CreateCitizen : IRequest<ResponseHandler<bool>>
    {
        public Guid TipoDocumento { get; set; }
        public int Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Profesion { get; set; }
        public int AspiracionSalarial { get; set; }
        public string CorreoElectronico { get; set; }
    }

    public class CreateCitizenHandler : IRequestHandler<CreateCitizen, ResponseHandler<bool>>
    {
        private readonly DbEntities _context;
        public CreateCitizenHandler(DbEntities context)
        {
            _context = context;
        }

        public async Task<ResponseHandler<bool>> Handle(CreateCitizen request, CancellationToken cancellationToken)
        {
            try
            {
                var newCitizen = new Ciudadano()
                {
                    TipoDocumentoId = request.TipoDocumento,
                    Cedula = request.Cedula,
                    Nombres = request.Nombres,
                    Apellidos = request.Apellidos,
                    FechaNacimiento = request.FechaNacimiento,
                    Profesion = request.Profesion,
                    AspiracionSalarial = request.AspiracionSalarial,
                    CorreoElectronico = request.CorreoElectronico,
                    CreateBy = "",
                    UpdateBy = "",
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now
                };

                var citizens = _context.Ciudadano.Add(newCitizen);

                _context.SaveChanges();

                return new ResponseHandler<bool>(newCitizen.Id != Guid.Empty);
            }
            catch (Exception ex)
            {
                return new ResponseHandler<bool>(ex.InnerException.ToString());
            }
        }
    }
}
