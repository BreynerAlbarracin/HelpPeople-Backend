using hp_prueba_backend.Application.Login.LoginCQRS.Queries;
using Microsoft.AspNetCore.Mvc;

namespace hp_prueba_backend.Controllers
{
    public class LoginController : MasterControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<IEnumerable<string>>> LoginApi(Login command)
        {
            var result = await Mediator.Send(command);

            if (result.IsValidResponse)
            {
                return Ok(result.Result);
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }
    }
}