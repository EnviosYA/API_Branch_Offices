using PS.Template.Domain.Entities;
using PS.Template.Application.Services.Base;
using PS.Template.Domain.Interfaces.Service;
using System.Collections.Generic;
using PS.Template.AccessData.Repositories;
using TP2.REST.Domain.DTO;
using PS.Template.Domain.DTO;
using PS.Template.Domain.Interfaces.Queries;

namespace PS.Template.Application.Services
{
    public class LocalidadService : BaseService<Localidad>, ILocalidadService
    {
        private readonly ILocalidadQuery _query;
        public LocalidadService(ILocalidadRepository repository, ILocalidadQuery query) : base(repository)
        {
            _query = query;
        }
        
        public List<ResponseGetLocalidad> GetLocalidad()
        {
            return _query.GetAllLocalidad();
        }
    }
}
