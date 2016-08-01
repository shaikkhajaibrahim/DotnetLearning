using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld;

namespace OperatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool toBeContinued = true;
            while(toBeContinued)
            {
                Intrest i = new Intrest();
                i.SimpleIntrest();
                Console.WriteLine("Enter Principal Amount");
                string input = Console.ReadLine();
                i.Prinicipal = double.Parse(input);
                Console.WriteLine("Enter Time in Years");
                i.TimeInYears = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Rate of Intrest");
                i.RateOfIntrest = double.Parse(Console.ReadLine());
                Console.WriteLine("The simple intrest is " + i.SimpleIntrest());

                Console.WriteLine("Enter Y to continue & any other key to exit");
                string userInput = Console.ReadLine();
                toBeContinued = (userInput == "Y");

            }

            
        }
    }
}
