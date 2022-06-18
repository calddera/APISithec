using AutoMapper;
using Core.Sithec.DTO.Calc;
using Core.Sithec.DTO.Human;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sithec.Models.Automapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CalcRequest, CalcRequestHeaders>().ReverseMap();
            CreateMap<HumanRequest, Human.Human>().ReverseMap();
            CreateMap<Human.Human, Data.Sithec.Entities.Humano>().ReverseMap();
        }
    }
}
