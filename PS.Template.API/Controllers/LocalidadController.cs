using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PS.Template.Domain.Interfaces.Service;

namespace PS.Template.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalidadController : ControllerBase
    {
        private readonly ILocalidadService _service;
        public LocalidadController(ILocalidadService service)
        {
            _service = service;
        }        
    }
}
