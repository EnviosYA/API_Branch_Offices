using PS.Template.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PS.Template.Application
{
    public class Validacion
    {
        public static bool SoloNumerosLetras(string array)
        {           
            return Regex.IsMatch(array, @"^[a-zA-Z0-9\s]+$");                       
        }

        public static bool SoloNumerosPositivos(int numero)
        {
            string numeroParse = numero.ToString();
            return Regex.IsMatch(numeroParse, @"^[0-9]+$");
        }
    }
}