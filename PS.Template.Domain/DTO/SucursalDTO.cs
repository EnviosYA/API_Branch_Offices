using PS.Template.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.DTO
{
    public class SucursalDTO
    {
        public string Nombre { get; set; }

        public int IdDireccion { get; set; }
        public virtual Direccion IdDireccionNavigation { get; set; }

        public int IdEstado { get; set; }
        public virtual EstadoSucursal IdEstadoNavigation { get; set; }
    }
}
