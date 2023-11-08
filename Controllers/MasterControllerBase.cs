using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace hp_prueba_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]
    public class MasterControllerBase : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ?? (_mediator = base.HttpContext.RequestServices.GetService<IMediator>());
    }
}
