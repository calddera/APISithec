using AutoMapper;
using Core.Sithec.DTO;
using Core.Sithec.DTO.Human;
using Core.Sithec.Interfaces;
using Core.Sithec.Models.Human;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Sithec.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanController : ControllerBase
    {
        private readonly IHumanMockService _humanMockService;
        private readonly IHumanService _humanService;
        private readonly IMapper _mapper;
        public HumanController(IHumanMockService humanMockService, IHumanService humanService, IMapper mapper)
        {
            _humanMockService = humanMockService;
            _humanService = humanService;
            _mapper = mapper;
        }

        // GET: api/<HumanController>/GetMock
        [HttpGet("GetMock")]
        public IEnumerable<ReplyHumanMock> GetMock()
        {
            return _humanMockService.GetMockData();
        }


        // GET api/<HumanController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_humanService.Get());
        }


        // GET api/<HumanController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var response = _humanService.Get(id);
            return Ok(response);
        }

        // POST api/<HumanController>
        [HttpPost]
        public ActionResult Create([FromBody] HumanRequest req)
        {
            var human = _mapper.Map<Human>(req);
            var response = _humanService.Create(human);
            return Ok(response);

        }

        // PUT api/<HumanController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] HumanRequest req)
        {
            var human = _mapper.Map<Human>(req);
            var response = _humanService.Update(id,human);
            return Ok(response);
        }
      
    }
}
