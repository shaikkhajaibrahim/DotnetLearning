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
            Console.WriteLine("Hello World! This is my first C# Program");


            Intrest intrest = new Intrest();
            intrest.SimpleIntrest();
            intrest.Prinicipal = 100000;
            intrest.RateOfIntrest = 12;
            intrest.TimeInYears = 2;
            Console.WriteLine("The intrest is "+intrest.SimpleIntrest());

            Number number = new Number();
            number.NumberValue = 100;
            if(number.IsEven())
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

            if(number.IsFactorOf(5))
            {
                Console.WriteLine("Number is factor of 5");
            }

            TrafficSignal signal = new TrafficSignal();
            signal.Signal = 1;
            Console.WriteLine(signal.DisplaySignal());
        }
    }
}
