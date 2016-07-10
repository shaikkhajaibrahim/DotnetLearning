using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.Read();

            int myFirstInteger;
            myFirstInteger = 10;
            Console.WriteLine(myFirstInteger);
            myFirstInteger = 20;
            Console.WriteLine(myFirstInteger);

            const int myFirstConstantInteger = 10;
            //myFirstConstantInteger = 20;
        }
    }
}
