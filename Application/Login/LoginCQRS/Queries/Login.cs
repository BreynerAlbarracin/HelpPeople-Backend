using hp_prueba_backend.Application.Exceptions;
using hp_prueba_backend.Dominio.Entities;
using hp_prueba_backend.Dominio.General;
using hp_prueba_backend.Infraestructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace hp_prueba_backend.Application.Login.LoginCQRS.Queries
{
    public class Login : IRequest<ResponseHandler<UsuariosSistema>>
    {
        public string Correo { get; set; }
        public string Contrasena { get; set; }
    }

    public class LoginHandler : IRequestHandler<Login, ResponseHandler<UsuariosSistema>>
    {
        protected readonly DbEntities _context;

        public LoginHandler(DbEntities context)
        {
            _context = context;
        }

        public async Task<ResponseHandler<UsuariosSistema>> Handle(Login request, CancellationToken cancellationToken)
        {
            try
            {
                var usuarioLogin = _context.UsuariosSistema.AsNoTracking().FirstOrDefault(f => f.Correo == request.Correo && f.Contrasena == request.Contrasena && f.Activo);

                if (usuarioLogin == null)
                {
                    throw new CitizenNotFound();
                }

                usuarioLogin.Contrasena = "";

                return new ResponseHandler<UsuariosSistema>(usuarioLogin);
            }
            catch (Exception ex)
            {
                return new ResponseHandler<UsuariosSistema>(ex.InnerException.ToString());
            }
        }
    }
}
