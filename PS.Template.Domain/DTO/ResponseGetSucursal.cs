using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.DTO
{
    public class ResponseGetSucursal
    {
        public int IdSucursal { get; set; }
        public string Nombre { get; set; }

        //Direccion
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }

        //Localidad
        public string NombreLocalidad { get; set; }
        public int Cp { get; set; }

        //Provincia
        public string NombreProvincia { get; set; }

        //EstadoSucursal
        public string Estado { get; set; }
    }
}
