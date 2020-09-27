using PS.Template.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.DTO
{
    public class EstadoSucursalDTO
    {
        public string Descripcion { get; set; }

        public virtual ICollection<Sucursal> Sucursal { get; set; }
    }
}
