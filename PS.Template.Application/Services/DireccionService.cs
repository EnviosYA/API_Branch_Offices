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
            ResponseDTO responseDTO = ResponseDTO.getInstance();
            responseDTO.mensaje = null;
            responseDTO = ValidoDatos(direccionDTO, responseDTO);
            if(responseDTO.mensaje==null)
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
            else
            {
                var entity = new Direccion
                {
                    Latitud = null,
                    Longitud = null,
                    Calle = "Su direccion no pudo ser creada debido a que "+responseDTO.mensaje,
                    Altura = 0,
                    IdLocalidad = 0
                };
                return new GenericCreatedResponseDTO { Entity = "Direccion", Id = entity.Calle.ToString() };
            }
            
        }      
        
        public ResponseDTO ValidoDatos(DireccionDTO direccionDTO, ResponseDTO responseDTO)
        {
            Validaciones.Validaciones.SoloNumerosGrado(direccionDTO.Latitud, responseDTO, "Las latitudes se deben escribir con numeros y signos sexagesimales");
            Validaciones.Validaciones.SoloNumerosGrado(direccionDTO.Longitud, responseDTO, "Las longitudes se deben escribir con numeros y signos sexagesimales");
            Validaciones.Validaciones.SoloNumerosLetras(direccionDTO.Calle, responseDTO, "Las calles solo pueden contener numeros y letras");
            Validaciones.Validaciones.SoloNumerosPositivos(direccionDTO.Altura, responseDTO, "Las alturas solo pueden contener numeros");
            Validaciones.Validaciones.SoloNumerosPositivos(direccionDTO.IdLocalidad , responseDTO, "Los id de las localidades solo pueden contener numeros");
            return responseDTO;
        }

        public ResponseGetDireccion GetByID(int id)
        {
            return _query.GetByID(id);
        }

        public GenericDeleteResponseDTO DeleteDireccion(int idDireccion)
        {
            return _query.DeleteDireccion(idDireccion);
        }
    }
}