using Data.Sithec.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Sithec.Repositories
{
    public interface IHumanoRepo
    {
        public Humano Create(Humano humano);
        public List<Humano> Get();
        public Humano Get(int id);
        public Humano Update(int id, Humano humano);
    }

    public class HumanoRepo : IHumanoRepo
    {
        private readonly SithecContext _context;
        private readonly ILogger _logger;
        public HumanoRepo(ILogger<HumanoRepo> logger, SithecContext context)
        {
            _context = context;
            _logger = logger;
        }

        public Humano Create(Humano humano)
        {
            try
            {
                _context.Humanos.Add(humano);
                _context.SaveChanges();
                return humano;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception on Create | Exception: {ex}");
            }

            return null;
        }

        public List<Humano> Get()
        {
            try
            {
                return _context.Humanos.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception on Get All | Exception: {ex}");
            }
            return new List<Humano>();
        }

        public Humano Get(int id)
        {
            try
            {
                return _context.Humanos.FirstOrDefault(x=>x.Id == id);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception on GetHuman | Exception: {ex}");
            }
            return null;
        }

        public Humano Update(int id, Humano humano)
        {
            try
            {
                if(id != humano.Id)
                {
                    _logger.LogError($"Los Identificadores no coinciden");
                    return null;
                }

                var human = _context.Humanos.FirstOrDefault(x => x.Id == id);
                if (human == null)
                {
                    return null;
                }

                human.Nombre = humano.Nombre;
                human.Altura = humano.Altura;
                human.Edad = humano.Edad;
                human.Peso = humano.Peso;
                human.Sexo = humano.Sexo;

                _context.SaveChanges();
                return human;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception on Update | Exception: {ex}");
            }

            return null;
        }
    }
}
