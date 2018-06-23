﻿using System;
using System.ServiceModel;

namespace EmployeeServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(EmployeeService.EmployeeService)))
            {
                host.Open();
                Console.WriteLine("Host started @" + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
