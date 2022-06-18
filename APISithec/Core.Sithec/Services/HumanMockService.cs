using Core.Sithec.DTO;
using Core.Sithec.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sithec.Services
{
    public class HumanMockService : IHumanMockService
    {
        public ReplyHumanMock[] GetMockData()
        {
            return new[] { new ReplyHumanMock { Id = 1, Nombre = "Martín Caldera", Peso = 105, Edad = 32, Altura = 165.5F, Sexo = "Masculino" },
            new ReplyHumanMock { Id = 2, Nombre = "Victor Caldera", Peso = 115, Edad = 38, Altura = 167F, Sexo = "Masculino" },
            new ReplyHumanMock { Id = 3, Nombre = "Airam Caldera", Peso = 89, Edad = 23, Altura = 155F, Sexo = "Femenino" },
            new ReplyHumanMock { Id = 4, Nombre = "Pamela Ruvalcaba", Peso = 73, Edad = 31, Altura = 164F, Sexo = "Femenino" },
            new ReplyHumanMock { Id = 5, Nombre = "Martina Moreno", Peso = 109, Edad = 57, Altura = 151.3F, Sexo = "Femenino" },
            new ReplyHumanMock { Id = 6, Nombre = "Martín Rivas", Peso = 112, Edad = 59, Altura = 163F, Sexo = "Masculino" }
            };
        }
    }
}
