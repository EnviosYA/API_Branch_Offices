using PS.Template.AccessData.Queries.Base;
using PS.Template.Domain.DTO;
using PS.Template.Domain.Entities;
using PS.Template.Domain.Interfaces.Queries;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Data;
using System.Linq;

namespace PS.Template.AccessData.Queries
{
    public class DireccionQuery : BaseQuery<Direccion>, IDireccionQuery
    {
        public DireccionQuery(IDbConnection connection, Compiler sqlKatacompiler) : base(connection,sqlKatacompiler)
        {
        }

        public ResponseGetDireccion GetByID(int id)
        {
            var db = new QueryFactory(connection, sqlKatacompiler);
            var direccion = db.Query("Direccion")
                .Select("Direccion.Calle",
                "Direccion.Altura",
                "Localidad.Nombre AS NombreLocalidad",
                "Localidad.CP AS CpLocalidad",
                "Provincia.Nombre AS NombreProvincia"
                )
                .Join("Localidad", "Localidad.IdLocalidad", "Direccion.IdLocalidad")
                .Join("Provincia", "Provincia.IdProvincia", "Localidad.IdProvincia")
                .Where("IdDireccion", id)
                .Get<ResponseGetDireccion>()
                .FirstOrDefault();
            return direccion;
        }

        public GenericDeleteResponseDTO DeleteDireccion(int idDireccion)
        {
            var db = new QueryFactory(connection, sqlKatacompiler);
            var direccion = db.Query("Direccion")
                .Where("idDireccion", idDireccion)
                .Delete();
            return new GenericDeleteResponseDTO { Entity = "Direccion", Id = direccion, Estado = "Eliminado" };            
        }

        public bool ExisteLocalidad(int idLocalidad)
        {
            var db = new QueryFactory(connection, sqlKatacompiler);
            bool existeLocalidad = db.Query("Localidad")
                .Where("idLocalidad", idLocalidad)
                .Get<bool>()
                .FirstOrDefault();
            return existeLocalidad;
        }
    }
}