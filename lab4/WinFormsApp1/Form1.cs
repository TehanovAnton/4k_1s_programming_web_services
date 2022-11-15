using ServiceReference4;
using System;
using System.Windows.Forms;

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

        // Sum
        private async void button2_Click(object sender, EventArgs e)
        {

            A val1 = new A
            {
                s = x_s.Text,
                k = int.Parse(x_k.Text),
                f = float.Parse(x_f.Text),
            },
            val2 = new A
            {
                s = y_s.Text,
                k = int.Parse(y_k.Text),
                f = float.Parse(y_f.Text),
            },
            resValue = (await proxyClient.SumAsync(val1, val2)).sumResult;

            result.Text = $"{resValue.s} - {resValue.k} - {resValue.f}";

            if (string.IsNullOrEmpty(result.Text))
            {
                result.Text = "Error!";
            }
        }

        private void y_f_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
