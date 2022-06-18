using AutoMapper;
using Core.Sithec.DTO.Calc;
using Core.Sithec.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Sithec.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        private readonly ICalcService _calcService;
        private readonly IMapper _mapper;

        public CalcController(ICalcService calcService, IMapper mapper)
        {
            _calcService = calcService;
            _mapper = mapper;
        }

        // GET api/<CalcController>
        [HttpGet]
        public ReplyCalc Get([FromHeader] CalcRequestHeaders req)
        {
            var request = _mapper.Map<CalcRequest>(req);
            return _calcService.Calculate(request);
        }

        // POST api/<CalcController>
        [HttpPost]
        public ReplyCalc Post([FromBody] CalcRequest req)
        {
            return _calcService.Calculate(req);
        }
    }
}
