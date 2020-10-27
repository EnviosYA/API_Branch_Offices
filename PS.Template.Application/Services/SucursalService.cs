using PS.Template.Domain.Entities;
using PS.Template.Application.Services.Base;
using PS.Template.Domain.Interfaces.Service;
using PS.Template.AccessData.Repositories;
using PS.Template.Domain.DTO;
using PS.Template.Domain.Interfaces.Queries;
using System.Collections.Generic;

namespace PS.Template.Application.Services
{
    public class SucursalService : BaseService<Sucursal>, ISucursalService
    {
        private readonly ISucursalQuery _query;
        public SucursalService(ISucursalRepository repository, ISucursalQuery query) : base(repository)
        {
            _query = query;
        }

        public List<ResponseGetSucursal> GetSucursal(int idSucursal, int IdEstado)
        {
            return _query.GetSucursal(idSucursal, IdEstado);
        }

        public void ModifyEstado(int idSucursal)
        {
            _query.ModifyEstado(idSucursal);
        }

        public ResponseBadRequest ValidarModify(int idSucursal)
        {
            if (!_query.ExisteSucursal(idSucursal))
                return new ResponseBadRequest {CodigoDeError = 400, Mensaje = "No existe una sucursal con el id ingresado" };
            return null;
        }
    }
}