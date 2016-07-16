using BookingDemo.Ship;
using DotnetTraining.NextSteps.Library.Contracts;
using DotnetTraining.NextSteps.Library.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CruiseBooking;

namespace BookingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Booking Application");
            Console.WriteLine("Enter 1 to Book Flights");
            Console.WriteLine("Enter 2 to Book Buses");
            Console.WriteLine("Enter 3 to Book Cruise");
            string userInput=Console.ReadLine();
            VehicleBooking booking = null;
            if(booking!=null)
            {
                Console.WriteLine(booking.Destination);
            }
            
            if(userInput=="1")
            {
                booking = new FlightBooking("HYD", "BNG");
            }
            else if(userInput=="2")
            {
                booking = new BusBooking("HYD", "BNG");
            }
            else
            {
                booking = new CruiseBooking.CruiseBooking("MUM", "CHE");
            }
            Console.WriteLine("Enter Number of Seats");
            string input = Console.ReadLine();

            try
            {
                int numberOfSeats = int.Parse(input);
                booking.Book(numberOfSeats);
                booking.PricePerPerson(numberOfSeats);
                //throw new DivideByZeroException();

                Console.WriteLine("Your Booking Amount is $" + booking.GetBookingAmount(numberOfSeats));
            }
           
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Invalid Input");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Invalid format");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Thanks");
            }




        }
    }
}
