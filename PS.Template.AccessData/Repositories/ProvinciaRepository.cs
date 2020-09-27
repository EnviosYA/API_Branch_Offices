using PS.Template.API.Entities;
using PS.Template.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.AccessData.Repositories
{
    public class ProvinciaRepository : GenericsRepository<Provincia>, IProvinciaRepository
    {
        public ProvinciaRepository(SucursalDBContext context) : base(context)
        {

        }
    }
}
