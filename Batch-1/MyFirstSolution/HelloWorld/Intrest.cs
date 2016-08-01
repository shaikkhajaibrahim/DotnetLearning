using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    /// <summary>
    /// This program will be used to calculate intrests
    /// </summary>
    public class Intrest
    {
        private double principal;

        private double timeInYears;

        const int HUNDRED = 100;

        //private double rateOfIntrest;

        /// <summary>
        /// This method will be used to  calculate simple Intrest.
        /// </summary>
        /// <returns></returns>
        public double SimpleIntrest()
        {
            bool isPrincipalZero = (principal == 0);
            bool isTimeZero = (TimeInYears == 0);
            bool isRateOfIntrestZero = (RateOfIntrest == 0);

            if(isPrincipalZero || isTimeZero|| isRateOfIntrestZero)
            {
                Console.WriteLine("Enter Valid Values");
                return 0;
            }


            return Prinicipal*TimeInYears * RateOfIntrest/HUNDRED;
        }

        public double Prinicipal
        {
            get
            {
                return principal;
            }
            set
            {
                principal = value;
            }
        }

        public double TimeInYears
        {
            get
            {
                //Console.WriteLine("Geting Time In Years");
                return timeInYears;
            }
            set
            {
                timeInYears = value;
            }
        }

        public double RateOfIntrest { set; get; }






    }
}
