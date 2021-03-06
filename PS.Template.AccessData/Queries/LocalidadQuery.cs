﻿using PS.Template.AccessData.Queries.Base;
using PS.Template.Domain.DTO;
using PS.Template.Domain.Entities;
using PS.Template.Domain.Interfaces.Queries;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PS.Template.AccessData.Queries
{
    public class LocalidadQuery : BaseQuery<Localidad>, ILocalidadQuery
    {
        public LocalidadQuery(IDbConnection connection, Compiler sqlKatacompiler) : base(connection, sqlKatacompiler)
        {

        }

        public List<ResponseGetLocalidad> GetAllLocalidad()
        {
            var db = new QueryFactory(connection, sqlKatacompiler);
            var query = db.Query("Localidad")
                .Select("Localidad.IdLocalidad",
                "Localidad.Nombre",
                "Localidad.Cp",
                "Provincia.Nombre AS NombreProvincia")
                .Join("Provincia", "Provincia.IdProvincia", "Localidad.IdProvincia");
            var result = query.Get<ResponseGetLocalidad>();
            return result.ToList();
        }
    }
}