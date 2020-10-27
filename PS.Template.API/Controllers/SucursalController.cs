using Microsoft.AspNetCore.Mvc;
using PS.Template.Domain.DTO;
using PS.Template.Domain.Interfaces.Service;
using System;

namespace PS.Template.API.Controllers
{
    [Route("api/sucursales")]
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
                return new JsonResult(_service.GetSucursal(idSucursal,IdEstado)) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPatch]
        public IActionResult Put(ModifySucursalDTO modifyDTO)
        {
            try
            {
                ResponseBadRequest validar = _service.ValidarModify(modifyDTO.IdSucursal);
                if (validar != null)
                {
                    return new JsonResult(validar) { StatusCode = 400 };
                }
                
                _service.ModifyEstado(modifyDTO.IdSucursal);
                return new StatusCodeResult(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}