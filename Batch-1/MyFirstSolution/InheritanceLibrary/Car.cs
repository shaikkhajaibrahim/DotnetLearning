using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLibrary
{
    public class Car:Vehicle
    {
        public Car(string registrationNumber,string parkingId):base(registrationNumber,parkingId)
        {

        }

        public int GetPrice()
        {
            return 20;
        }

        public override int GetConsolidatePrice()
        {
            return 20;
        }
    }
}
