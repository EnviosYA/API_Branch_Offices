using PS.Template.API.Entities;
using PS.Template.Domain.Entities;

namespace PS.Template.AccessData.Repositories
{
    public class SucursalRepository : GenericsRepository<Sucursal>, ISucursalRepository
    {
        public SucursalRepository(SucursalDBContext context) : base(context)
        {

        }
    }
}
