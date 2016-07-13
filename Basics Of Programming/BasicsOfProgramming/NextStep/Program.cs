using DotnetTraining.NextSteps.Library;
using DotnetTraining.NextSteps.Library.Contracts;
using DotnetTraining.NextSteps.Library.Implementations;
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

            Vehicle vehicle1 = new Bike("Yamaha");
            DisplayVehicleInfo(vehicle1);
            if(vehicle1 is Car)
            {
                DisplayCarInfo((Car)vehicle1);
            }
            else
            {
                // Safe Cast
                Bike b1 = vehicle1 as Bike;
                if(b1!=null)
                {
                    Console.WriteLine("B1 is Bike");
                }
                else
                {
                    Console.WriteLine("B1 is not Bike");
                }
                Bike b2 = vehicle as Bike;
                if(b2!=null)
                {
                    Console.WriteLine("B2 is Bike");
                }
                else
                {
                    Console.WriteLine("B2 is not Bike");
                    Console.WriteLine("Type of B2 is "+vehicle.GetType());
                }
            }

            IEngine engine1 = new Tcdi();
            IEngine engine2 = new VVTT();
            

        }

        public void DisplayEngineDetails(IEngine engine)
        {
            Console.WriteLine(   engine.GetEngineModel());
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
