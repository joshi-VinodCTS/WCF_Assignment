using System;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(TestServiceLibrary.Service1)))
            {
                host.Open();
                Console.WriteLine("Service Started...Press enter to exit");
                Console.Read();
            }
        }
    }
}
