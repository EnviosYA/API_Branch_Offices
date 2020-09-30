using System.Collections.Generic;

namespace PS.Template.Domain.Entities
{
    public partial class Direccion
    {
        public Direccion()
        {
            Sucursal = new HashSet<Sucursal>();
        }

        public int IdDireccion { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public int IdLocalidad { get; set; }

        public virtual Localidad IdLocalidadNavigation { get; set; }
        public virtual ICollection<Sucursal> Sucursal { get; set; }
    }
}
