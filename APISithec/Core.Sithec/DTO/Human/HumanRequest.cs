using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sithec.DTO.Human
{
    public class HumanRequest
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
    }
}
