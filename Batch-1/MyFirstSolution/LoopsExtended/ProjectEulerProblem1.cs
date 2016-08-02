using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExtended
{
    /// <summary>
    /// https://projecteuler.net/problem=1
    /// </summary>
    public class ProjectEulerProblem1
    {
        //public ProjectEulerProblem1()
        //{

        //}

        public ProjectEulerProblem1(int upperBound)
        {
            UpperBound = upperBound;
        }

        public int UpperBound { set; get; }

        private int number1 = 3;
        private int number2 = 5;

        public int SumOfNumbersBelowUpperBound()
        {
            int sum = 0;
            for(int index=1;index<UpperBound;index++)
            {
                if((index%number1==0)||(index%number2==0))
                {
                    Console.WriteLine(index);
                    sum += index;
                }

            }
            return sum;
        }
    }
}
