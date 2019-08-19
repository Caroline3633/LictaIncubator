using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web_Api.DTO.Data.Model;
using Web_Api.DTO.Data;


namespace Web_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
         var Details =   _context.users;
         return Ok(Details);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
           var file =_context.users.Where(r => r.id == id).FirstOrDefault();
           return Ok(file);

        }

         [HttpGet("Gender/{id}")]
        public ActionResult<string> Gender(string id)
        {
           var file =_context.users.Where(r => r.gender == id);
           return Ok(file);

        }
         [HttpGet("Goin/{userN}/{pw}")]
        public ActionResult<string> Goin(string userN, string pw)
        {
           var file =_context.users.Where(r => r.userName.
           CompareTo(userN) == 0 && r.password.CompareTo(pw)==0);
           return Ok(file);

        }

        // POST api/values
        [HttpPost]
        public IActionResult Post(User person)
        {
            _context.Add(person);
            _context.SaveChangesAsync();
            return Ok("Saved");


        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           
        _context.users.Where(d => d.id ==id);

        }
    }
}
