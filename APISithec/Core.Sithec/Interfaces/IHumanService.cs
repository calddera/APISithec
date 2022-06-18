using Core.Sithec.DTO.Human;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sithec.Interfaces
{
    public interface IHumanService
    {
        public Models.Human.Human Create(Models.Human.Human human);
        public ReplyHuman Get();
        public Models.Human.Human Get(int id);
        public Models.Human.Human Update(int id, Models.Human.Human human);
    }
}
