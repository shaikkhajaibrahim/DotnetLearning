using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExtended
{
    class Program
    {
        static void Main(string[] args)
        {

            int choice = 0;
            if(choice==0)
            {
                //Console.WriteLine("Enter number ");
                //int input = int.Parse(Console.ReadLine());
                int index = 0;
                DateTime startTime = DateTime.Now;
                for (int input = 10; input <= 10000; input++)
                {
                    Number number = new Number();
                    number.NumberValue = input;
                    //if (number.IsPrimeNumber())
                    //{
                    //    Console.WriteLine(input + " is prime");
                    //}
                    //else
                    //{
                    //    Console.WriteLine(input + " is not prime");

                    //}
                    if (number.IsPrimeUsingFor())
                    {
                        //Console.WriteLine(input + " is prime");
                        Console.WriteLine(input);
                        index++;
                    }
                    //else
                    //{
                    //    Console.WriteLine(input + " is not prime");

                    //}

                }
                DateTime endTime = DateTime.Now;
                Console.WriteLine("Total Number of Seconds are " + (endTime - startTime).TotalSeconds);
                Console.WriteLine("Number of Prime Numbers found are " + index);

            }
            else
            {
                ProjectEulerProblem1 problem1 = new ProjectEulerProblem1(1000);
                //problem1.UpperBound = 1000;
                Console.WriteLine(problem1.SumOfNumbersBelowUpperBound());

            }
            
            


        }
    }
}
