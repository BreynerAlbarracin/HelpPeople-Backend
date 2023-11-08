using hp_prueba_backend.Application.Ciudadanos.CiudadanosCQRS.Queries;
using hp_prueba_backend.Application.Login.LoginCQRS.Queries;
using Microsoft.AspNetCore.Mvc;

namespace hp_prueba_backend.Controllers
{
    public class ListController : MasterControllerBase
    {
        [HttpGet("ListDocumentTypes")]
        public async Task<ActionResult<IEnumerable<string>>> DocumentTypesApi()
        {
            var result = await Mediator.Send(new GetDocumentTypes());

            if (result.IsValidResponse)
            {
                return Ok(result.Result);
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }
        
        [HttpGet("ListCitizen")]
        public async Task<ActionResult<IEnumerable<string>>> ListCitizenApi()
        {
            var result = await Mediator.Send(new GetListCitizens());

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