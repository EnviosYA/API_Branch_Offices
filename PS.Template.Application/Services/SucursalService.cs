using PS.Template.Domain.Entities;
using PS.Template.Application.Services.Base;
using PS.Template.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;
using PS.Template.AccessData.Repositories;
using PS.Template.Domain.DTO;
using PS.Template.Domain.Interfaces.Queries;

namespace PS.Template.Application.Services
{
    public class SucursalService : BaseService<Sucursal>, ISucursalService, ISucursalQuery
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
    }
}