using Core.Sithec.DTO.Calc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sithec.Interfaces
{
    public interface ICalcService
    {
        public ReplyCalc Calculate(CalcRequest req);
    }
}
