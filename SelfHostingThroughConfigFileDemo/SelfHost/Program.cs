using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathServiceLibrary;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var serviceHost = new ServiceHost(typeof(MathService)))
            {
                /*ServiceEndpoint BasicHttpEndPoint1 = serviceHost.AddServiceEndpoint(
                    typeof(IMathService),
                    new BasicHttpBinding(),
                    "http://127.0.0.1:4444/MathService"
                );

                ServiceEndpoint BasicHttpEndPoint2 = serviceHost.AddServiceEndpoint(
                    typeof(IMathService),
                    new BasicHttpBinding(),
                    "http://127.0.0.1:5555/MathService"
                );

                ServiceEndpoint NettcpEndPoint = serviceHost.AddServiceEndpoint(
                    typeof(IMathService),
                    new NetTcpBinding(),
                    "net.tcp://127.0.0.1:6666/IMathService"
                );*/

                serviceHost.Open();

                Console.WriteLine("Your WCF service is running.");
                Console.WriteLine(
                    "Your WCF Math service is running and is listening on below endpoint:"
                );
                /*Console.WriteLine(
                    "{0} ({1})",
                    BasicHttpEndPoint1.Address.ToString(),
                    BasicHttpEndPoint1.Binding.Name
                );*/

                foreach (ServiceEndpoint endpoint in serviceHost.Description.Endpoints)
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

                serviceHost.Close();
            }
        }
    }
}
