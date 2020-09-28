using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.DTO
{
    public class ResponseGetLocalidad
    {
        public string Nombre { get; set; }
        public int Cp { get; set; }
        public int IdProvincia { get; set; }
    }
}
