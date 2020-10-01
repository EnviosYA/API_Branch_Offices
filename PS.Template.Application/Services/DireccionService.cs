using PS.Template.Domain.Entities;
using PS.Template.Application.Services.Base;
using PS.Template.Domain.Interfaces.Service;
using PS.Template.AccessData.Repositories;
using TP2.REST.Domain.DTO;
using PS.Template.Domain.DTO;
using PS.Template.Domain.Interfaces.Queries;

namespace PS.Template.Application.Services
{
    public class DireccionService : BaseService<Direccion>, IDireccionQuery, IDireccionService
    {
        private readonly IDireccionQuery _query;
        public DireccionService(IDireccionRepository repository, IDireccionQuery query) : base(repository)
        {
            _query = query;
        }

        public GenericCreatedResponseDTO CreateDireccion(DireccionDTO direccionDTO)
        {
            var entity = new Direccion
            {
                Latitud = direccionDTO.Latitud,
                Longitud = direccionDTO.Longitud,
                Calle = direccionDTO.Calle,
                Altura = direccionDTO.Altura,
                IdLocalidad = direccionDTO.IdLocalidad
            };
            Add(entity);

            return new GenericCreatedResponseDTO { Entity = "Direccion", Id = entity.IdDireccion.ToString() };
        }

        public ResponseGetDireccion GetByID(int id)
        {
            return _query.GetByID(id);
        }        
    }
}