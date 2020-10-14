using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.DTO
{
    public class ResponseDTO
    {
        private static ResponseDTO instance = null;
        public static ResponseDTO getInstance()
        {
            if (instance == null)
            {
                instance = new ResponseDTO();
            }
            return instance;
        }
        public string mensaje { get; set; }
    }
}
