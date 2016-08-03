using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLibrary.Fuel
{
    public class Petrol : FuelBase
    {
        public override string GetFuelType()
        {
            return "Petrol";
        }

        public override double GetPrice()
        {
            return 70;
        }
    }
}
