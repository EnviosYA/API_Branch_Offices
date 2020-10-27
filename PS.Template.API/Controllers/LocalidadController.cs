using System;
using Microsoft.AspNetCore.Mvc;
using PS.Template.Domain.Interfaces.Service;

namespace PS.Template.API.Controllers
{
    [Route("api/localidades")]
    [ApiController]
    public class LocalidadController : ControllerBase
    {
        private readonly ILocalidadService _service;
        public LocalidadController(ILocalidadService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetLocalidad()
        {
            try
            {
                return new JsonResult(_service.GetLocalidad()) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}