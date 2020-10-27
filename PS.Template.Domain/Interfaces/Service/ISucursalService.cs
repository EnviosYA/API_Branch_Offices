using PS.Template.Domain.DTO;
using PS.Template.Domain.Entities;
using PS.Template.Domain.Service.Base;
using System.Collections.Generic;

namespace PS.Template.Domain.Interfaces.Service
{
    public interface ISucursalService : IBaseService<Sucursal>
    {
        List<ResponseGetSucursal> GetSucursal(int idSucursal, int IdEstado);
        void ModifyEstado(int idSucursal);
        ResponseBadRequest ValidarModify(int idSucursal);
    }
}