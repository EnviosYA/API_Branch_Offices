using PS.Template.Domain.DTO;
using PS.Template.Domain.Entities;
using PS.Template.Domain.Interfaces.Queries.Base;
using System.Collections.Generic;

namespace PS.Template.Domain.Interfaces.Queries
{
    public interface ILocalidadQuery : IBaseQuery<Localidad>
    {
        List<ResponseGetLocalidad> GetAllLocalidad();
    }
}
