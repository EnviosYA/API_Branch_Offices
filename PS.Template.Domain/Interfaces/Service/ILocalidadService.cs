using PS.Template.Domain.DTO;
using PS.Template.Domain.Entities;
using PS.Template.Domain.Service.Base;
using System;
using System.Collections.Generic;
using System.Text;
using TP2.REST.Domain.DTO;

namespace PS.Template.Domain.Interfaces.Service
{
    public interface ILocalidadService : IBaseService<Localidad>
    {
        GenericCreatedResponseDTO CreateLocalidad(LocalidadDTO localidadDTO);
        List<ResponseGetLocalidad> GetLocalidad();
    }
}
