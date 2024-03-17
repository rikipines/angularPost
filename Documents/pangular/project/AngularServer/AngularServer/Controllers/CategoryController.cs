using AngularServer.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
     static  public   List<Category> categories=new List<Category>()
     {
         new Category(){Id=1, Name="Design",PathToIcon="tbrhb"},
         new Category(){Id=2, Name="lengauge",PathToIcon="fhrkj"},
         new Category(){Id=3, Name="health",PathToIcon="gerh"}
     };
        // GET: api/<CategoryController>
        [HttpGet]
        public List<Category> Get()
        {
            return categories;
        }

        //GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return categories.Find(a=>a.Id==id);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] Category value)
        {
            categories.Add(value);
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public ActionResult Put( [FromBody] Category value,int id)
        {

            var r = categories.Find(a => a.Id == id);
            if (r == null)
            {
                return NotFound();
            }
            r.Name = value.Name;
            r.PathToIcon = value.PathToIcon;
            return Ok(r);

        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var r =categories.Find(a=>a.Id == id);  
            if(r == null)
            {
                return NotFound();

            }
            categories.Remove(r);
            return Ok(r);

        }
    }
}
