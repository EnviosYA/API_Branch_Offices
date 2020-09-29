using System;
using System.Collections.Generic;

namespace PS.Template.Domain.Entities
{
    public partial class Sucursal
    {
        public int IdSucursal { get; set; }
        
        public string Nombre { get; set; }

        public int IdDireccion { get; set; }    
        public virtual Direccion IdDireccionNavigation { get; set; }

        public int IdEstado { get; set; }
        public virtual EstadoSucursal IdEstadoNavigation { get; set; }
    }
}