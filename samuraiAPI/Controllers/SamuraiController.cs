using Microsoft.AspNetCore.Mvc;

using SamuraiApp.Domain;
using SamuraiAPP.Data.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace samuraiAPI.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class SamuraiController : ControllerBase
    {
        private readonly ISamurai _samurais;

        public SamuraiController(ISamurai samurais)
        {
            _samurais = samurais;
        }
        // GET: api/<SamuraiController>
        [HttpGet]
        public async Task<IEnumerable<Samurai>> Get()
        {
            var results = await _samurais.GetAll();
            return results;
        }

        // GET api/<SamuraiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SamuraiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SamuraiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SamuraiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
