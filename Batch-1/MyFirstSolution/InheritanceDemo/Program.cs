using InheritanceLibrary;
using InheritanceLibrary.Engine;
using InheritanceLibrary.Fuel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Car c = new Car("353", "1");
            Bike b = new Bike("8864", "2");
            Console.WriteLine(c.GetVehicleDetails());
            Console.WriteLine(c.GetPrice());
            Console.WriteLine("Consolidate Price is " + c.GetConsolidatePrice());
            Console.WriteLine("Bike Details");
            Console.WriteLine(b.GetVehicleDetails());
            Console.WriteLine(b.GetPrice());

            //Liskovs Substitution
            // A a=new B();
            Console.WriteLine("Assigning Car object to Vehicle");
            Vehicle v = c;
            Console.WriteLine(v.GetVehicleDetails());
            Console.WriteLine(v.GetPrice());
            Console.WriteLine("Consolidate Price is " + v.GetConsolidatePrice());

            IEngine a = new FiatEngine();
            TestEngine(a);

            a = new ToyotaEngine();
            TestEngine(a);

            a = new LocalEngine();
            TestEngine(a);

            FuelBase fb = new Petrol();
            DisplayFuelDetails(fb);

            fb = new Diesel();
            DisplayFuelDetails(fb);

        }

        private static void DisplayFuelDetails(FuelBase fb)
        {
            Console.WriteLine(fb.GetFuelType());
            Console.WriteLine(fb.GetPrice());
        }

        private static void TestEngine(IEngine a)
        {
            a.Start();
            a.Stop();
        }
    }
}
