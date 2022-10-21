using Newtonsoft.Json;
using solution.DataBase;
using solution.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Xml.Serialization;

namespace solution.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api")]
    public class StudentsController : ApiController
    {
        [Route("students.{extension:alpha}")]
        public HttpResponseMessage Get(HttpRequestMessage request, string extension,
                                       [FromUri] int? limit = null,
                                       [FromUri] string sort = null,
                                       [FromUri] int? offset = null,
                                       [FromUri] int? maxid = null,
                                       [FromUri] int? minid = null,
                                       [FromUri] string like = null,
                                       [FromUri] string globallike = null,
                                       [FromUri] string columns = "Id,Name,Phone")
        {
            List<StudentWL> students = StudentWL.StudentsWithLinks(DB.GetAll(), columns);

            if (limit.HasValue)
                students = students.Take(limit.Value).ToList();

            if (!string.IsNullOrEmpty(sort))
                students = students.OrderBy(stud => stud.Student.Name).ToList();

            if (!string.IsNullOrEmpty(like))
                students = students.Where(stud => stud.Student.Name == like).ToList();

            if (!string.IsNullOrEmpty(globallike))
                students = students
                    .Where(stud => {
                        return Regex.IsMatch(stud.Student.GlobalStr, $@".*{globallike}.*");
                    }).ToList();

            if (offset.HasValue)
                students = students.Skip(offset.Value).ToList();

            if (minid.HasValue)
                students = students.Where(stud => stud.Id >= minid.Value).ToList();

            if (maxid.HasValue)
                students = students.Where(stud => stud.Id <= maxid.Value).ToList();            

            return JsonResponse(request, SerializeStudents(extension, students));
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

        private HttpResponseMessage JsonResponse(HttpRequestMessage request, string body = null)
        {
            HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, body);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return response;
        }

        private string SerializeStudents(string type, List<StudentWL> students)
        {
            if (type == "json")
                return JsonConvert.SerializeObject(students);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<StudentWL>));
            string xmlContent = "";

            using (StringWriter strWriter = new StringWriter())
            {
                xmlSerializer.Serialize(strWriter, students);
                xmlContent = strWriter.ToString();
            }

            return xmlContent;
        }            
    }
}
