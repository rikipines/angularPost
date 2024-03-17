using AngularServer.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        static List<User> users=new List<User>() 
        {
            new User() {Id=1,Name="esri",Password="1234", Address="gotlib",Email="wdd@fddf"},
            new User() {Id=1,Name="riki",Password="12345", Address="jbjk",Email="rikip7531@gmail.com"}
        }
        ;
        [HttpGet]
        public List<User> Get()
        {
            return users;
        }

       // GET api/<UserController>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var u=users.Find(a=>a.Id==id);
            if (u == null)
            {
                return NotFound();  
            }
            return Ok(u);
           
        }
       // POST api/<UserController>
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            users.Add(user);
            return Ok(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] User value)
        {
            var u=users.Find(a=>a.Id==id);
            if (u==null)
            {
                return NotFound();  
            }
            u.Name = value.Name;
            u.Password = value.Password;
            u.Address = value.Address;
            u.Email = value.Email;
            return Ok(u);   

        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var r= users.Find(a=>a.Id==id);
            if (r == null)
            {
                return NotFound();
            }
            users.Remove(r);
            return Ok(r);
        }
    }
}
