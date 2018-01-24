using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IChipo.Repository.EF;
using IChipo.Repository.EF.Models;
using Microsoft.AspNetCore.Mvc;

namespace Net.Core.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly GodContext _context;

        public ValuesController(GodContext context) {

        _context = context;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
          var item=  _context.TodoItems.FirstOrDefault(); ;
             
            return new string[] { item?.FullName, item?.PhoneNumber};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
