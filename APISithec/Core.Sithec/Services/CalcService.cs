using Core.Sithec.DTO.Calc;
using Core.Sithec.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sithec.Services
{
    public class CalcService : ICalcService
    {
        public ReplyCalc Calculate(CalcRequest req)
        {
            ReplyCalc result = new ReplyCalc();

            switch (req.Operador)
            {
                case '+':
                    result.Result = req.Val1 + req.Val2;
                    result.IsSuccess = true;
                    break;
                case '-':
                    result.Result = req.Val1 - req.Val2;
                    result.IsSuccess = true;
                    break;
                case '*':
                    result.Result = req.Val1 * req.Val2;
                    result.IsSuccess = true;
                    break;
                case '/':
                    result.Result = req.Val1 / req.Val2;
                    result.IsSuccess = true;
                    break;
                default:
                    result.Result = 0; 
                    result.IsSuccess = false;
                    result.Message = "Operador no reconocido";
                    break;
            }
            return result;
        }
    }
}
