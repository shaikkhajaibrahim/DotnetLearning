using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Number
    {
        public int NumberValue { set; get; }

        public bool IsEven()
        {
            return (NumberValue % 2 == 0);
        }

        public bool IsOdd()
        {
            return (NumberValue % 2 != 0);
        }

        public bool IsFactorOf(int n)
        {
            return NumberValue % n == 0;
        }
    }
}
