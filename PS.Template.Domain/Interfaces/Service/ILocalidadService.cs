using PS.Template.Domain.DTO;
using PS.Template.Domain.Entities;
using PS.Template.Domain.Service.Base;
using System.Collections.Generic;
using TP2.REST.Domain.DTO;

namespace PS.Template.Domain.Interfaces.Service
{
    public interface ILocalidadService : IBaseService<Localidad>
    {
        List<ResponseGetLocalidad> GetLocalidad();
    }
}