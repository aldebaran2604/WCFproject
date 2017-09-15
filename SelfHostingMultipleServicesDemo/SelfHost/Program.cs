using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathServiceLibrary;
using CalcServiceLibrary;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceHost1 = new ServiceHost(typeof(CalcService));
            var serviceHost2 = new ServiceHost(typeof(MathService));

            ServiceEndpoint BasicHttpEndPoint2 = serviceHost1.AddServiceEndpoint(
                typeof(ICalcService),
                new BasicHttpBinding(),
                "http://127.0.0.1:5555/CalcService"
            );

            ServiceEndpoint BasicHttpEndPoint1 = serviceHost2.AddServiceEndpoint(
                typeof(IMathService),
                new BasicHttpBinding(),
                "http://127.0.0.1:4444/MathService"
            );

            serviceHost1.Open();
            serviceHost2.Open();

            foreach (ServiceEndpoint endpoint in serviceHost2.Description.Endpoints)
            {
                Console.WriteLine(
                    "Address: {0} Binding Name: {1}",
                    endpoint.Address.ToString(),
                    endpoint.Binding.Name
                );
            }
            foreach (ServiceEndpoint endpoint in serviceHost1.Description.Endpoints)
            {
                Console.WriteLine(
                    "Address: {0} Binding Name: {1}",
                    endpoint.Address.ToString(),
                    endpoint.Binding.Name
                );
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to stop your WCF Math service.");
            Console.ReadKey();

            serviceHost2.Close();
            serviceHost1.Close();

        }
    }
}
