using Newtonsoft.Json;
using solution.DataBase;
using solution.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace solution.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api")]
    public class StudentsController : ApiController
    {
        [Route("students.{extension:alpha}")]
        public string Get(string extension, [FromUri] int? limit = null, [FromUri] string sort = null)
        {
            List<StudentWL> students = StudentWL.StudentsWithLinks(DB.GetAll());

            if (limit.HasValue)
                students = students.Take(limit.Value).ToList();

            if (!string.IsNullOrEmpty(sort))
                students = students.OrderBy((StudentWL stud) => stud.Student.Name).ToList();

            return JsonConvert.SerializeObject(students);
        }

        // GET api/students/5        
        [HttpGet]
        [Route("students/{id:int}")]
        public string Get(int id)
        {
            Student student = DB.Find(id);
            return JsonConvert.SerializeObject(student.StudentWithLinks());
        }

        // POST api/values
        [Route("students")]
        public void Post([FromUri] string name, [FromUri] string phone)
        {
            DB.AddRecord(name, phone);
        }

        // PUT api/students/5
        [HttpPut]
        [Route("students/{id:int}")]
        public void Put(int id, [FromUri] string name, [FromUri] string phone)
        {
            DB.Update(id, name, phone);
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("students/{id:int}")]
        public void Delete(int id)
        {
            DB.Delete(id);
        }
    }
}
