using PS.Template.Domain.Entities;
using PS.Template.Application.Services.Base;
using PS.Template.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;
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

        public GenericCreatedResponseDTO CreateLocalidad(LocalidadDTO localidadDTO)
        {
            var entity = new Localidad
            {
                Nombre = localidadDTO.Nombre,
                Cp = localidadDTO.Cp,
                IdProvincia = localidadDTO.IdProvincia
            };
            Repository.Add(entity);
            return new GenericCreatedResponseDTO
            {
                Entity = "Localidad",
                Id = entity.IdLocalidad.ToString()
            };
        }

        
        public List<ResponseGetLocalidad> GetLocalidad()
        {
            return _query.GetAllLocalidad();
        }
    }
}
