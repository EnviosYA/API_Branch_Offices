using System.Collections.Generic;

namespace PS.Template.Domain.Entities
{
    public partial class Localidad
    {
        public Localidad()
        {
            Direccion = new HashSet<Direccion>();
        }

        public int IdLocalidad { get; set; }
        public string Nombre { get; set; }
        public int Cp { get; set; }
        public int IdProvincia { get; set; }

        public virtual Provincia IdProvinciaNavigation { get; set; }
        public virtual ICollection<Direccion> Direccion { get; set; }
    }
}
