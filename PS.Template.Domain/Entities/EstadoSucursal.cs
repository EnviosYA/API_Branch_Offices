using System.Collections.Generic;

namespace PS.Template.Domain.Entities
{
    public class EstadoSucursal
    {
        public int idEstado { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Sucursal> Sucursal { get; set; }
    }
}