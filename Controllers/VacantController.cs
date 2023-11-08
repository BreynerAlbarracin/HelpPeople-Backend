using hp_prueba_backend.Application.Ciudadanos.CiudadanosCQRS.Create;
using hp_prueba_backend.Application.Ciudadanos.CiudadanosCQRS.Delete;
using hp_prueba_backend.Application.Ciudadanos.CiudadanosCQRS.Queries;
using Microsoft.AspNetCore.Mvc;

namespace hp_prueba_backend.Controllers
{
    public class VacantController : MasterControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetVacanciesApi()
        {
            var result = await Mediator.Send(new GetVacancies());

            if (result.IsValidResponse)
            {
                return Ok(result.Result);
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        [HttpPost("AssignVacant")]
        public async Task<ActionResult<IEnumerable<string>>> AssignVacancyApi(UpdateVacant command)
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