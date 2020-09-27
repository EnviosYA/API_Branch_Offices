using PS.Template.Domain.Entities;
using PS.Template.Application.Services.Base;
using PS.Template.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;
using PS.Template.AccessData.Repositories;

namespace PS.Template.Application.Services
{
    public class ProvinciaService : BaseService<Provincia>, IProvinciaService
    {
        public ProvinciaService(IProvinciaRepository repository) : base(repository)
        {

        }
    }
}