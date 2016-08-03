using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLibrary.Fuel
{
    public class Diesel:FuelBase
    {
        public override string GetFuelType()
        {
            return "Diesel";
        }

        public override double GetPrice()
        {
            return 65;
        }
    }
}
