using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sithec.DTO.Calc
{
    public class CalcRequest
    {
        public float Val1 { get; set; }
        public float Val2 { get; set; }
        public char Operador { get; set; }
    }

    
}

