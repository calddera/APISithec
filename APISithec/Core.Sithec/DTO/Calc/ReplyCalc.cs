using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sithec.DTO.Calc
{
    public class ReplyCalc
    {
        public ReplyCalc()
        {
            Message = string.Empty;
        }

        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public float Result { get; set; }
    }
}
