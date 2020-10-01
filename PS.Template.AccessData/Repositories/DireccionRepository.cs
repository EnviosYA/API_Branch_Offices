using PS.Template.API.Entities;
using PS.Template.Domain.Entities;

namespace PS.Template.AccessData.Repositories
{
    public class DireccionRepository : GenericsRepository<Direccion>, IDireccionRepository
    {
        public DireccionRepository(SucursalDBContext context) : base(context)
        {

        }
    }
}
