using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.ServiceReference1;

namespace WebApplication1
{
    public partial class Sum : System.Web.UI.Page
    {
        private WCFSiplexClient proxyClient;
        protected void Page_Load(object sender, EventArgs e)
        {
            proxyClient = new WCFSiplexClient();
        }

        protected void sum_Click(object sender, EventArgs e)
        {
            A val1 = new A {
                s = x_s.Text,
                k = int.Parse(x_k.Text),
                f = float.Parse(x_f.Text),
            },
            val2 = new A {
                s = y_s.Text,
                k = int.Parse(y_k.Text),
                f = float.Parse(y_f.Text),
            },
            resValue = proxyClient.Sum(val1, val2);

            result.Text = $"{resValue.s} - {resValue.k} - {resValue.f}";

            if (string.IsNullOrEmpty(result.Text))
            {
                result.Text = "Error!";
            }
        }
    }
}