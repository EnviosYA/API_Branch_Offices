using PS.Template.Domain.DTO;
using PS.Template.Domain.Entities;
using PS.Template.Domain.Interfaces.Queries.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.Interfaces.Queries
{
    public interface ISucursalQuery : IBaseQuery<Sucursal>
    {
        List<ResponseGetSucursal> GetSucursal(int idSucursal, int IdEstado);
        GenericModifyResponseDTO ModifyEstado(int idSucursal);
    }
}