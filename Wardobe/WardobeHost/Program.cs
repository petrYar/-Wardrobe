﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace WardobeHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WardobeLibrary.WCFClasses.AccountService)))
            {
                host.Open();
                Console.WriteLine("Host started!");
                Console.ReadKey();
            }
        }
    }
}
