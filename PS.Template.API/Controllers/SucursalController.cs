using Microsoft.AspNetCore.Mvc;
using PS.Template.Domain.Interfaces.Service;
using System;

namespace PS.Template.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SucursalController : ControllerBase
    {
        private readonly ISucursalService _service;
        public SucursalController(ISucursalService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] int idSucursal, [FromQuery] int IdEstado)
        {
            try
            {
                return new JsonResult(_service.GetSucursal(idSucursal,IdEstado)) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(int idSucursal)
        {
            try
            {
                return new JsonResult(_service.ModifyEstado(idSucursal)) { StatusCode = 204 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}