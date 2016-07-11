using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTraining.NamespaceDemo.Library
{
    public class MyNumber
    {
        public MyNumber(int number)
        {
            this.number = number;
        }

        public bool IsEven()
        {
            bool isEven = false;
            if(number%2==0)
            {
                isEven = true;
            }
            return isEven;
        }

        public bool IsOdd()
        {
            return !IsEven();
        }

        public string GetSignalColor()
        {
            string color;
            if (number==0)
            {
                color = "Red";
            }
            else
            {
                if(number==1)
                {
                    color = "Orange";
                }
                else
                {
                    color = "Green";
                }
            }
            return color;
        }

        public string GetSignalColorPremium()
        {
            string color;

            if (number == 0)
            {
                color= "Red";
            }
            else if (number == 1)
            {
                color= "Orange";

            }
            else
            {
                color= "Green";
            }
            return color;
        }

        private int number;

       
    }
}
