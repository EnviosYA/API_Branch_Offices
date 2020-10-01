using PS.Template.Domain.DTO;
using PS.Template.Domain.Entities;
using PS.Template.Domain.Service.Base;
using TP2.REST.Domain.DTO;

namespace PS.Template.Domain.Interfaces.Service
{
    public interface IDireccionService : IBaseService<Direccion>
    {
        GenericCreatedResponseDTO CreateDireccion(DireccionDTO direccionDTO);

        ResponseGetDireccion GetByID(int id);

        GenericDeleteResponseDTO DeleteDireccion(int idDireccion);
    }
}