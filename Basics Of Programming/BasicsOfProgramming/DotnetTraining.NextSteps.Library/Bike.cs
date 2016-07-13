using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTraining.NextSteps.Library
{
    public class Bike:Vehicle
    {
        public Bike(string engineType):base(engineType)
        {
            WheelCount = 2;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Wheel Count is " + WheelCount);
            Console.WriteLine("Engine is " + engineType);
        }

        public void Commute()
        {
            Console.WriteLine("Commuting in Bike");
        }

        public override void AdvancedCommute()
        {
            Console.WriteLine("Adv Commuting in Bike");
        }
    }
}
