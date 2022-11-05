using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ServiceReference1.SimplexSoapClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private SimplexSoapClient proxyClient;
        public Form1()
        {
            proxyClient = new SimplexSoapClient(SimplexSoapClient.EndpointConfiguration.SimplexSoap12, "https://localhost:44349/Simplex.asmx");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // add
        private void button1_Click(object sender, EventArgs e)
        {

        }

        // concat
        private async void button2_Click(object sender, EventArgs e)
        {
            string val1 = param1.Text.ToString();
            double val2;

            if (!string.IsNullOrEmpty(val1) && double.TryParse(param2.Text.ToString(), out val2))
            {
                result.Text = (await proxyClient.ConcatAsync(val1, val2)).sum_2Result;
            }
            else
            {
                result.Text = "Error!";
            }
        }
    }
}
