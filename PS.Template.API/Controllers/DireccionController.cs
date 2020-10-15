using System;
using Microsoft.AspNetCore.Mvc;
using PS.Template.Domain.DTO;
using PS.Template.Domain.Interfaces.Service;

namespace PS.Template.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DireccionController : ControllerBase
    {
        private readonly IDireccionService _service;
        public DireccionController(IDireccionService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post(DireccionDTO direccionDTO)
        {
            try
            {
                ResponseBadRequest validar = _service.ValidarDireccion(direccionDTO);
                return (validar == null) ? new JsonResult(_service.CreateDireccion(direccionDTO)) { StatusCode = 201 } : new JsonResult(validar) { StatusCode = 400 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return new JsonResult(_service.GetByID(id)) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete]
        public IActionResult Delete(int idDireccion)
        {
            try
            {
                return new JsonResult(_service.DeleteDireccion(idDireccion)) { StatusCode = 204 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
