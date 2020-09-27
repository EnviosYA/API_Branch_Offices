using PS.Template.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.DTO
{
    public class ProvinciaDTO
    {
        public string Nombre { get; set; }

        public virtual ICollection<Localidad> Localidad { get; set; }
    }
}
