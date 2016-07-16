using DotnetTraining.NextSteps.Library.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingDemo.Ship
{
    public class ShipBooking : VehicleBooking
    {
        public ShipBooking(string source, string destination) : base(source, destination)
        {
        }

        public override double GetBookingAmount(int numberOfseats)
        {
            return 300 * numberOfseats;
        }
    }
}
