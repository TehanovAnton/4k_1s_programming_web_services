using System.Web.Services;
using System.ComponentModel;
using System.Web.Script.Services;

namespace solution
{
    [WebService(Namespace = "http://tav/", Description = "Simplex Service")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class Simplex : WebService
    {

        [WebMethod(MessageName = "sum_1", Description = "Sum of 2 int")]
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
