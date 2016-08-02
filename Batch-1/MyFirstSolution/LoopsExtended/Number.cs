using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExtended
{
    /// <summary>
    /// NUmber class containg methods for calculation on Numbers
    /// </summary>
    public class Number
    {
        public static int count=0;

        public int instanceVarCount = 0;

        public Number()
        {
            count++;
            instanceVarCount++;
            Console.WriteLine("Count is "+count);
            Console.WriteLine("Instance Var count "+instanceVarCount);
        }

        /// <summary>
        /// Value of number for this class
        /// </summary>
        public int NumberValue { set; get; }

        /// <summary>
        /// This method returns true if the <see cref="NumberValue"/> is Prime
        /// else false
        /// </summary>
        /// <returns></returns>
        public static bool IsPrimeNumber(int number)
        {
            int index = 2;
            bool isPrime = true;
            while(index<(number/2))
            {
                if (number % index == 0)
                {
                    isPrime = false;
                }
                index++;

            }

            return isPrime;
        }

        public bool IsPrimeUsingFor()
        {
            bool isPrime = true;
            for (int index=2; index<NumberValue/2;index++)
            {
                if (NumberValue % index == 0)
                {
                    isPrime = false;
                }

            }
            return isPrime;

        }
    }
}
