using DotnetTraining.NextSteps.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextStep
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car ford = new Car("TCDI");
            //DisplayCarInfo(ford);
            

            //  Assign Derived class instance to Base class
            Vehicle vehicle = new Car("TCDI");
            //Base to Derived --> Type Casting is required
            DisplayVehicleInfo(vehicle);
            DisplayCarInfo((Car)vehicle);


            //Car carFromVehicle = (Car)vehicle;
            //DisplayCarInfo(carFromVehicle);
            //DisplayVehicleInfo(carFromVehicle);

            //Conversion from any thing to string 
            //int a = 5;
            //a.ToString();
            //Object i = vehicle;
            //base class of all Classes is Object (System.Object)

            string number = "5";
            int convertedNumber = int.Parse(number);
            //Try Parse

        }

        private static void DisplayVehicleInfo(Vehicle vehicle)
        {
            Console.WriteLine("Started Display of Vehicle");
            vehicle.WheelCount = 4;
            vehicle.Commute();
            vehicle.AdvancedCommute();
            Console.WriteLine("Finished Display of Vehicle");
        }

        public static void DisplayCarInfo(Car car)
        {
            Console.WriteLine("Started Display of Car");
            car.WheelCount = 4;
            car.Commute();
            car.AdvancedCommute();
            car.DisplayInfo();
            Console.WriteLine("Finished Display of Car");
                
        }

        
    }
}
