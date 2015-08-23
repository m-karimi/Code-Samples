using System;
using System.ServiceModel.Web;
using RestWebService;

namespace SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServiceHost host=new WebServiceHost(typeof(OperatingSystemService),new Uri("http://localhost:8013/RESTWebservice/"));
            host.Open();
            Console.ReadKey();
            host.Close();
        }
    }
}
