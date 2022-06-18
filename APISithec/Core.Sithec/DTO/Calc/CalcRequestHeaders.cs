using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sithec.DTO.Calc
{
    public class CalcRequestHeaders
    {
        [FromHeader]
        public float Val1 { get; set; }
        [FromHeader]
        public float Val2 { get; set; }
        [FromHeader]
        public char Operador { get; set; }
    }
}
