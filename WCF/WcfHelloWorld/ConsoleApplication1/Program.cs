using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.MyServiceReference;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client=new Service1Client();
            Console.WriteLine(client.Add(3, 5));
        }
    }
}
