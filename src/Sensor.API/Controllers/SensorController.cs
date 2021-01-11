namespace Sensor.API.Controllers
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class SensorController : ControllerBase
    {
        // DELETE api/<SensorDataController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET: api/<SensorDataController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SensorDataController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SensorDataController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SensorDataController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
