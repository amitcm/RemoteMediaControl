using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using System.ServiceModel.Description;

namespace MediaSvc
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost host = new ServiceHost(typeof(MediaService));

            host.Open();

            Console.WriteLine("The service is ready at {0}", host.BaseAddresses[0].AbsoluteUri);
            Console.WriteLine("The service is ready at {0}", host.BaseAddresses[0].AbsolutePath);
            Console.WriteLine("Press <Enter> to stop the service.");
            Console.ReadLine();

            // Close the ServiceHost.
            host.Close();
        }
    }
}
