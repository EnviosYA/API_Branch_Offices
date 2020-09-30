using PS.Template.Domain.DTO;
using PS.Template.Domain.Entities;
using PS.Template.Domain.Interfaces.Queries.Base;

namespace PS.Template.Domain.Interfaces.Queries
{
    public interface IDireccionQuery : IBaseQuery<Direccion>
    {
        ResponseGetDireccion GetByID(int id);
    }
}