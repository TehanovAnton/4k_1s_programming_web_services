using System;
using System.IO;
using System.Web;

namespace lab1
{
    public class IISHandler2 : IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse response = context.Response;
            /*C: \Users\Anton\source\4k - 1c\labs\progrmming_web_services\lab1\solution\lab1\HtmlPage1.html*/
            string htmlPage = File.ReadAllText(@"C:\Users\Anton\source\4k-1c\labs\progrmming_web_services\lab1\solution\lab1\HtmlPage1.html");

            response.ContentType = "text/html";
            response.Write(htmlPage);
        }
    }
}
