#region Namespace Imports

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTelevison;
#endregion

//Name Space Declaration
namespace HelloWorld
{
    // Class
    class Program
    {
        // Methods (Main Method)
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

            Television t = new Television();
            t.StreamVideos();

        }
    }
}
