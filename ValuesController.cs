using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace MapperTest
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ValuesController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult GetValues()
        {
            return Ok(new string[] { "hello", "world", "how", "are", "you" });
        }

        [HttpGet("more")]
        public IActionResult GetMapped()
        {
            return Ok(_mapper.Map<OneModel, AnotherModel>(new OneModel { Id = 1, Name = "Hello", LastName = "World", Age = 26 }));
        }
    }

    public class OneModel
    {
        public int Id;
        public string Name;
        public string LastName;
        public int Age;
    }

    public class AnotherModel
    {
        public string Name;
        public string LastName;
        public int Age;
    }
}
