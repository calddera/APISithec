using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sithec.DTO.Human
{
    public class ReplyHuman
    {

        public ReplyHuman()
        {
            Message = string.Empty;
        }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public int Count { get { return Humans.Count; } }
        public List<Models.Human.Human> Humans { get; set; }
    }
}
