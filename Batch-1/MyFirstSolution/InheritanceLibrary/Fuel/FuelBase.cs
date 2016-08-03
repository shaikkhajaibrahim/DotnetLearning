using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLibrary.Fuel
{
    public abstract class FuelBase
    {
        protected double price=0;

        public abstract string GetFuelType();

        public virtual double GetPrice()
        {
            return price;
        }
    }
}
