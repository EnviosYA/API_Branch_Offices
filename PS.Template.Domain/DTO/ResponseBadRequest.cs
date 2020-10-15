using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.DTO
{
    public class ResponseBadRequest
    {
        public int CodigoDeError { get; set; }

        public string Mensaje { get; set; }
    }
}
