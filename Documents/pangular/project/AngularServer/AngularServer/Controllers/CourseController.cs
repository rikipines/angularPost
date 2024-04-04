using AngularServer.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
       public static List<Course> courses=new List<Course>()
       {
            new Course(){Id=1,Name="bookKeeping",CategoryId= 1,LessonsAmount= 20,DateOfStart= new DateTime(2024,04,05),syllibus=new List<string>() {"important"},LecturerId=9, Image="https://www.mylist.co.il/wp-content/uploads/2023/10/%D7%A7%D7%95%D7%A8%D7%A1-%D7%94%D7%99%D7%99%D7%98%D7%A7.jpg",Way_Of_Learning=Way_Of_Learning.Frontaly
            },
            new Course(){Id=2,Name="Financial management",CategoryId=2,LessonsAmount=35,DateOfStart=new DateTime(2024,03,18),syllibus=new List<string>() ,LecturerId=5,Image="https://www.wise-fp.co.il/wp-content/uploads/2024/01/This-is-what-is-important-to-consider-before-turning-to-personal-financial-advice.jpg",Way_Of_Learning=Way_Of_Learning.Zoom
            },
            new Course(){Id=3,Name="Occupational Therapy",CategoryId=4,LessonsAmount=18,DateOfStart=new DateTime(2024,03,25),syllibus=new List<string>() ,LecturerId=1,Image="https://www.kernelios.com/wp-content/uploads/2023/01/%D7%A7%D7%95%D7%A8%D7%A1-%D7%94%D7%99%D7%99%D7%98%D7%A7-%D7%A2%D7%9D-%D7%94%D7%AA%D7%97%D7%99%D7%99%D7%91%D7%95%D7%AA-%D7%9C%D7%A2%D7%91%D7%95%D7%93%D7%94.jpeg",Way_Of_Learning=Way_Of_Learning.Frontaly
            },
            new Course(){Id=4,Name="English",CategoryId=2,LessonsAmount=30,DateOfStart=new DateTime(2024,04,15),syllibus=new List<string> (),LecturerId=2,Image="https://che.org.il/wp-content/uploads/2019/12/shutterstock_602226047.jpg",Way_Of_Learning=Way_Of_Learning.Frontaly
            },
            new Course(){Id=5,Name="Computer Science",CategoryId=3,LessonsAmount=16,DateOfStart=new DateTime(2024,03,29),syllibus=new List<string>() ,LecturerId=3,Image="https://www.afeka.ac.il/media/bbxb0xiz/%D7%AA%D7%95%D7%90%D7%A8-%D7%A8%D7%90%D7%A9%D7%95%D7%9F-%D7%91%D7%9E%D7%93%D7%A2%D7%99-%D7%94%D7%9E%D7%97%D7%A9%D7%91-6.jpg?width=825&rnd=133198304172900000",Way_Of_Learning=Way_Of_Learning.Zoom
            },
              new Course(){Id=6,Name="Programin",CategoryId=6,LessonsAmount=50,DateOfStart=new DateTime(2024,03,20),syllibus=new List<string>() ,LecturerId=8,Image="https://www.isrotel.co.il/media/24773/2.jpg?anchor=center&mode=crop&width=243&height=180&rnd=133004670810000000",Way_Of_Learning=Way_Of_Learning.Frontaly
           
              },
       }
        ;
        // GET: api/<CourseController>
        [HttpGet]
        public List<Course> Get()
        {
            return courses;
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public Course Get(int id)
        {
            return courses.Find(c=>c.Id==id);
        }

        // POST api/<CourseController>
        [HttpPost]
        public ActionResult Post([FromBody] Course course1)
        {
            courses.Add(course1);
            return Ok(course1);

        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Course course)
        {
            var course1 = courses.Find(c => c.Id == id);
            if (course1 == null)
            {
                return NotFound();  
            }

            course1.syllibus = course.syllibus;
            course1.DateOfStart = course.DateOfStart;
            course1.Name = course.Name;
            course1.CategoryId = course.CategoryId;
            course.LessonsAmount = course.LessonsAmount;
            course1.Image = course.Image;
            return Ok(course1);
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            courses.RemoveAt(id);
        }
    }
}
