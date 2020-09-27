using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
                return new JsonResult(_service.CreateDireccion(direccionDTO)) { StatusCode = 201 };
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
                return new JsonResult(_service.GetByID(id)) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
