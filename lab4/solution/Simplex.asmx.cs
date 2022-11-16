using System.Web.Services;
using System.ComponentModel;
using System.Web.Script.Services;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using solution.models;

namespace solution
{
    [WebService(Namespace = "http://tav/", Description = "Simplex Service")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class Simplex : WebService
    {

        [WebMethod(MessageName = "add", Description = "Sum of 2 int")]
        public int Add(int x, int y)
        {
            return x + y;
        }

        [WebMethod(MessageName = "concat", Description = "Concatination of string and double")]
        public string Concat(string s, double d)
        {
            return s + " " + d.ToString();
        }

        [WebMethod(MessageName = "sum", Description = "Sum of 2 A instances. Response JSON")]
        public A Sum(A msu1, A msu2)
        {
            string body = requestBody(Context.Request);
            A a = new A();
            a.s = msu1.s + msu2.s;
            a.k = msu1.k + msu2.k;
            a.f = msu1.f + msu2.f;
            return a;
        }

        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        [WebMethod(MessageName = "adds", Description = "Sum of 2 int. Response JSON")]
        public int Adds(int x, int y)
        {
            return x + y;
        }

        private string requestBody(HttpRequest request)
        {
            request.InputStream.Position = 0;
            var body = string.Empty;

            using (StreamReader readStream = new StreamReader(request.InputStream))
            {
                body = readStream.ReadToEnd();
            }

            return body;
        }
    }
}
