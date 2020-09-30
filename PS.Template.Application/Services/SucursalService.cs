using PS.Template.Domain.Entities;
using PS.Template.Application.Services.Base;
using PS.Template.Domain.Interfaces.Service;
using PS.Template.AccessData.Repositories;

namespace PS.Template.Application.Services
{
    public class SucursalService : BaseService<Sucursal>, ISucursalService
    {
        public SucursalService(ISucursalRepository repository) : base(repository)
        {

        }
    }
}
