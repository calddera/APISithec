using AutoMapper;
using Core.Sithec.DTO.Human;
using Core.Sithec.Interfaces;
using Core.Sithec.Models.Human;
using Data.Sithec.Entities;
using Data.Sithec.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sithec.Services
{
    public class HumanService : IHumanService
    {
        private readonly IHumanoRepo _humanoRepo;
        private readonly IMapper _mapper;
        public HumanService(IHumanoRepo humanoRepo, IMapper mapper)
        {
            _humanoRepo = humanoRepo;
            _mapper = mapper;
        }

        public Human Create(Human human)
        {
            var humano = _mapper.Map<Humano>(human);
            var result = _humanoRepo.Create(humano);
            return _mapper.Map<Human>(result);
        }

        public ReplyHuman Get()
        {
            ReplyHuman reply = new ReplyHuman();
            var result = _humanoRepo.Get();
            reply.Humans = _mapper.Map<List<Human>>(result);
            reply.IsSuccess = true;

            return reply;
        }

        public Human Get(int id)
        {
            var result = _humanoRepo.Get(id);
            return result == null ? null : _mapper.Map<Human>(result);
        }

        public Human Update(int id, Human human)
        {
            var humano = _mapper.Map<Humano>(human);
            var result = _humanoRepo.Update(id,humano);
            return result == null ? null : _mapper.Map<Human>(result);
        }
    }
}
