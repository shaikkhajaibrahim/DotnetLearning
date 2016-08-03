using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Square & 2 For Rectangle");
            int input = ReadInt();
            Console.WriteLine("Enter Length");
            int length = ReadInt();
            int breadth = 0;
            if(input==2)
            {
                breadth = ReadInt();
            }
            Shape s;
            if (input == 1)
            {
                s = new Shape(length);
            }
            else
            {
                s = new Shape(length, breadth);
            }
            Console.WriteLine("Area is "+s.Area());
            Console.WriteLine("Perimeter is "+s.Perimeter());

        }

        static int ReadInt()
        {
            return int.Parse(Console.ReadLine());

        }
    }
}
