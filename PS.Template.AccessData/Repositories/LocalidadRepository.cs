using PS.Template.API.Entities;
using PS.Template.Domain.Entities;

namespace PS.Template.AccessData.Repositories
{
    public class LocalidadRepository : GenericsRepository<Localidad>, ILocalidadRepository
    {
        public LocalidadRepository(SucursalDBContext context) : base(context)
        {

        }
    }
}
