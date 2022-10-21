using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using System.Web.SessionState;

namespace lab2.Controllers
{   
    public class ValuesController : ApiController, IRequiresSessionState
    {
        private static int RESULT = 0;
        private static Stack<int> globalStack = new Stack<int>();

        // GET
        public int Get()
        {
            int result = GetResult();
            if (globalStack.Count != 0)
            {
                result += globalStack.Peek();
            }

            return result;
        }

        // POST
        public void Post([FromBody] string value)
        {
            string res = ParamByName("RESULT");
            if (!string.IsNullOrEmpty(res))
            {
                SetResult(int.Parse(res));
            }
        }

        // PUT
        public string Put([FromBody] string value)
        {
            string element = ParamByName("ADD");
            if (!string.IsNullOrEmpty(element))
            {
                globalStack.Push(int.Parse(element));
            }

            return JsonConvert.SerializeObject(globalStack);
        }

        // DELETE
        public string Delete()
        {
            if (globalStack.Count != 0)
            {
                globalStack.Pop();
            }
            
            return JsonConvert.SerializeObject(globalStack);
        }

        private string ParamByName(string paramName)
        {
            string uri = Request.RequestUri.Query;
            return HttpUtility.ParseQueryString(uri).Get(paramName);
        }

        private int GetResult()
        {
            return RESULT;
        }

        private void SetResult(int? value)
        {
            if (value != null)
                RESULT = value.Value;
        }
    }
}
