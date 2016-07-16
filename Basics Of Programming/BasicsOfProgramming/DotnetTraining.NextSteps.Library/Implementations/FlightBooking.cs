using DotnetTraining.NextSteps.Library.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTraining.NextSteps.Library.Implementations
{
    public class FlightBooking : VehicleBooking
    {
        public FlightBooking(string source, string destination) : base(source, destination)
        {
        }

        public override double GetBookingAmount(int numberOfseats)
        {
            return 400 * numberOfseats;
        }
    }
}
