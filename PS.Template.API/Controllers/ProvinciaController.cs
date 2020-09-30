using Microsoft.AspNetCore.Mvc;
using PS.Template.Domain.Interfaces.Service;

namespace PS.Template.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciaController : ControllerBase
    {
        private readonly IProvinciaService _service;
        public ProvinciaController(IProvinciaService service)
        {
            _service = service;
        }
    }
}
