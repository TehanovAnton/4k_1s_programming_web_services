using Newtonsoft.Json;
using solution.DataBase;
using solution.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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

            if (!string.IsNullOrEmpty(sort) && bool.Parse(sort))
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

            return JsonResponse(request, HttpStatusCode.OK, extension, SerializeStudents(extension, students));
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
        public async Task<HttpResponseMessage> Post(HttpRequestMessage request)
        {
            string json = await requesBodyJson(request);
            StudProto student = JsonConvert.DeserializeObject<StudProto>(json);

            if (student.Name == "" || student.Phone == "")
            {
                ErrorWL error = new ErrorWL(1);
                return JsonResponse(request, HttpStatusCode.OK, "json", JsonConvert.SerializeObject(error));
            }

            DB.AddRecord(student.Name, student.Phone);

            Student createdStudent = DB.GetAll()
                                       .Find((s) => s.Name.Equals(student.Name) && s.Phone.Equals(student.Phone));

            return JsonResponse(request, HttpStatusCode.OK, "json", JsonConvert.SerializeObject(createdStudent));
        }

        // PUT api/students/5
        [HttpPut]
        [Route("students/{id:int}")]
        public async void Put(HttpRequestMessage request, int id)
        {
            string json = await requesBodyJson(request);
            StudProto student = JsonConvert.DeserializeObject<StudProto>(json);

            DB.Update(id, student.Name, student.Phone);
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("students/{id:int}")]
        public void Delete(int id)
        {
            DB.Delete(id);
        }

        private async Task<string> requesBodyJson(HttpRequestMessage request)
        {
            string json = await request.Content.ReadAsStringAsync();
            return json;
        }

        private HttpResponseMessage JsonResponse(HttpRequestMessage request, HttpStatusCode statusCode, string type, string body = null)
        {
            HttpResponseMessage response = request.CreateResponse(statusCode, body);

            string extension = string.Format("application/{0}", type);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue(extension);

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
