﻿using PS.Template.AccessData.Queries.Base;
using PS.Template.Domain.DTO;
using PS.Template.Domain.Entities;
using PS.Template.Domain.Interfaces.Queries;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PS.Template.AccessData.Queries
{
    public class SucursalQuery : BaseQuery<Sucursal>, ISucursalQuery
    {
        public SucursalQuery(IDbConnection connection, Compiler sqlKatacompiler) : base(connection, sqlKatacompiler)
        {
        }

        public List<ResponseGetSucursal> GetSucursal(int idSucursal, int idEstado)
        {
            var db = new QueryFactory(connection, sqlKatacompiler);
            var sucursales = db.Query("Sucursal")
                .Select("Sucursal.IdSucursal",
                "Sucursal.Nombre",
                "Direccion.Latitud AS Latitud",
                "Direccion.Longitud AS Longitud",
                "Direccion.Calle AS Calle",
                "Direccion.Altura AS Altura",
                "Localidad.Nombre AS NombreLocalidad",
                "Localidad.Cp AS Cp",
                "Provincia.Nombre AS NombreProvincia",
                "EstadoSucursal.Descripcion AS Estado"
                )
                .Join("Direccion", "Direccion.IdDireccion", "Sucursal.IdDireccion")
                .Join("EstadoSucursal", "EstadoSucursal.IdEstado", "Sucursal.IdEstado")
                .Join("Localidad", "Localidad.IdLocalidad", "Direccion.IdLocalidad")
                .Join("Provincia", "Provincia.IdProvincia", "Localidad.IdProvincia")
                .When(!(idSucursal == 0), q => q.WhereLike("IdSucursal", $"%{idSucursal}%"))
                .When(!(idEstado == 0), q => q.WhereLike("Sucursal.IdEstado", $"%{idEstado}%"))
                .Get<ResponseGetSucursal>();

            return sucursales.ToList();
        }
    }
}