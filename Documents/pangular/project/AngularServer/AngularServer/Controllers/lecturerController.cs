using AngularServer.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class lecturerController : ControllerBase
    {
        public static List<lecturer> lecturerList = new List<lecturer>()
        { new lecturer { Name = "Moti", Email = "M@gmail", Id = 2, Password = "9080" } };

        // GET: api/<lecturerController>
        [HttpGet]
        public List<lecturer> Get()
        {
            return lecturerList;
        }

        // GET api/<lecturerController>/5
        [HttpGet("{id}")]
        public lecturer Get(int id)
        {
            return lecturerList.Find(l => l.Id == id);
        }

        //// POST api/<lecturerController>
        [HttpPost]
        public ActionResult Post([FromBody] lecturer lecturer)
        {
            lecturerList.Add(lecturer);
            return Ok(lecturerList);
        }

        // PUT api/<lecturerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] lecturer value)
        {
            var r=lecturerList.Find(a=>a.Id == id);
            if (r==null)
            {
                return NotFound();

            }
            r.Name = value.Name;
            r.Email = value.Email;
            r.Password = value.Password;    
            return Ok(r);   


        }

        // DELETE api/<lecturerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var r=lecturerList.Find(a=>a.Id==id);   
            lecturerList.Remove(r);
            return Ok(r);
        }
    }
}
