using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class TrafficSignal
    {
        public int Signal { set; get; }

        public string DisplaySignal()
        {
            string color = string.Empty;
            //if(Signal==0)
            //{
            //    color = "RED";
            //}
            //else
            //{
            //    if(Signal==1)
            //    {
            //        color = "GREEN";
            //    }
            //    else
            //    {
            //        color = "YELLOW";
            //    }

            //}

            if(Signal==0)
            {
                color = "RED";

            }
            else if (Signal==1)
            {
                color = "GREEN";

            }
            else if (Signal==2)
            {
                color = "YELLOW";
            }
            else
            {
                color = string.Empty;
            }
            return color;
        }
    }
}
