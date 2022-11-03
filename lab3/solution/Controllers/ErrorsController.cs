using Newtonsoft.Json;
using solution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace solution.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api")]
    public class ErrorsController : ApiController
    {
        // GET api/students/5        
        [HttpGet]
        [Route("errors/{code:int}")]
        public string Get(int code)
        {
            string description = "";
            ErrorWL.codesDescription.TryGetValue(code, out description);

            return JsonConvert.SerializeObject(description);
        }
    }
}
