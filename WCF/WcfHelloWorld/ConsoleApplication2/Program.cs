using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            CalculatorServiceClient client=new CalculatorServiceClient();
            Console.WriteLine(client.Add(3, 5));
            Console.ReadLine();
        }
    }
}
