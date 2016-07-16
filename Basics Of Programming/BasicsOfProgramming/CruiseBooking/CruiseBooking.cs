using DotnetTraining.NextSteps.Library.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseBooking
{
    public class CruiseBooking : VehicleBooking
    {
        public CruiseBooking(string source, string destination) : base(source, destination)
        {
        }

        public override double GetBookingAmount(int numberOfseats)
        {
            return 1000 * numberOfseats;
        }
    }
}
