using Microsoft.AspNetCore.Mvc;
using PS.Template.Domain.Interfaces.Service;

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
    }
}