using PS.Template.Domain.Entities;
using PS.Template.Application.Services.Base;
using PS.Template.Domain.Interfaces.Service;
using PS.Template.AccessData.Repositories;
using TP2.REST.Domain.DTO;
using PS.Template.Domain.DTO;
using PS.Template.Domain.Interfaces.Queries;
using System.Xml.Linq;

namespace PS.Template.Application.Services
{
    public class DireccionService : BaseService<Direccion>, IDireccionService
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
            Save();

            return new GenericCreatedResponseDTO { Entity = "Direccion", Id = entity.IdDireccion.ToString() };
        }        

        public ResponseGetDireccion GetByID(int id)
        {
            return _query.GetByID(id);
        }

        public GenericDeleteResponseDTO DeleteDireccion(int idDireccion)
        {
            if (FindById(idDireccion) == null)
            {
                return null;
            }
            Delete(idDireccion);
            Save();
            return new GenericDeleteResponseDTO { Entity = "Direccion", Id = idDireccion, Estado = "Eliminada" };
        }

        public ResponseBadRequest ValidarDireccion(DireccionDTO direccionDTO)
        {
            if (!Validacion.SoloNumerosLetras(direccionDTO.Calle))
                return new ResponseBadRequest { CodigoDeError = 400, Mensaje = "El formato de la calle ingresada es incorrecto." };
            if (!Validacion.SoloNumerosPositivos(direccionDTO.Altura))
                return new ResponseBadRequest { CodigoDeError = 400, Mensaje = "El formato de la altura ingresada es incorrecto." };
            if (!_query.ExisteLocalidad(direccionDTO.IdLocalidad))
                return new ResponseBadRequest { CodigoDeError = 400, Mensaje = "La localidad ingresada no existe." };
            return null;
        }
    }
}