using PS.Template.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PS.Template.Application.Validaciones
{
    public class Validaciones
    {
        public static ResponseDTO SoloNumerosLetras(string array, ResponseDTO responseDTO, string mensaje)
        {
            if (!Regex.IsMatch(array, @"^[a-zA-Z0-9]+$"))
            {
                return respuestaConjunta(responseDTO, mensaje);
            }
            else
            {
                return responseDTO;
            }
        }

        public static ResponseDTO SoloNumerosGrado(string array, ResponseDTO responseDTO, string mensaje)
        {
            if (!Regex.IsMatch(array, @"^[0-9°']+$"))
            {
                return respuestaConjunta(responseDTO, mensaje);
            }
            else
            {
                return responseDTO;
            }
        }

        public static ResponseDTO SoloNumerosPositivos(int numero, ResponseDTO responseDTO, string mensaje)
        {
            string array;
            try
            {
                array = Convert.ToString(numero);
            }
            catch
            {
                return respuestaConjunta(responseDTO, mensaje);
            }
            if (!Regex.IsMatch(array, @"^[0-9]+$"))
            {
                return respuestaConjunta(responseDTO, mensaje);
            }
            else
            {
                return responseDTO;
            }
        }

        public static ResponseDTO respuestaConjunta(ResponseDTO responseDTO, string mensaje)
        {
            if (responseDTO.mensaje == null)
            {
                responseDTO.mensaje = mensaje;
            }
            else
            {
                responseDTO.mensaje = responseDTO.mensaje + " * " + mensaje;
            }

            return responseDTO;
        }
    }
}
