using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    public class Shape
    {
        private int length;
        private int breadth;

        public Shape(int length):this(length,length)
        {
           // this.length = length;
            //this.breadth = length;
        }

        public Shape(int length,int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public int Area()
        {
            return length * breadth;
        }

        public int Perimeter()
        {
            return 2 * (length + breadth);
        }
    }
}
