using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.ServiceReference2;

namespace WebApplication1
{
    public partial class WebForm1 : Page
    {
        private WCFSiplexClient proxyClient;
        protected void Page_Load(object sender, EventArgs e)
        {
            proxyClient = new WCFSiplexClient("BasicHttpBinding_IWCFSiplex");
        }

        protected void add_Click(object sender, EventArgs e)
        {
            int val1, val2;

            if (int.TryParse(x.Text.ToString(), out val1) && int.TryParse(y.Text.ToString(), out val2))
            {
                result.Text = proxyClient.Add(val1, val2).ToString();
            }
            else
            {
                result.Text = "Error!";
            }
        }
    }
}