using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfHelloWorld;

namespace WebHosting
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculator" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Calculator.svc or Calculator.svc.cs at the Solution Explorer and start debugging.
    public class Calculator : ICalculatorService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Square(int a)
        {
            return a * a;
        }

        public void Ping()
        {
            Console.WriteLine("Client is pinging");
        }
    }
}
