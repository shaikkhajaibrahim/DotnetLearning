using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTraining.NextSteps.Library.Contracts
{
    public abstract class VehicleBooking
    {
        public VehicleBooking(string source, string destination)
        {
            Source = source;
            Destination = destination;
        }

        public string Destination { get; protected set; }
        public string Source { get; protected set; }

        public virtual void Book(int numberOfSeats)
        {
            Console.WriteLine("Booking"+numberOfSeats+" Seats");
        }

        public virtual double PricePerPerson(int numberOfSeats)
        {
            try
            {
                return 1000 / numberOfSeats;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                throw;
                //return 0;
            }
        }
        

        public abstract double GetBookingAmount(int numberOfseats);

       
        
    }
}
