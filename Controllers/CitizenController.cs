using hp_prueba_backend.Application.Ciudadanos.CiudadanosCQRS.Create;
using hp_prueba_backend.Application.Ciudadanos.CiudadanosCQRS.Delete;
using hp_prueba_backend.Application.Ciudadanos.CiudadanosCQRS.Queries;
using Microsoft.AspNetCore.Mvc;

namespace hp_prueba_backend.Controllers
{
    public class CitizenController : MasterControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetCitizensApi()
        {
            var result = await Mediator.Send(new GetCitizens());

            if (result.IsValidResponse)
            {
                return Ok(result.Result);
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        [HttpPost("CreateCitizen")]
        public async Task<ActionResult<IEnumerable<string>>> CreateCitizenApi(CreateCitizen command)
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

        [HttpPut("UpdateCitizen")]
        public async Task<ActionResult<IEnumerable<string>>> UpdateCitizenApi(UpdateCitizen command)
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

        [HttpPut("DeleteCitizen")]
        public async Task<ActionResult<IEnumerable<string>>> DeleteCitizenApi(DeleteCitizen command)
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