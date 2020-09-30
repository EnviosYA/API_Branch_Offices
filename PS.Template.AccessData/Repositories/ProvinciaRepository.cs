using PS.Template.API.Entities;
using PS.Template.Domain.Entities;

namespace PS.Template.AccessData.Repositories
{
    public class ProvinciaRepository : GenericsRepository<Provincia>, IProvinciaRepository
    {
        public ProvinciaRepository(SucursalDBContext context) : base(context)
        {

        }
    }
}
