using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PS.Template.Domain.Entities
{
    public class EstadoSucursal
    {
        public int IdEstado { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Sucursal> Sucursal { get; set; }
    }
}